using ETicketWebClient.ETicketService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ETicketWebClient.Models
{
    public class TicketSeatViewModel
    {
        public int TicketId { get; set; }
        public int EventId { get; set; }
        public int SeatNumber { get; set; }
    }
}
