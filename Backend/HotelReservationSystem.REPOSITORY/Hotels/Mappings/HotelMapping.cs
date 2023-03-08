using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using HotelReservationSystem.DOMAIN.Hotels.Entities;
using HotelReservationSystem.DOMAIN.Hotels.Enums;
using NHibernate.Type;

namespace HotelReservationSystem.REPOSITORY.Hotels.Mappings
{
    public class HotelMapping : ClassMap<Hotel>
    {
        public HotelMapping()
        {
            Schema("hotel_reservation_system");
            Table("Hotel");
            Id(x => x.Id).Column("id").GeneratedBy.Increment();
            Map(x => x.Name).Column("name");
            Map(x => x.Address).Column("address");
            Map(x => x.Email).Column("email");
            Map(x => x.PhoneNumber).Column("phone_number");
            Map(x => x.ImageUrl).Column("image_url");
            Map(x => x.Rating).Column("rating");
            Map(x => x.HotelStatus).Column("hotelstatus").CustomType<EnumType<HotelStatusEnum>>();
            HasMany(x => x.Rooms).KeyColumn("hotel_id").Cascade.None();
        }
    }
}