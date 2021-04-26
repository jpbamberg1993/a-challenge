using System;

namespace AllianceChallenge
{
    public class Company : DataService
    {
        public Guid Id { get; set; }
        public readonly string Name;
        public readonly Address Address;

        public Company(string name, Address address)
        {
            Name = name;
            Address = address;
        }
    }
}