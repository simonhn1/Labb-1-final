using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem
{
    public class Invoice
    {
        public int BookingNo { get; set; }
        public string BookTitle { get; set; }
        public DateTime ActualReturnTime { get; set; }
        public decimal TotalPrice { get; set; }
        public int EmployeeNo { get; set; }

        public Invoice(int bookingNo,string bookTitle, DateTime actualReturnTime, decimal totalPrice, int employeeNo)
        {
            BookingNo = bookingNo;
            BookTitle = bookTitle;
            ActualReturnTime = actualReturnTime;
            TotalPrice = totalPrice;
            EmployeeNo = employeeNo;
        }
    }
}

