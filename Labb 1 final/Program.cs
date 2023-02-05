using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_1
{
    public class Invoice
    {
        public string booking;
        public string actualReturnTime;
        public int totalCost;
        public int employeeNo;


        public int BookingNo { get; set; }
        public DateTime ActualReturnTime { get; set; }
        public decimal TotalPrice { get; set; }
        public int EmployeeNo { get; set; }

        public Invoice(int bookingNo, DateTime actualReturnTime, decimal totalPrice, int employeeNo)
        {
            BookingNo = bookingNo;
            ActualReturnTime = actualReturnTime;
            TotalPrice = totalPrice;
            EmployeeNo = employeeNo;

        }
    }
}


