using System.Collections.Generic;
using OnionShop.DataLayer.Entities.Contacts;

namespace OnionShop.DataLayer.DTOs.Contacts
{
    public class TicketDetailDTO
    {
        public Ticket Ticket { get; set; }

        public List<TicketMessage> TicketMessages { get; set; }
    }
}
