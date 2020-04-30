using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Polaczenie
    {
        public int Id { get; set; }
        public string Stacja { get; set; }
        public DateTime Godzina { get; set; }
        public int Ilosc_miejsc {get; set;}
    }
}
