using System;

namespace ClassMetoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.Name = "Ali";
            m1.Surname = "Can";
            m1.Id = 1;
            Musteri m2 = new Musteri();
            m2.Name = "Veli";
            m2.Surname = "Can";
            m2.Id = 2;

            Musteri[] CustomerArray = new Musteri[] { m1,m2 };
            MusteriManager custManager = new MusteriManager();
            custManager.AddMusteri(m1);
            custManager.DeleteMusteri(m1);
            custManager.ListMusteri(CustomerArray);
        }
    }
}
