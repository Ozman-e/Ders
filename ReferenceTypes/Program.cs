using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int,decimal,float,enum,boolean, value types (değer tiplerdir)
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2; //sayı1'i sayi2'nin değerine eşitliyosun. sayı2 ile bi alakası kalmıyor sadece değeriyle bağlantılı. o yüzden sayı2'
            ////yi sonradan değiştirmen sayı1'i değiştirmez. bu değer tipler için böyledir.

            //sayi2 = 100;
            //console.writeline("sayı1" + sayi1);

            ////arraylar[ [] ),class,interface reference types (referans tiplerdir. adres tutuyor. yukarıdaki gibi işlemez)

            //int[] sayilar1 = new int[] { 1, 2, 3, };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2; //sayılar1'in adresi = sayılar2'nin adresi
            //sayilar2[0] = 1000;

            //console.writeline("sayılar 1[0] = " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName); //referans tip olduğu için adresi değiştirdik anlamına geliyor.


            Employee employee = new Employee();
            employee.FirstName = "Ahmet";

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "232432532";

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personmanager = new PersonManager();
            personmanager.Add(customer); //hepsini yollayabiliyorsun (customer person employee)



           
        }
    }

    //base class : Person

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person) //person base class olduğu için person yaparsan öteki classları da yollayabilirsin. ama Employee veya Customerı yapsaydın hepsini yollayamazsın.
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
