using System;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class AddReferenceRequest
    {
        public Guid BookingId{ get; set; }
        
        public string Description{ get; set; }

        public string Reference{ get; set; }
    }
}