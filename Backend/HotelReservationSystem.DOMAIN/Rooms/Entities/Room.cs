using HotelReservationSystem.DOMAIN.Hotels.Entities;
using HotelReservationSystem.DOMAIN.Rooms.Enums;

namespace HotelReservationSystem.DOMAIN.Rooms.Entities
{
    public class Room
    {
        public virtual int Id { get; protected set; }
        public virtual Hotel Hotel { get; protected set; }
        public virtual string Type { get; protected set; }
        public virtual int Number { get; protected set; }
        public virtual decimal Price { get; protected set; }
        public virtual string ImageUrl { get; protected set; }
        public virtual RoomStatusEnum RoomStatus { get; protected set; }
        protected Room(){}
        public Room(Hotel hotel, string type, int number, decimal price, string imageUrl, RoomStatusEnum roomStatus)
        {
            SetHotel(hotel);
            SetType(type);
            SetNumber(number);
            SetPrice(price);
            SetImageUrl(imageUrl);
            SetRoomStatus(roomStatus);
        }
        public virtual void SetRoomStatus(RoomStatusEnum roomStatus)
        {
            this.RoomStatus = roomStatus;
        }
        public virtual void SetNumber(int number)
        {
            if (number < 1)
                throw new ArgumentException("Number cannot be lower than 1");

            this.Number = number;
        }
        public virtual void SetPrice(decimal price)
        {
            if (price > 999999.99m)
                throw new ArgumentException("Price cannot be greater than 999999.99");

            if (price < 50)
                throw new ArgumentException("Price cannot be lower than 50");

            this.Price = price;
        }
        public virtual void SetHotel(Hotel hotel)
        {
            if (hotel is null)
                throw new ArgumentException("Hotel cannot be null");

            this.Hotel = hotel;
        }
        public virtual void SetType(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentException("Room type cannot be null");

            if (type.Length > 50)
                throw new ArgumentException("Room type cannot be greater than 50 chars");
        }
        public virtual void SetImageUrl(string imageUrl)
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
                throw new ArgumentException("Image Url cannot be null or empty");

            if (imageUrl.Length > 255)
                throw new ArgumentException("Image Url cannot be grater than 255 chars");

            this.ImageUrl = imageUrl;
        }

    }
}