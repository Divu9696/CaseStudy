using System;
using DigitalAssetManagement.Entity;
namespace DigitalAssetManagement.BusinessLayer.Dao.Services;

public interface IMaintenanceRecordService
{
    bool PerformMaintenance(int assetId, DateTime maintenanceDate, string description, double cost);

}
