using System;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class BookingResource
    {
        [Required]
        public Guid ResourceId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
