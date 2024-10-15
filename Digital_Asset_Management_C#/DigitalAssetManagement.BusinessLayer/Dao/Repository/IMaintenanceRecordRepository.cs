using System;
using DigitalAssetManagement.Entity;
namespace DigitalAssetManagement.BusinessLayer.Dao.Repository;

public interface IMaintenanceRecordRepository
{
    bool PerformMaintenance(int assetId, DateTime maintenanceDate, string description, double cost);
}
