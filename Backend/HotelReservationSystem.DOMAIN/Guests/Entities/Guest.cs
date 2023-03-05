using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservationSystem.DOMAIN.Guests.Enums;

namespace HotelReservationSystem.DOMAIN.Guests.Entities
{
    public class Guest
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Address { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string ImageUrl { get; protected set; }
        public virtual GuestStatusEnum GuestStatus { get; protected set; }
        protected Guest(){}
        public Guest(string name, string address, string email, string imageUrl, GuestStatusEnum guestStatus)
        {
            SetName(name);
            SetAddress(address);
            SetEmail(email);
            SetImageUrl(imageUrl);
            SetGuestStatusEnum(guestStatus);
        }

        public virtual void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty");

            if (name.Length > 255)
                throw new ArgumentException("Name cannot be grater than 255 chars");

            this.Name = name;
        }
        public virtual void SetAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Address cannot be null or empty");

            if (address.Length > 255)
                throw new ArgumentException("Address cannot be grater than 255 chars");

            this.Address = address;
        }
        public virtual void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email cannot be null or empty");

            if (email.Length > 255)
                throw new ArgumentException("Email cannot be grater than 255 chars");

            this.Email = email;
        }
        public virtual void SetImageUrl(string imageUrl)
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
                throw new ArgumentException("Image Url cannot be null or empty");

            if (imageUrl.Length > 255)
                throw new ArgumentException("Image Url cannot be grater than 255 chars");

            this.ImageUrl = imageUrl;
        }
   
        public virtual void SetGuestStatusEnum(GuestStatusEnum guestStatus)
        {
            this.GuestStatus = guestStatus;
        }
    }
}