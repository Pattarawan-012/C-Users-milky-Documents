using System;
using System.Collections.Generic;
namespace HomeworkNO._1
{
    class Program
    {
        static void Main(string[] args)
        {
            User jame = new User();
            jame.name = "Jame Watson";
            jame.email = "jame@gmail.com";
            Console.WriteLine(jame.name);
            Console.WriteLine(jame.email);
            
            Tshirt sizeS = new Tshirt();
            sizeS.size = "S";
            sizeS.color = "Black";
            sizeS.prices = 625;

            Tshirt sizeM = new Tshirt();
            sizeM.size = "M";
            sizeM.color = "Black";
            sizeM.prices = 750;

            Tshirt sizeL = new Tshirt();
            sizeL.size = "L";
            sizeL.color = "Red";
            sizeL.prices = 500;

            ShoppingCart Totalcost = new ShoppingCart(sizeS.prices, sizeM.prices, sizeL.prices);

        }
    }
    class Tshirt
    {
        public string size;
        public string color;
        public string image;
        public float prices;
      
    }

    class User
    {
        public string name;
        public string email;
        public string zipCode;
      
    }

    class Address
    {
        public string street;
        public string city;
        public string zipCode;       
    }
    class ShoppingCart
    {
        public float[] orderTshirt = new float[3];

        public ShoppingCart(float priceTshirtone, float priceTshirttwo, float priceTshirtthree)
        {
            orderTshirt[0] = priceTshirtone;
            orderTshirt[1] = priceTshirttwo;
            orderTshirt[2] = priceTshirtthree;
            Console.WriteLine("priceTshirtone bath : " + orderTshirt[0]);
            Console.WriteLine("priceTshirttwo bath: " + orderTshirt[1]);
            Console.WriteLine("priceTshirtthree bath:  " + orderTshirt[2]);
            Console.WriteLine("Totalcost" + (orderTshirt[0] + orderTshirt[1] + orderTshirt[2]));

            Address jameaddress = new Address();
            jameaddress.street = "address 131/75, Phutthamonthon street";
            jameaddress.city = "Nakornpathom";
            jameaddress.zipCode = "Zipcode 10180";

            Console.WriteLine(jameaddress.street);
            Console.WriteLine(jameaddress.city);
            Console.WriteLine(jameaddress.zipCode);

            Console.ReadLine();
        }
       
    }
    
}
