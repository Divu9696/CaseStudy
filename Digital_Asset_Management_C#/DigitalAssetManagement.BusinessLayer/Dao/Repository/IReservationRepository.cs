using System;
using DigitalAssetManagement.Entity;
namespace DigitalAssetManagement.BusinessLayer.Dao.Repository;

public interface IReservationRepository
{
     // Method to reserve an asset
    bool ReserveAsset(int assetId, int employeeId, DateTime reservationDate, DateTime startDate, DateTime endDate);

    // Method to withdraw a reservation
    bool WithdrawReservation(int reservationId);
}
