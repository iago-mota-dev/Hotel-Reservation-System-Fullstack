using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservationSystem.DOMAIN.Payments.Enums;
using HotelReservationSystem.DOMAIN.Reservations.Entities;

namespace HotelReservationSystem.DOMAIN.Payments.Entities
{
    public class Payment
    {

        public virtual int Id { get; protected set; }
        public virtual Reservation Reservation { get; protected set; }
        public virtual DateTime PaymentDate { get; protected set; }
        public virtual decimal Amount { get; protected set; }
        public virtual PaymentStatusEnum PaymentStatus { get; protected set; }
        protected Payment() { }
        public Payment(Reservation reservation, decimal amount, PaymentStatusEnum paymentStatus)
        {
            SetReservation(reservation);
            SetPaymentDate();
            SetAmount(amount);
            SetPaymentStatus(paymentStatus);
        }
        public virtual void SetPaymentStatus(PaymentStatusEnum paymentStatus)
        {
            this.PaymentStatus = paymentStatus;
        }
        public virtual void SetAmount(decimal amount)
        {
            if (amount > 999999.99m)
                throw new ArgumentException("Amount cannot be greater than 999999.99");

            if (amount < 50m)
                throw new ArgumentException("Amount cannot be lower than 50");

            this.Amount = amount;
        }
        public virtual void SetPaymentDate()
        {
            this.PaymentDate = DateTime.Now;
        }
        public virtual void SetReservation(Reservation reservation)
        {
            if (reservation is null)
                throw new ArgumentException("Reservation  cannot be null");

            this.Reservation = reservation;
        }
    }
}