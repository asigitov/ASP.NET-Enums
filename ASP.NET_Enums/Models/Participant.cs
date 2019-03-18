using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Enums.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Participant
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
    }
}
