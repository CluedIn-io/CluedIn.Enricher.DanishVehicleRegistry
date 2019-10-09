using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using CluedIn.Core.Data;
using CluedIn.Core.Data.Parts;
using CluedIn.Core.Messages.Processing;
using CluedIn.Core.Processing;
using CluedIn.Core.Serialization;
using CluedIn.Core.Workflows;
using CluedIn.ExternalSearch;
using CluedIn.ExternalSearch.Providers.DanishVehicleRegistry;
using CluedIn.Testing.Base.Context;
using CluedIn.Testing.Base.ExternalSearch;
using CluedIn.Testing.Base.Processing.Actors;
using Moq;
using Xunit;

namespace ExternalSearch.DanishVehicleRegistry.Integration.Tests
{
    public class DanishVehicleRegistryTests : BaseExternalSearchTest<DanishVehicleRegistryExternalSearchProvider>
    {
	    [Fact(Skip = "Issue 170 - Test Failures")]
		public void Test()
		{
			// Arrange
			this.testContext = new TestContext();
			var properties = new EntityMetadataPart();
			properties.Properties.Add(CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.Birthday, "1961-04-13T00:00:00.0000000+00:00");
			properties.Properties.Add(CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.HomeAddressCountryCode, "DK");
			properties.Properties.Add(CluedIn.Core.Data.Vocabularies.Vocabularies.CluedInUser.EmailAddresses, "someone@example.dk");
			IEntityMetadata entityMetadata = new EntityMetadataPart()
			{
				Name = "Laila Pedersen", // someone who's in Tinglysning because there is debt in the car
				EntityType = EntityType.Infrastructure.User,
				Properties = properties.Properties
			};

			var externalSearchProvider = new Mock<DanishVehicleRegistryExternalSearchProvider>(MockBehavior.Loose);
			var clues = new List<CompressedClue>();

			externalSearchProvider.CallBase = true;

			this.testContext.ProcessingHub.Setup(h => h.SendCommand(It.IsAny<ProcessClueCommand>())).Callback<IProcessingCommand>(c => clues.Add(((ProcessClueCommand)c).Clue));

			this.testContext.Container.Register(Component.For<IExternalSearchProvider>().UsingFactoryMethod(() => externalSearchProvider.Object));

			var context = this.testContext.Context.ToProcessingContext();
			var command = new ExternalSearchCommand();
			var actor = new ExternalSearchProcessingAccessor(context.ApplicationContext);
			var workflow = new Mock<Workflow>(MockBehavior.Loose, context, new EmptyWorkflowTemplate<ExternalSearchCommand>());

			workflow.CallBase = true;

			command.With(context);
			command.OrganizationId = context.Organization.Id;
			command.EntityMetaData = entityMetadata;
			command.Workflow = workflow.Object;
			context.Workflow = command.Workflow;

			// Act
			var result = actor.ProcessWorkflowStep(context, command);
			Assert.Equal(WorkflowStepResult.Repeat.SaveResult, result.SaveResult);

			result = actor.ProcessWorkflowStep(context, command);
			Assert.Equal(WorkflowStepResult.Success.SaveResult, result.SaveResult);
			context.Workflow.AddStepResult(result);

			context.Workflow.ProcessStepResult(context, command);

			// Assert
			this.testContext.ProcessingHub.Verify(h => h.SendCommand(It.IsAny<ProcessClueCommand>()), Times.AtLeastOnce);

			Assert.True(clues.Count > 0);
		}
	}
}