using System;
using System.Collections.Generic;
using System.Linq;

namespace StockportGovUK.NetStandard.Models.Models.Booking.Response
{
    public class AvailabilityDayResponse
    {
        public DateTime Date { get; set; }
        public List<AppointmentTime> AppointmentTimes { get; set; }
        public bool HasAvailableAppointment => AppointmentTimes.Any();
    }

    public class AppointmentTime
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
