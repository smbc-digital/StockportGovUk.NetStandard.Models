using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class AvailabilityRequest : BaseRequest
    {
        public AvailabilityRequest() : base() { }

        public AvailabilityRequest(DateTime startDate, DateTime endDate, Guid appointmentId)
          : base(appointmentId) => (StartDate, EndDate) = (startDate, endDate);

        public AvailabilityRequest(DateTime startDate, DateTime endDate, Guid appointmentId, List<BookingResource> optionalResources)
          : base(appointmentId, optionalResources) => (StartDate, EndDate) = (startDate, endDate);

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
