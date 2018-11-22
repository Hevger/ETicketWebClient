using ETicketWebClient.ETicketService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicketWebClient.Models
{
    public class TicketSeatViewModel
    {
        public Ticket Ticket { get; set; }
        public Seat Seat { get; set; }
    }
}
