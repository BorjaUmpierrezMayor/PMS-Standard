using System;
using System.Collections.Generic;

#nullable disable

namespace BookingWizard.Models
{
    public partial class Booking
    {
        public int Reference { get; set; }
        public string ArrivalDate { get; set; }
        public string DepartureDate { get; set; }
        public string RoomType { get; set; }
        public string PensionType { get; set; }
    }
}
