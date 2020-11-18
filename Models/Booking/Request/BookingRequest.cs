using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Models.Booking.Request
{
    public class BookingRequest
    {
        [Required]
        public Guid AppointmentId { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }

        [Required]
        public Customer Customer { get; set; }

        public List<BookingResource> OptionalResources { get; set; }

        public string AdditionalInformation { get; set; }
    }

    public class Customer
    {
        [Required]
        public string Name { get; set; }

        public string Location { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }

    public class BookingResource
    {
        [Required]
        public Guid ResourceId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
