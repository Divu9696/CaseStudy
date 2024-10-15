using System;
using NUnit.Framework;
using DigitalAssetManagement.Entity;
using DigitalAssetManagement.BusinessLayer;
using DigitalAssetManagement.BusinessLayer.Dao.Repository;
using DigitalAssetManagement.Exception;

namespace DigitalAssetManagement.Test;

public class MaintenanceRecordRepositoryTests
{
    private MaintenanceRecordsRepository _repository;
    [SetUp]
        public void Setup()
        {
            // Initialize the MaintenanceRecordRepository instance before each test
            _repository = new MaintenanceRecordsRepository();
        }

        [Test]
        public void PerformMaintenance_ShouldAddMaintenanceRecord()
        {
            // Arrange: Set up the parameters for the maintenance record
            var maintenanceRecord = new MaintenanceRecord
            {
                MaintenanceId=1,
                AssetId=1,
                MaintenanceDate=DateTime.Now,
                Description="Routine Check",
                Cost=100.0
            };
            
            // Act: Call the PerformMaintenance method with the parameters
            bool result = _repository.PerformMaintenance(maintenanceRecord.AssetId, maintenanceRecord.MaintenanceDate, maintenanceRecord.Description, maintenanceRecord.Cost);

            // Assert: Verify that the maintenance record was added successfully
            Assert.IsTrue(result);
        }

        [Test]
        public void PerformMaintenance_ShouldThrowExceptionForDuplicateId()
        {
            // Arrange: Set up the parameters for the maintenance record
            var maintenanceRecord = new MaintenanceRecord
            {
                MaintenanceId=1,
                AssetId=1,
                MaintenanceDate=DateTime.Now,
                Description="Routine Check",
                Cost=100.0
            };

            // Act: Call the PerformMaintenance method with the parameters
            _repository.PerformMaintenance(maintenanceRecord.AssetId, maintenanceRecord.MaintenanceDate, maintenanceRecord.Description, maintenanceRecord.Cost);

            // Assert: Verify that an exception is thrown when adding a duplicate maintenance record
            Assert.Throws<MaintenanceException>(() =>
                _repository.PerformMaintenance(maintenanceRecord.AssetId, maintenanceRecord.MaintenanceDate, maintenanceRecord.Description, maintenanceRecord.Cost));
        }
}
