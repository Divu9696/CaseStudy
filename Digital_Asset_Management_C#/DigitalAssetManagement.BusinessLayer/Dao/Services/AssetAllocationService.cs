using System;
using DigitalAssetManagement.Entity;
using DigitalAssetManagement.BusinessLayer.Dao.Repository;

namespace DigitalAssetManagement.BusinessLayer.Dao.Services;

public class AssetAllocationService : IAssetAllocationService
{
        private readonly IAssetAllocationRepository _assetAllocationRepository;

        // Constructor to inject the repository
        public AssetAllocationService(IAssetAllocationRepository assetAllocationRepository)
        {
            _assetAllocationRepository = assetAllocationRepository;
        }

        public bool AllocateAsset(int assetId, int employeeId, DateTime allocationDate, DateTime? returnDate = null)
        {
            // Call the repository method for allocating an asset
            return _assetAllocationRepository.AllocateAsset(assetId, employeeId, allocationDate, returnDate);
        }

        public bool DeallocateAsset(int assetId, int employeeId, DateTime? returnDate)
        {
            // Call the repository method for deallocating an asset
            return _assetAllocationRepository.DeallocateAsset(assetId, employeeId, returnDate);
        }
}
