﻿using System;
using Exercicio_resolvido.Entities.Exceptions;

namespace Exercicio_resolvido.Entities {
    class Reservation {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut) {
            if (checkOut <= checkIn) {
                throw new DomainException("Reservation: Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut) {
            CheckDateNow(checkIn, checkOut);
            CheckIfCheckIsValid(checkIn, checkOut);
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString() {
            return $"Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }

        private void CheckDateNow(DateTime checkIn, DateTime checkOut) {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now) {
                throw new DomainException("Reservation dates for update must be future dates");
            }
        }

        private void CheckIfCheckIsValid(DateTime checkIn, DateTime checkOut) {
            if (checkOut <= checkIn) {
                throw new DomainException("Reservation: Check-out date must be after check-in date");
            }
        }
    }
}
