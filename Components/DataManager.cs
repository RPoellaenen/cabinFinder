using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace vuets
{
    public class DataManager
    {
        const string dbFolder = @"C:\Database\";

        public void Save(Cabin cabin)
        {
            var jsonCabin = JsonConvert.SerializeObject(cabin);
            File.WriteAllText(dbFolder + cabin.ID, jsonCabin);
        }

        public List<Cabin> Load()
        {
            var cabins = new List<Cabin>();
            var listOfFiles = Directory.EnumerateFiles(dbFolder);
            foreach (var file in listOfFiles)
            {
                var text = File.ReadAllText(file);
                var cabin = JsonConvert.DeserializeObject<Cabin>(text);
                cabins.Add(cabin);
            }

            return cabins;
        }
    }
}