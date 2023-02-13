using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem
{
    public class Book
    {
     public int IsbnNo { get; private set;}

     public string Title { get; private set;}

     public bool IsAvailable { get; set;}

     public float DelayCost { get; private set;}

     public Book(int isbnNo, bool isAvailable, string title, float delayCost)
     
     {


            IsbnNo = isbnNo;
            Title = title;
            IsAvailable = isAvailable;
            DelayCost = delayCost;

       }

    }
 }