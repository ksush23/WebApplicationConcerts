﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationConcerts.Models
{
    public class TicketState
    {
        public int TicketStateId { get; set; }
        public string TicketState_Name { get; set; }

        public ICollection<Ticket> Ticket { get; set; }
    }
}
