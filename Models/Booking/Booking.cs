﻿using System;

namespace StockportGovUK.NetStandard.Models.Booking
{
    public class Booking
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
