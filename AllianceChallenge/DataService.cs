using System;
using System.Text;

namespace AllianceChallenge
{
    public abstract class DataService
    {
        protected DataService()
        {
        }

        protected DataService(string dataFilePath)
        {
            DataFilePath = dataFilePath;
        }

        private string DataFilePath;

        public abstract void Save();

        protected void SaveToFile(string dataRow)
        {
            
        }
    }
}