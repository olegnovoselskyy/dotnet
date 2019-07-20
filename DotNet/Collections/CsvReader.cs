using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Collections
{
    class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public Country[] ReadFirstNCountries(int nCountries)
        {
            Country[] countries = new Country[nCountries];
            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                //read header line
                sr.ReadLine();

                for (int i =0; i < nCountries; i++)
                {
                    string csvLine = sr.ReadLine();
                    countries[i] = ReadCountryFromCsvLine(csvLine);
                }
            }
            return countries;
        }

        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();
            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                //read header line
               sr.ReadLine();
               string csvLine;
               while ((csvLine = sr.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(csvLine));
                }
            }
            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            // How I did it just to try and also for simplicty sake since the instructors code was too much for this simple example, but more proper
            if (parts.Length > 4)
            {
                parts[0] = parts[0] + " " + parts[1];
                parts[1] = parts[2];
                parts[2] = parts[3];
                parts[3] = parts[4];
            }

            #region Instructors Code

            //string instructorsCodeName;
            //string instructorsCodeCode;
            //string instructorsCodeRegion;
            //string instructorsCodePopulation;

            //switch (parts.Length)
            //{
            //    case 4:
            //        instructorsCodeName = parts[0];
            //        instructorsCodeCode = parts[1];
            //        instructorsCodeRegion = parts[2];
            //        instructorsCodePopulation = parts[3];
            //        break;

            //    case 5:
            //        instructorsCodeName = parts[0] + ", " + parts[1];
            //        instructorsCodeName = instructorsCodeName.Replace("\"", null).Trim();
            //        instructorsCodeCode = parts[2];
            //        instructorsCodeRegion = parts[3];
            //        instructorsCodePopulation = parts[4];
            //        break;
            //    default:
            //        throw new Exception($"Can't parse country from csvLine: {csvLine}");
            //}

            #endregion

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            //int population = int.Parse(parts[3]);
            int.TryParse(parts[3], out int population);

            return new Country(name, code, region, population);
        }
    }
}
