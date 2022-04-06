using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_UrunYonetimi
{
    public abstract class Urun:ICRUD,IKampanya,IMailGonder
    {
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }

        public string ekleme()
        {
            return UrunAdi;
        }

        public string guncelleme()
        {
            return UrunAdi;
        }

        public string listeleme()
        {
            return "urun Listelendi";
        }

        public string mailgonder()
        {
            return "Mail Gönder";
        }

        public string olustur()
        {
            return "Kampanya oluştur";
        }

        public string silme()
        {
            return UrunAdi;
        }
    }
}
