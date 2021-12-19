using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingWizard.Models.Request
{
    public class BookingRequest
    {
        public int Reference { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public string RoomType { get; set; }
        public string PensionType { get; set; }
    }
}
