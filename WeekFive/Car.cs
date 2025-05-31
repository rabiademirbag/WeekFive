
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFive
{
    public class Car
    {
        public DateTime UretimTarihi  { get; }
        public string SeriNo { get;}
        public string Marka {  get; }
        public string Model { get;  }
        public string Renk { get; set; }
        public int KapiSayisi { get; }

        public Car(string seriNo, string marka, string model, string renk, int kapiSayisi)
        {
            UretimTarihi = DateTime.Now.Date;
            SeriNo = seriNo;
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi = kapiSayisi;
        }
    }
}
