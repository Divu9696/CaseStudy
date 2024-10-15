using System;
using DigitalAssetManagement.Entity;
using DigitalAssetManagement.BusinessLayer.Dao.Repository;

namespace DigitalAssetManagement.BusinessLayer.Dao.Services;

public class AssetService : IAssetService
{
        private readonly IAssetRepository _assetRepository;

        public AssetService(IAssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }

        public bool AddAsset(Asset asset)
        {
            return _assetRepository.AddAsset(asset);
        }

        public bool UpdateAsset(Asset asset)
        {
            return _assetRepository.UpdateAsset(asset);
        }

        public bool DeleteAsset(int assetId)
        {
            return _assetRepository.DeleteAsset(assetId);
        }

        public Asset GetAssetById(int assetId)
        {
            return _assetRepository.GetAssetById(assetId);
        }

        public List<Asset> GetAllAssets()
        {
            return _assetRepository.GetAllAssets();
        }
}
