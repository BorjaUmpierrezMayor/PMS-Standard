using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingWizard.Models.Response
{
    public class BookingResponse<T>
    {
        public int Successfully { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public BookingResponse()
        {
            this.Successfully = 0;
        }
    }
}
