﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Pracownik
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int PESEL { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Stanowisko { get; set; }
    }
}
