using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class ConfirmationRequest
    {
        [Required]
        public Guid BookingId { get; set; }

        public List<BookingResource> OptionalResources { get; set; }
    }
}
