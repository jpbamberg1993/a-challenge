using System;

namespace AllianceChallenge
{
    public class Customer : DataService
    {
        private const string _dataFilePath = "./Data/Customer.csv";

        public Guid Id;
        public readonly string FirstName;
        public readonly string LastName;
        public readonly Address Address;

        public Customer(string firstName, string lastName, Address address) : base(_dataFilePath)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public override void Save()
        {
            
            Id = SaveToFile();
        }
    }
}