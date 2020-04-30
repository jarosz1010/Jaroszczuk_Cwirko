using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Transakcja
    {
        public int Id { get; set; }
        public Polaczenie Polaczenie { get; set; }
        public Kupujacy Kupujacy { get; set; }
        public Pracownik Pracownik { get; set;}
    }
}
