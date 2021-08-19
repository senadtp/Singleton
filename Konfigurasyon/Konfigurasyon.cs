using System;
using System.Collections.Generic;
using System.Text;

namespace Konfigurasyon
{
    public class Konfigurasyon
    {
        public  int MaksKullaniciSayisi { get; set; }
        public  string LogDosyaAdi { get; set; }
        private Konfigurasyon() {
            this.MaksKullaniciSayisi = 10;
            this.LogDosyaAdi = "D:\\USER.LOG";
        }
        private static Konfigurasyon instance;
        public static Konfigurasyon getInstance()
        {
            if (instance == null)
            {
                instance = new Konfigurasyon();
                Console.WriteLine(instance.LogDosyaAdi);
                Console.WriteLine(instance.MaksKullaniciSayisi);
                Console.WriteLine("Yeni konf yaratildi :)");
            }
            else
            {
                Console.WriteLine("Yeni konf yaratilamadi.:(");
            }
            return instance;
        }
    }
}
