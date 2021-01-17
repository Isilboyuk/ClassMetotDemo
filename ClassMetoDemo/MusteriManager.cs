using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetoDemo
{
    class MusteriManager
    {
        //Add Customer
        public void AddMusteri(Musteri musteri) {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " kişisi başarılı bir şekilde eklenmiştir.");
        }
        //Delete Customer
        public void DeleteMusteri(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " Id' ye sahip " + musteri.Name + musteri.Surname + " başarılı bir şekilde silinmiştir.");
        }
        //List Customer
        public void ListMusteri(Musteri[] musteri)
        {
            foreach(Musteri cust in musteri)
            {
                Console.WriteLine("Id: " + cust.Id + " Name: " + cust.Name + " Surname: " + cust.Surname);
            }
        }
    }
}
