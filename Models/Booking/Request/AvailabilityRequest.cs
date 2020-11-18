using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class AvailabilityRequest
    {
        [Required]
        public Guid AppointmentId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public List<BookingResource> OptionalResources { get; set; }
    }
}
