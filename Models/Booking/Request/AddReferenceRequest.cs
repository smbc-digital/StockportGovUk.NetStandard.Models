using System;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class AddReferenceReqest
    {
        public Guid BookingId{ get; set; }
        
        public string Description{ get; set; }

        public string Referencee{ get; set; }
    }
}