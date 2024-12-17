using System;
 
namespace Learning
{
    public class Address
    {
       public string City { get; set; }
         public string State { get; set; }
        public Address(string city, string state)
        {
            this.City = city;
            this.State = state;
        }
    }

    public class person
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public person(string name,string city,string state)
        {
            this.Name = name;
            Address address = new Address(city,state);
            
        }

        public void display()
        {
            Console.WriteLine("name:  "+ Name + " city" + Address.City + "state "+ Address.State);
        }
    }
}