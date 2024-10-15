using System;

namespace DigitalAssetManagement.Entity;

public class Reservation
{
    public int ReservationId { get; set; } // Primary Key
    public int AssetId { get; set; } // Foreign Key, references Asset
    public int EmployeeId { get; set; } // Foreign Key, references Employee
    public DateTime ReservationDate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; }
}
