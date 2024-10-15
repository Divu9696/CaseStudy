using System;

namespace DigitalAssetManagement.Entity;

public class AssetAllocation
{
    public int AllocationId { get; set; } // Primary Key
    public int AssetId { get; set; } // Foreign Key, references Asset
    public int EmployeeId { get; set; } // Foreign Key, references Employee
    public DateTime AllocationDate { get; set; }
    public DateTime? ReturnDate { get; set; }

}
