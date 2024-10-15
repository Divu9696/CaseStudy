using System;
using NUnit.Framework;
using DigitalAssetManagement.Entity;
using DigitalAssetManagement.BusinessLayer;
using DigitalAssetManagement.BusinessLayer.Dao.Repository;
using DigitalAssetManagement.Exception;

namespace DigitalAssetManagement.Test;

public class AssetAllocationRepositoryTests
{
        // Private field of type AssetAllocationRepository that stores the AssetAllocationRepository object
        private AssetAllocationRepository _repository;

        // Setup method that runs before each test method
        [SetUp]

        // Instantiate the AssetAllocationRepository object
        public void Setup()
        {
            // Assign the parameter to the private field
            _repository = new AssetAllocationRepository();
        }

        [Test]
        // Test method for the AllocateAsset method
        public void AllocateAsset_ShouldReturnTrue_WhenAllocationIsSuccessful()
        {
            // Create a new AssetAllocation object
            var allocation = new AssetAllocation
            {
                AssetId = 1,
                EmployeeId = 1,
                AllocationDate = DateTime.Now
            };
            // Call the AllocateAsset method of the AssetAllocationRepository class and store the result in a variable
            var result = _repository.AllocateAsset(allocation.AssetId,allocation.EmployeeId,allocation.AllocationDate);
            // Assert that the result is true (successful allocation)
            Assert.IsTrue(result);
        }

        [Test]
        // Test method for the AllocateAsset method
        public void AllocateAsset_ShouldReturnFalse_WhenAllocationFails()
        {
            // Create a new AssetAllocation object with an invalid asset ID to simulate failure
            var allocation = new AssetAllocation
            {
                AssetId = -1, // Invalid asset ID to simulate failure
                EmployeeId = 1,
                AllocationDate = DateTime.Now
            };
            // Call the AllocateAsset method of the AssetAllocationRepository class and store the result in a variable
            var result = _repository.AllocateAsset(allocation.AssetId,allocation.EmployeeId,allocation.AllocationDate);
            // Assert that the result is false (failed allocation)
            Assert.IsFalse(result);
        }

        [Test]
        // Test method for the DeallocateAsset method
        public void DeallocateAsset_ShouldReturnTrue_WhenDeallocationIsSuccessful()
        {
            // Call the DeallocateAsset method of the AssetAllocationRepository class and store the result in a variable
            var result = _repository.DeallocateAsset(1,7, DateTime.Now);
            // Assert that the result is true (successful deallocation)
            Assert.IsTrue(result);
        }

        [Test]
        // Test method for the DeallocateAsset method with an invalid allocation ID
        public void DeallocateAsset_ShouldReturnFalse_WhenDeallocationFails()
        {
            // Call the DeallocateAsset method of the AssetAllocationRepository class with an invalid allocation ID and store the result in a variable
            var result = _repository.DeallocateAsset(-1, -1,DateTime.Now); // Invalid allocation ID to simulate failure
            // Assert that the result is false (failed deallocation)
            Assert.IsFalse(result);
        }

        
}
