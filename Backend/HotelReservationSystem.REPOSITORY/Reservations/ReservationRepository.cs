using FluentNHibernate.Mapping;
using HotelReservationSystem.DOMAIN.Reservations.Entities;

namespace HotelReservationSystem.REPOSITORY.Reservations
{
    public class ReservationRepository : ClassMap<Reservation>
    {
        public ReservationRepository()
        {
        }
    }
}