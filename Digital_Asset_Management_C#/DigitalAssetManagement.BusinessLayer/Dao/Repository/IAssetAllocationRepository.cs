using System;
using System.Collections.Generic;
using DigitalAssetManagement.Entity;

namespace DigitalAssetManagement.BusinessLayer.Dao.Repository;

public interface IAssetAllocationRepository
{
    bool AllocateAsset(int assetId, int employeeId, DateTime allocationDate, DateTime? returnDate = null);
    bool DeallocateAsset(int assetId, int employeeId, DateTime? returnDate);
}
