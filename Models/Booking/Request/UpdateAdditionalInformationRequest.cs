using System;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class UpdateAdditionalInformationRequest
    {
        public Guid BookingId { get; set; }
        public string AdditionalInformation { get; set; }
    }
}
