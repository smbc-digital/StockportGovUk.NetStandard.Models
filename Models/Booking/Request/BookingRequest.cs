using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class BookingRequest : BaseRequest
    {
        public BookingRequest() : base()
        {
        }

        [Required]
        public DateTime StartDateTime { get; set; }

        [Required]
        public Customer Customer { get; set; }

        public string AdditionalInformation { get; set; }
    }

    public class Customer
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }

        public string Address { get; set; }

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
