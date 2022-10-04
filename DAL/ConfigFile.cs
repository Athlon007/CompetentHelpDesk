using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DAL
{
    internal class ConfigFile
    {
        private dynamic json;
        const string ConfigFileName = "config.json"; // Config file name that contains the connection string.

        public ConfigFile()
        {
            json = ReadConfig(ConfigFileName);
        }

        /// <summary>
        /// Returns the configuration file read from JSON file.
        /// </summary>
        /// <param name="filename"></param>
        private dynamic ReadConfig(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Config file does not exist.");
            }

            StreamReader reader = new StreamReader(filename);
            string content = reader.ReadToEnd();
            reader.Close();

            return JsonConvert.DeserializeObject<dynamic>(content);
        }

        /// <summary>
        /// Connection string to the cluster.
        /// </summary>
        public string ConnectionString => json.connectionString;

        /// <summary>
        /// Used database name.
        /// </summary>
        public string DatabaseName => json.databaseName;
    }
}
