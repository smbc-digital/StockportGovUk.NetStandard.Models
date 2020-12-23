using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class LocationRequest
    {
        [Required]
        public Guid AppointmentId { get; set; }

        public List<BookingResource> OptionalResources { get; set; }
    }
}
