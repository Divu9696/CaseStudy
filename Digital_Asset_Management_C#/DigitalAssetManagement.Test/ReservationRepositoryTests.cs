using System;
using NUnit.Framework;
using DigitalAssetManagement.Entity;
using DigitalAssetManagement.BusinessLayer;
using DigitalAssetManagement.BusinessLayer.Dao.Repository;
using DigitalAssetManagement.Exception;

namespace DigitalAssetManagement.Test;

public class ReservationRepositoryTests
{
    private ReservationRepository _reservationRepository;

    // Setup method to initialize the test environment
        [SetUp]
        public void Setup()
        {
            // Initialize the ReservationRepository
            _reservationRepository = new ReservationRepository();
        }

        // Test to verify that ReserveAsset throws ReservationException when reservation fails
        [Test]
        public void ReserveAsset_ShouldThrowReservationException_WhenReservationFails()
        {
            // Arrange: Create a new reservation with an invalid AssetId to simulate failure
            var reservation = new Reservation
            {
                AssetId = 999, // Invalid AssetId
                EmployeeId = 1,
                ReservationDate = DateTime.Now,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(2),
                Status = "Reserved"
            };

            // Act & Assert: Verify that reserving the asset throws a ReservationException
            Assert.Throws<ReservationException>(() => _reservationRepository.ReserveAsset(reservation.AssetId,reservation.EmployeeId,reservation.ReservationDate,reservation.StartDate,reservation.EndDate));
        }

        // Test to verify that WithdrawReservation throws ReservationException when reservation is not found
        [Test]
        public void WithdrawReservation_ShouldThrowReservationException_WhenReservationNotFound()
        {
            // Act & Assert: Verify that withdrawing a non-existent reservation throws a ReservationException
            Assert.Throws<ReservationException>(() => _reservationRepository.WithdrawReservation(999)); // Invalid ReservationId
        }

        // Test to verify that ReserveAsset successfully reserves an asset
        [Test]
        public void ReserveAsset_ShouldReserveAsset()
        {
            // Arrange: Create a new reservation with valid data
            var reservation = new Reservation
            {
                AssetId = 1,
                EmployeeId = 1,
                ReservationDate = DateTime.Now,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(2),
                Status = "Reserved"
            };

            // Act: Reserve the asset
            var result = _reservationRepository.ReserveAsset(reservation.AssetId,reservation.EmployeeId,reservation.ReservationDate,reservation.StartDate,reservation.EndDate);

            // Assert: Verify that the asset was successfully reserved
            Assert.IsTrue(result);
        }

        // Test to verify that WithdrawReservation successfully withdraws a reservation
        [Test]
        public void WithdrawReservation_ShouldWithdrawReservation()
        {
            // Arrange: Create and reserve a new reservation with valid data
            var reservation = new Reservation
            {
                AssetId = 1,
                EmployeeId = 1,
                ReservationDate = DateTime.Now,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(2),
                Status = "Reserved"
            };

            // Act: Reserve the asset
            _reservationRepository.ReserveAsset(reservation.AssetId,reservation.EmployeeId,reservation.ReservationDate,reservation.StartDate,reservation.EndDate);
            // Withdraw the reservation
            var result = _reservationRepository.WithdrawReservation(reservation.ReservationId);

            // Assert: Verify that the reservation was successfully withdrawn
            Assert.IsTrue(result);
        }
}
