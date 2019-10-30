using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

    

        public static List<TimePerson> GetPersons(int yearFrom, int yearTo)
        {
            string path = "./wwwroot/personOfTheYear.csv";
            string[] myFile = File.ReadAllLines(path);
            List<TimePerson> ListofPeople = new List<TimePerson>();

            for (int i = 1; i < myFile.Length; i++)
            {
                string [] test = myFile[i].Split(",");
                ListofPeople.Add(new TimePerson()
                {
                    Year = (test[0] == "") ? 0 : Convert.ToInt32(test[0]),
                    Honor = (test[1]),
                    Name = (test[2]),
                    Country = (test[3]),
                    BirthYear = (test[4] == "") ? 0 : Convert.ToInt32(test[4]),
                    DeathYear = (test[5] == "") ? 0 : Convert.ToInt32(test[5]),
                    Title = (test[6]),
                    Category = (test[7]),
                    Context = (test[8])
                });
            }
            List<TimePerson> testpeople = ListofPeople.Where(p => p.Year >= yearFrom && p.Year <= yearTo).ToList();
            return testpeople;



        }

    }
}
