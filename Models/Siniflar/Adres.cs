﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Adres
    {
        [Key]
        public int ID { get; set; }
        public string Baslık{ get; set; }
        public string Açıklama { get; set; }
        public string AdresAçıklama { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }
    }
}