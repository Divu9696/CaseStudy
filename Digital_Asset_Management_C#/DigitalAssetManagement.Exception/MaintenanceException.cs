using System;

namespace DigitalAssetManagement.Exception;

public class MaintenanceException : System.Exception
{
    public MaintenanceException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
}
