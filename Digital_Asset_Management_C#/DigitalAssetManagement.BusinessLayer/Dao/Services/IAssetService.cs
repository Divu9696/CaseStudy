using System;
using DigitalAssetManagement.Entity;
namespace DigitalAssetManagement.BusinessLayer.Dao.Services;

public interface IAssetService
{
    bool AddAsset(Asset asset);
        bool UpdateAsset(Asset asset);
        bool DeleteAsset(int assetId);
        Asset GetAssetById(int assetId);
        List<Asset> GetAllAssets();
}
