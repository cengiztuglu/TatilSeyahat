using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Classes
{
    public class Blog
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }

        public string Aciklama { get; set; }
    }
}