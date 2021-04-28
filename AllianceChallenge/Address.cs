using System;

namespace AllianceChallenge
{
    public class Address : DataService
    {
        public Guid Id { get; set; }
        private string _street;
        private string _city;
        private string _state;
        private string _zip;

        public Address(string street, string city, string state, string zip) : base("./Data/Address")
        {
            _street = street;
            _city = city;
            _state = state;
            _zip = zip;
            Id = Guid.NewGuid();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
}