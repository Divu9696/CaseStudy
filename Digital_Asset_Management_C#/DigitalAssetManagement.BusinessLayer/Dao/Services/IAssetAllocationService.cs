using System;
using DigitalAssetManagement.Entity;
namespace DigitalAssetManagement.BusinessLayer.Dao.Services;

public interface IAssetAllocationService
{
    bool AllocateAsset(int assetId, int employeeId, DateTime allocationDate, DateTime? returnDate = null);
    bool DeallocateAsset(int assetId, int employeeId, DateTime? returnDate);
}
