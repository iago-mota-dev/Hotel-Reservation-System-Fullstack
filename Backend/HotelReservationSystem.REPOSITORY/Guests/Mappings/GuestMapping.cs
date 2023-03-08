using FluentNHibernate.Mapping;
using HotelReservationSystem.DOMAIN.Guests.Entities;
using HotelReservationSystem.DOMAIN.Guests.Enums;
using NHibernate.Type;

namespace HotelReservationSystem.REPOSITORY.Guests.Mappings
{
    public class GuestMapping : ClassMap<Guest>
    {
        public GuestMapping()
        {
            Schema("hotel_reservation_system");
            Table("Guest");
            Id(x => x.Id).Column("id").GeneratedBy.Increment();
            Map(x => x.Name).Column("name");
            Map(x => x.Address).Column("address");
            Map(x => x.Email).Column("email");
            Map(x => x.ImageUrl).Column("image_url");
            Map(x => x.GuestStatus).Column("gueststatus").CustomType<EnumType<GuestStatusEnum>>();
            HasMany(x => x.Phones).KeyColumn("guest_id");
        }
    }
}