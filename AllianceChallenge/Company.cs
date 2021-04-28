using System;
using System.IO;
using System.Reflection;

namespace AllianceChallenge
{
    public class Company : DataService
    {
        private static readonly string buildDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly string _dataFilePath = buildDir + @"/Data/Company.csv";
        
        public string Id;
        public readonly string Name;
        public readonly Address Address;

        public Company(string name, Address address) : base(_dataFilePath)
        {
            Name = name;
            Address = address;
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
}