using Newtonsoft.Json;

namespace CluedIn.ExternalSearch.Providers.DanishVehicleRegistry.Models
{
	public class MotorRegistryResponse
	{
		[JsonProperty("VehicleID")]
		public long VehicleId { get; set; }

		[JsonProperty("VehicleIdentityNumber")]
		public string VehicleIdentityNumber { get; set; }

		[JsonProperty("VehicleKindNumber")]
		public string VehicleKindNumber { get; set; }

		[JsonProperty("VehicleKindName")]
		public string VehicleKindName { get; set; }

		[JsonProperty("VehicleUsageNumber")]
		public string VehicleUsageNumber { get; set; }

		[JsonProperty("VehicleUsageName")]
		public string VehicleUsageName { get; set; }

		[JsonProperty("VehiclePostalCode")]
		public string VehiclePostalCode { get; set; }

		[JsonProperty("LeasingValidFrom")]
		public string LeasingValidFrom { get; set; }

		[JsonProperty("LeasingValidTo")]
		public string LeasingValidTo { get; set; }

		[JsonProperty("LicensePlateNumber")]
		public string LicensePlateNumber { get; set; }

		[JsonProperty("LicensePlateValidFrom")]
		public string LicensePlateValidFrom { get; set; }

		[JsonProperty("LicensePlateValidTo")]
		public string LicensePlateValidTo { get; set; }

		[JsonProperty("LicensePlateExpirationDate")]
		public string LicensePlateExpirationDate { get; set; }

		[JsonProperty("VehicleInfoCreatedFrom")]
		public string VehicleInfoCreatedFrom { get; set; }

		[JsonProperty("VehicleInfoStatus")]
		public string VehicleInfoStatus { get; set; }

		[JsonProperty("VehicleInfoStatusDate")]
		public string VehicleInfoStatusDate { get; set; }

		[JsonProperty("VehicleInfoFirstRegistrationDate")]
		public string VehicleInfoFirstRegistrationDate { get; set; }

		[JsonProperty("VehicleInfoVINNumber")]
		public string VehicleInfoVinNumber { get; set; }

		[JsonProperty("VehicleInfoVINNumberPlacement")]
		public string VehicleInfoVinNumberPlacement { get; set; }

		[JsonProperty("VehicleInfoModelYear")]
		public string VehicleInfoModelYear { get; set; }

		[JsonProperty("VehicleInfoTotalWeight")]
		public string VehicleInfoTotalWeight { get; set; }

		[JsonProperty("VehicleInfoOwnWeight")]
		public string VehicleInfoOwnWeight { get; set; }

		[JsonProperty("VehicleInfoRunningWeightMinimum")]
		public string VehicleInfoRunningWeightMinimum { get; set; }

		[JsonProperty("VehicleInfoRunningWeightMaximum")]
		public string VehicleInfoRunningWeightMaximum { get; set; }

		[JsonProperty("VehicleInfoTechnicalTotalWeight")]
		public string VehicleInfoTechnicalTotalWeight { get; set; }

		[JsonProperty("VehicleInfoRoadTrainWeight")]
		public string VehicleInfoRoadTrainWeight { get; set; }

		[JsonProperty("VehicleInfoAxleCount")]
		public string VehicleInfoAxleCount { get; set; }

		[JsonProperty("VehicleInfoAxlePressure")]
		public string VehicleInfoAxlePressure { get; set; }

		[JsonProperty("VehicleInfoPassengerCount")]
		public string VehicleInfoPassengerCount { get; set; }

		[JsonProperty("VehicleInfoSeatingSpotsMinimum")]
		public string VehicleInfoSeatingSpotsMinimum { get; set; }

		[JsonProperty("VehicleInfoSeatingSpotsMaximum")]
		public string VehicleInfoSeatingSpotsMaximum { get; set; }

		[JsonProperty("VehicleInfoStandingSpotsMinimum")]
		public string VehicleInfoStandingSpotsMinimum { get; set; }

		[JsonProperty("VehicleInfoStandingSpotsMaximum")]
		public string VehicleInfoStandingSpotsMaximum { get; set; }

		[JsonProperty("VehicleInfoConnectionOption")]
		public string VehicleInfoConnectionOption { get; set; }

		[JsonProperty("VehicleInfoConnectionWeightWithoutBreaks")]
		public string VehicleInfoConnectionWeightWithoutBreaks { get; set; }

		[JsonProperty("VehicleInfoConnectionWeightWithBreaks")]
		public string VehicleInfoConnectionWeightWithBreaks { get; set; }

		[JsonProperty("VehicleInfoTrailerTotalWeight")]
		public string VehicleInfoTrailerTotalWeight { get; set; }

		[JsonProperty("VehicleInfoStoolLoad")]
		public string VehicleInfoStoolLoad { get; set; }

		[JsonProperty("VehicleInfoSemiTrailerAllowedAxlePressure")]
		public string VehicleInfoSemiTrailerAllowedAxlePressure { get; set; }

		[JsonProperty("VehicleInfoMaximumSpeed")]
		public string VehicleInfoMaximumSpeed { get; set; }

		[JsonProperty("VehicleInfoRimTires")]
		public string VehicleInfoRimTires { get; set; }

		[JsonProperty("VehicleInfoAttachedSidecarVINNumber")]
		public string VehicleInfoAttachedSidecarVinNumber { get; set; }

		[JsonProperty("VehicleInfoNCAPTest")]
		public string VehicleInfoNcapTest { get; set; }

		[JsonProperty("VehicleInfoVValueAir")]
		public string VehicleInfoVValueAir { get; set; }

		[JsonProperty("VehicleInfoVValueMechanical")]
		public string VehicleInfoVValueMechanical { get; set; }

		[JsonProperty("VehicleInfoOtherEquipment")]
		public string VehicleInfoOtherEquipment { get; set; }

		[JsonProperty("VehicleInfoVehicleCondition")]
		public string VehicleInfoVehicleCondition { get; set; }

		[JsonProperty("VehicleInfo30PercentVan")]
		public string VehicleInfo30PercentVan { get; set; }

		[JsonProperty("VehicleInfoPullingAxles")]
		public string VehicleInfoPullingAxles { get; set; }

		[JsonProperty("VehicleInfoSuitableForTaxi")]
		public string VehicleInfoSuitableForTaxi { get; set; }

		[JsonProperty("VehicleInfoAxleDistance")]
		public string VehicleInfoAxleDistance { get; set; }

		[JsonProperty("VehicleInfoGaugeFront")]
		public string VehicleInfoGaugeFront { get; set; }

		[JsonProperty("VehicleInfoGaugeBack")]
		public string VehicleInfoGaugeBack { get; set; }

		[JsonProperty("VehicleInfoTypeNotificationNumber")]
		public string VehicleInfoTypeNotificationNumber { get; set; }

		[JsonProperty("VehicleInfoTypeApprovalNumber")]
		public string VehicleInfoTypeApprovalNumber { get; set; }

		[JsonProperty("VehicleInfoEUVariant")]
		public string VehicleInfoEuVariant { get; set; }

		[JsonProperty("VehicleInfoEUVersion")]
		public string VehicleInfoEuVersion { get; set; }

		[JsonProperty("VehicleInfoComment")]
		public string VehicleInfoComment { get; set; }

		[JsonProperty("VehicleInfoTypeApprovedCategory")]
		public string VehicleInfoTypeApprovedCategory { get; set; }

		[JsonProperty("VehicleInfoGearCount")]
		public string VehicleInfoGearCount { get; set; }

		[JsonProperty("VehicleInfoDoorCount")]
		public string VehicleInfoDoorCount { get; set; }

		[JsonProperty("VehicleInfoManufacturer")]
		public string VehicleInfoManufacturer { get; set; }

		[JsonProperty("VehicleInfoRoadAirSuspension")]
		public string VehicleInfoRoadAirSuspension { get; set; }

		[JsonProperty("VehicleInfoDanishApprovalNumber")]
		public string VehicleInfoDanishApprovalNumber { get; set; }

		[JsonProperty("VehicleInfoYear")]
		public string VehicleInfoYear { get; set; }

		[JsonProperty("VehicleInfoStartupDate")]
		public string VehicleInfoStartupDate { get; set; }

		[JsonProperty("VehicleInfoTrafficDamage")]
		public string VehicleInfoTrafficDamage { get; set; }

		[JsonProperty("VehicleInfoVeteranVehicleOriginal")]
		public string VehicleInfoVeteranVehicleOriginal { get; set; }

		[JsonProperty("VehicleInfoBrandTypeNumber")]
		public string VehicleInfoBrandTypeNumber { get; set; }

		[JsonProperty("VehicleInfoBrandTypeName")]
		public string VehicleInfoBrandTypeName { get; set; }

		[JsonProperty("VehicleInfoModelTypeNumber")]
		public string VehicleInfoModelTypeNumber { get; set; }

		[JsonProperty("VehicleInfoModelTypeName")]
		public string VehicleInfoModelTypeName { get; set; }

		[JsonProperty("VehicleInfoVariantTypeNumber")]
		public string VehicleInfoVariantTypeNumber { get; set; }

		[JsonProperty("VehicleInfoVariantTypeName")]
		public string VehicleInfoVariantTypeName { get; set; }

		[JsonProperty("VehicleInfoKindTypeNumber")]
		public string VehicleInfoKindTypeNumber { get; set; }

		[JsonProperty("VehicleInfoKindTypeName")]
		public string VehicleInfoKindTypeName { get; set; }

		[JsonProperty("VehicleInfoColorTypeNumber")]
		public string VehicleInfoColorTypeNumber { get; set; }

		[JsonProperty("VehicleInfoColorTypeName")]
		public string VehicleInfoColorTypeName { get; set; }

		[JsonProperty("VehicleInfoBodyTypeNumber")]
		public string VehicleInfoBodyTypeNumber { get; set; }

		[JsonProperty("VehicleInfoBodyTypeName")]
		public string VehicleInfoBodyTypeName { get; set; }

		[JsonProperty("VehicleInfoNormTypeNumber")]
		public string VehicleInfoNormTypeNumber { get; set; }

		[JsonProperty("VehicleInfoNormTypeName")]
		public string VehicleInfoNormTypeName { get; set; }

		[JsonProperty("VehicleEnvironmentCO2Release")]
		public string VehicleEnvironmentCo2Release { get; set; }

		[JsonProperty("VehicleEnvironmentEmissionCO")]
		public string VehicleEnvironmentEmissionCo { get; set; }

		[JsonProperty("VehicleEnvironmentEmissionHCPlusNOX")]
		public string VehicleEnvironmentEmissionHcPlusNox { get; set; }

		[JsonProperty("VehicleEnvironmentEmissionNOX")]
		public string VehicleEnvironmentEmissionNox { get; set; }

		[JsonProperty("VehicleEnvironmentParticles")]
		public string VehicleEnvironmentParticles { get; set; }

		[JsonProperty("VehicleEnvironmentOpacity")]
		public string VehicleEnvironmentOpacity { get; set; }

		[JsonProperty("VehicleEnvironmentParticleFilter")]
		public string VehicleEnvironmentParticleFilter { get; set; }

		[JsonProperty("VehicleEnvironmentSmokeDensity")]
		public string VehicleEnvironmentSmokeDensity { get; set; }

		[JsonProperty("VehicleEnvironmentRetrofitParticleFilter")]
		public string VehicleEnvironmentRetrofitParticleFilter { get; set; }

		[JsonProperty("VehicleMotorCylinderCount")]
		public string VehicleMotorCylinderCount { get; set; }

		[JsonProperty("VehicleMotorEngineCapacity")]
		public string VehicleMotorEngineCapacity { get; set; }

		[JsonProperty("VehicleMotorBiggestEffect")]
		public string VehicleMotorBiggestEffect { get; set; }

		[JsonProperty("VehicleMotorKmPerLiter")]
		public string VehicleMotorKmPerLiter { get; set; }

		[JsonProperty("VehicleMotorKmPerLiterPreCalc")]
		public string VehicleMotorKmPerLiterPreCalc { get; set; }

		[JsonProperty("VehicleMotorPlugInHybrid")]
		public string VehicleMotorPlugInHybrid { get; set; }

		[JsonProperty("VehicleMotorMileage")]
		public string VehicleMotorMileage { get; set; }

		[JsonProperty("VehicleMotorMileageDocumentation")]
		public string VehicleMotorMileageDocumentation { get; set; }

		[JsonProperty("VehicleMotorMarking")]
		public string VehicleMotorMarking { get; set; }

		[JsonProperty("VehicleMotorIdleSoundLevel")]
		public string VehicleMotorIdleSoundLevel { get; set; }

		[JsonProperty("VehicleMotorRunningSoundLevel")]
		public string VehicleMotorRunningSoundLevel { get; set; }

		[JsonProperty("VehicleMotorIdleSoundLevelSpeed")]
		public string VehicleMotorIdleSoundLevelSpeed { get; set; }

		[JsonProperty("VehicleMotorInnovativeTech")]
		public string VehicleMotorInnovativeTech { get; set; }

		[JsonProperty("VehicleMotorInnovativeTechCount")]
		public string VehicleMotorInnovativeTechCount { get; set; }

		[JsonProperty("VehicleMotorElectricalConsumption")]
		public string VehicleMotorElectricalConsumption { get; set; }

		[JsonProperty("VehicleMotorFuelMode")]
		public string VehicleMotorFuelMode { get; set; }

		[JsonProperty("VehicleMotorGasConsumption")]
		public string VehicleMotorGasConsumption { get; set; }

		[JsonProperty("VehicleMotorElectricalRange")]
		public string VehicleMotorElectricalRange { get; set; }

		[JsonProperty("VehicleMotorBatteryCapacity")]
		public string VehicleMotorBatteryCapacity { get; set; }

		[JsonProperty("VehicleMotorDrivingForceNumber")]
		public string VehicleMotorDrivingForceNumber { get; set; }

		[JsonProperty("VehicleMotorDrivingForceName")]
		public string VehicleMotorDrivingForceName { get; set; }

		[JsonProperty("VehicleInspectionResultType")]
		public string VehicleInspectionResultType { get; set; }

		[JsonProperty("VehicleInspectionResultDate")]
		public string VehicleInspectionResultDate { get; set; }

		[JsonProperty("VehicleInspectionResult")]
		public string VehicleInspectionResult { get; set; }

		[JsonProperty("VehicleInspectionResultStatus")]
		public string VehicleInspectionResultStatus { get; set; }

		[JsonProperty("VehicleInspectionResultStatusDate")]
		public string VehicleInspectionResultStatusDate { get; set; }

		[JsonProperty("VehicleInspectionResultMileage")]
		public string VehicleInspectionResultMileage { get; set; }

		[JsonProperty("VehicleInspectionResultReinspectionMeetingDate")]
		public string VehicleInspectionResultReinspectionMeetingDate { get; set; }

		[JsonProperty("VehicleRegistrationStatus")]
		public string VehicleRegistrationStatus { get; set; }

		[JsonProperty("VehicleRegistrationDate")]
		public string VehicleRegistrationDate { get; set; }
	}
}