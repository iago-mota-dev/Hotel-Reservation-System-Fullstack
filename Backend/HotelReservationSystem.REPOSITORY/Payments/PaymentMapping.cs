using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using HotelReservationSystem.DOMAIN.Payments.Entities;
using HotelReservationSystem.DOMAIN.Payments.Enums;
using NHibernate.Type;

namespace HotelReservationSystem.REPOSITORY.Payments
{
    public class PaymentMapping : ClassMap<Payment>
    {
        public PaymentMapping()
        {
            Schema("hotel_reservation_system");
            Table("Payment");
            Id(x => x.Id).Column("id").GeneratedBy.Increment();
            References(x => x.Reservation).Column("reservation_id");
            Map(x => x.Amount).Column("amount");
            Map(x => x.PaymentDate).Column("payment_date");
            Map(x => x.PaymentStatus).Column("paymentstatus").CustomType<EnumType<PaymentStatusEnum>>();
        }
    }
}