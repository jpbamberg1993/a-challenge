using System;
using System.IO;

namespace AllianceChallenge
{
    public abstract class DataService
    {
        public string Id;
        
        protected DataService(string dataFilePath)
        {
            DataFilePath = dataFilePath;
        }

        private readonly string DataFilePath;

        public abstract void Save();

        protected bool SaveToFile(string dataRow)
        {
            Id = Guid.NewGuid().ToString();
            dataRow = Environment.NewLine + Id + ',' + dataRow;
            using (var sw = File.AppendText(DataFilePath))
                sw.Write(dataRow);
            
            return true;
        }
    }
}