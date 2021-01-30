using System;

namespace Costructers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(1, "Derin", "demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
        }

    }

    class Customer
    {
        public Customer()
        {

        }

        //defoult cunstructer
        public Customer(int id, string firstName, string lastName, string city)
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
