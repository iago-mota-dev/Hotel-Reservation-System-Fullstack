using FluentNHibernate.Mapping;
using HotelReservationSystem.DOMAIN.Reservations.Entities;
using HotelReservationSystem.DOMAIN.Reservations.Enums;
using NHibernate.Type;

namespace HotelReservationSystem.REPOSITORY.Reservations.Mappings
{
    public class ReservationMapping : ClassMap<Reservation>
    {
        public ReservationMapping()
        {
            Schema("hotel_reservation_system");
            Table("Reservation");
            Id(x => x.Id).Column("id").GeneratedBy.Increment();
            References(x => x.Guest).Column("guest_id");
            Map(x => x.Date).Column("reservation_date");
            Map(x => x.TotalAmount).Column("total_amount");
            Map(x => x.ReservationStatus).Column("reservationstatus").CustomType<EnumType<ReservationStatusEnum>>();
        }
    }
}