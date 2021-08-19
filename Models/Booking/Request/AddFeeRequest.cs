using System;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class AddFeeRequest
    {
        public Guid BookingId { get; set; }
        
        public decimal FeePaid { get; set; } 
    }
}