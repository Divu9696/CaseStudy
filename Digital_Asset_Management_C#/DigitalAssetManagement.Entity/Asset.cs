using System;

namespace DigitalAssetManagement.Entity;

public class Asset
{   
    public int AssetId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string SerialNumber { get; set; }
    // public string PurchaseDate { get; set; }
    public string PurchaseDate { get; set; }
    public string Location { get; set; }
    public string Status { get; set; }
    public int OwnerId { get; set; }

    
    
}
