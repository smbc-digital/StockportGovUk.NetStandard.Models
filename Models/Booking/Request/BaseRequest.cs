using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class BaseRequest
    {
        public BaseRequest()
        {
            NumberOfConsecutiveAppointmentsRequired = 1;
        }
        
        [Required]
        public Guid AppointmentId { get; set; }

        public int NumberOfConsecutiveAppointmentsRequired {get; set; }

        public List<BookingResource> OptionalResources { get; set; }

    }
}
