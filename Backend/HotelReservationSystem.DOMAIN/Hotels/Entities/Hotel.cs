using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelReservationSystem.DOMAIN.Hotels.Enums;
using HotelReservationSystem.DOMAIN.Rooms.Entities;

namespace HotelReservationSystem.DOMAIN.Hotels.Entities
{
    public class Hotel
    {

        public virtual int Id { get; protected set; }
        public virtual string Name { get; protected set; }
        public virtual string Address { get; protected set; }
        public virtual string PhoneNumber { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string ImageUrl { get; protected set; }
        public virtual decimal Rating { get; protected set; }
        public virtual HotelStatusEnum HotelStatus { get; protected set; }
        public virtual IList<Room> Rooms { get; protected set; }
        protected Hotel() { }
        public Hotel(string name, string address, string phoneNumber, string email, string imageUrl, decimal rating, HotelStatusEnum hotelStatus)
        {
            SetName(name);
            SetAddress(address);
            SetPhoneNumber(phoneNumber);
            SetEmail(email);
            SetImageUrl(imageUrl);
            SetRating(rating);
            SetHotelStatus(hotelStatus);
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
        public virtual void SetPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone Number cannot be null or empty");

            if (phoneNumber.Length > 20)
                throw new ArgumentException("Phone Number cannot be grater than 20 chars");

            this.PhoneNumber = phoneNumber;
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
        public virtual void SetRating(decimal rating)
        {
            if (rating > 9.99m)
                throw new ArgumentException("Rating cannot be grater than 9.99");

            if (rating < 0)
                throw new ArgumentException("Rating cannot be lower than 0");

            this.Rating = rating;
        }
        public virtual void SetHotelStatus(HotelStatusEnum hotelStatus)
        {
            this.HotelStatus = hotelStatus;
        }
    }
}