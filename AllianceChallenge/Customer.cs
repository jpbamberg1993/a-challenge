using System.Data;
using System.IO;
using System.Reflection;

namespace AllianceChallenge
{
    public class Customer : DataService
    {
        private static readonly string buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly string _dataFilePath = buildDir + @"/Data/Customer.csv";

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
            var dataRow = $"{FirstName},{LastName},{Address.Id}";
            var response = SaveToFile(dataRow);
            if (!response)
                throw new DataException("Something went wrong when saving the customer.");
        }
    }
}