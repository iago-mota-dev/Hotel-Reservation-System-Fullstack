using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservationSystem.DOMAIN.Guests.Entities;
using HotelReservationSystem.DOMAIN.Reservations.Enums;

namespace HotelReservationSystem.DOMAIN.Reservations.Entities
{
    public class Reservation
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime Date { get; protected set; }
        public virtual Guest Guest { get; protected set; }
        public virtual decimal TotalAmount { get; protected set; }
        public virtual ReservationStatusEnum ReservationStatus { get; protected set; }
        protected Reservation(){}
        public Reservation(DateTime date, Guest guest, decimal totalAmount, ReservationStatusEnum status)
        {
            SetDate(date);
            SetGuest(guest);
            SetTotalAmount(totalAmount);
            SetReservationStatusEnum(status);
        }
        public virtual void SetDate(DateTime date)
        {
            if (date.Date < DateTime.Now.Date)
                throw new ArgumentException("Reservation Date cannot be in the past");

            this.Date = date;
        }
        public virtual void SetGuest(Guest guest)
        {
            if (guest is null)
                throw new ArgumentException("Guest cannot be null");

            this.Guest = guest;
        }
        public virtual void SetTotalAmount(decimal totalamount)
        {
            if (totalamount > 999999.99m)
                throw new ArgumentException("Total amount cannot be greater than 999999.99");

            this.TotalAmount = totalamount;
        }
        public virtual void SetReservationStatusEnum(ReservationStatusEnum status)
        {
            this.ReservationStatus = status;
        }

    }
}