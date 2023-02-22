using Bibliotekssystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem
{
     public class Booking
     {
        public int MemberNo { get; private set;}

        public string Name { get; private set;}

        public string Book { get; private set;}

        public DateTime BookedHandoverTime { get; private set;}

        public int EmployeeNo { get; private set;}

            public Booking(int memberNo, string name, string book, DateTime bookedHandoverTime, int employeeNo)

            {
               MemberNo = memberNo;
               Name = name;
               Book = book;
               BookedHandoverTime = bookedHandoverTime;
               EmployeeNo = employeeNo;

            }
    }
}
