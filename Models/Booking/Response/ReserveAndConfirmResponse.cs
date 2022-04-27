using System;
using System.Collections.Generic;

namespace StockportGovUK.NetStandard.Models.Booking.Response
{
    public class ReserveAndConfirmResponse
    {
        public Guid id { get; set; }

        public DateTime BookingDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }
    }
}