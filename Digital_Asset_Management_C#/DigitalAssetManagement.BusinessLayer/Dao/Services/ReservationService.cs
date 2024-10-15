using System;
using DigitalAssetManagement.Entity;
using DigitalAssetManagement.BusinessLayer.Dao.Repository;

namespace DigitalAssetManagement.BusinessLayer.Dao.Services;

public class ReservationService : IReservationService
{
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public bool ReserveAsset(int assetId, int employeeId, DateTime reservationDate, DateTime startDate, DateTime endDate)
        {
            return _reservationRepository.ReserveAsset(assetId, employeeId, reservationDate, startDate, endDate);
        }

        public bool WithdrawReservation(int reservationId)
        {
            return _reservationRepository.WithdrawReservation(reservationId);
        }
}
