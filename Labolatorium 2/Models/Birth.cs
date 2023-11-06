using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Labolatorium_2.Models
{
    public class Birth 
    {

        public string name { get; set; }
        public DateTime date { get; set; }


        public bool IsValid()
        {
            return !string.IsNullOrEmpty(name) && date < DateTime.Now;
        }

        public int Calculate_age()
        {
            int age = DateTime.Now.Year - date.Year;
            if (DateTime.Now.DayOfYear < date.DayOfYear)
            {
                age--;
            }
            return age;

        }

    }
}
