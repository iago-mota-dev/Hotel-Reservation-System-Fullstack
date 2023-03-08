using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using HotelReservationSystem.DOMAIN.Rooms.Entities;
using HotelReservationSystem.DOMAIN.Rooms.Enums;
using NHibernate.Type;

namespace HotelReservationSystem.REPOSITORY.Rooms.Mappings
{
    public class RoomMapping : ClassMap<Room>
    {
        public RoomMapping()
        {
            Schema("hotel_reservation_system");
            Table("Room");
            Id(x => x.Id).Column("id").GeneratedBy.Increment();
            References(x => x.Hotel).Column("hotel_id");
            Map(x => x.Type).Column("room_type");
            Map(x => x.Number).Column("room_number");
            Map(x => x.ImageUrl).Column("image_url");
            Map(x => x.RoomStatus).Column("roomstatus").CustomType<EnumType<RoomStatusEnum>>();;
            Map(x => x.Price).Column("price");
            HasManyToMany(x => x.Reservations).Table("ReservationRoom");
        }
    }
}