using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bibliotekssystem
{
    class Member
    {
    public int MemberNo { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNo { get; set; }

    public Member(int memberNo, string name, string email, string phoneNo)
    {
        MemberNo = memberNo;
        Name = name;
        Email = email;
        PhoneNo = phoneNo;
     }
  }
}

