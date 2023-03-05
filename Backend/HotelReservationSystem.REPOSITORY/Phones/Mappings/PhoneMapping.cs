using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using HotelReservationSystem.DOMAIN.Phones.Entities;

namespace HotelReservationSystem.REPOSITORY.Phones.Mappings
{
    public class PhoneMapping : ClassMap<Phone>
    {
        public PhoneMapping()
        {
            Schema("hotel_reservation_system");
            Table("Phones");
            Id(x => x.Id).Column("id").GeneratedBy.Increment();
            Map(x => x.Number).Column("phone_number");
            References(x => x.Guest).Column("guest_id");
        }
    }
}