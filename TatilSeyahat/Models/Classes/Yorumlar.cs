using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahat.Models.Classes
{
    public class Yorumlar
    {
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public  string Mail { get; set; }
        public string Yorum { get; set; }
        public int BLOGID { get; set; }
    }
}