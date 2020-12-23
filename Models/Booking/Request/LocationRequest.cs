using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StockportGovUK.NetStandard.Models.Booking.Request;

namespace StockportGovUK.NetStandard.Models.Models.Booking.Request
{
    public class LocationRequest
    {
        [Required]
        public Guid AppointmentId { get; set; }

        public List<BookingResource> OptionalResources { get; set; }
    }
}
