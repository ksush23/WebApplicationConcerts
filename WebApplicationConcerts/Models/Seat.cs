﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationConcerts.Models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int Seat_Line_number { get; set; }
        public int Seat_Number { get; set; }
        public int SectorId { get; set; }

        public ICollection<Ticket> Ticket { get; set; }
        public Sector Sector { get; set; }
    }
}
