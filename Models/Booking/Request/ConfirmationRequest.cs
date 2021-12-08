﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockportGovUK.NetStandard.Models.Booking.Request
{
    public class ConfirmationRequest
    {
        public ConfirmationRequest() { }

        public ConfirmationRequest(Guid bookingId)
          => BookingId = bookingId;

        [Required]
        public Guid BookingId { get; set; }

        public List<BookingResource> OptionalResources { get; set; }

        public string AdditionalInformation { get; set; }
    }
}
