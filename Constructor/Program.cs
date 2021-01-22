using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
             


           
        }

        
    }

    class Customer
    {
        public Customer()  //böyle boş bir şekilde ctor verirsen default'u korumuş olursun ve 1.yöntem de çalışmış olur.
        {

        }


        //default constructor
        public Customer(int id, string firstName, string lastName, string city)   // bu yeni bir constructordır. customer2'de yazdığın gibi yazmak istiyorsan parantez içine tanımları belirtmen lazım.
            //default constructor'ın üstüne yazdığın için default bozulur. //metot parametreleri camelcase yazılır.
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

            
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
