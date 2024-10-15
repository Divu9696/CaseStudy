using System;

namespace DigitalAssetManagement.Exception;

public class AssetNotFoundException : System.Exception
{
    public AssetNotFoundException(string message) : base(message) { }

    public AssetNotFoundException(string message, System.Exception innerException)
        : base(message, innerException) { }
}
