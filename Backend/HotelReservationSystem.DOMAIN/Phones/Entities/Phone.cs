using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservationSystem.DOMAIN.Guests.Entities;

namespace HotelReservationSystem.DOMAIN.Phones.Entities
{
    public class Phone
    {
        public virtual int Id { get; protected set; }
        public virtual string Number { get; protected set; }
        public virtual Guest Guest { get; protected set; }

        public Phone(string number, Guest guest)
        {
            SetNumber(number);
            SetGuest(guest);
        }
        public virtual void SetNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
                throw new ArgumentException("Number cannot be null");

            if (number.Length > 20)
                throw new ArgumentException("Number cannot be greater than 20 chars");

            this.Number = number;
        }
        public virtual void SetGuest(Guest guest)
        {
            if (guest is null)
                throw new ArgumentException("Guest cannot be null");

            this.Guest = guest;
        }
    }
}