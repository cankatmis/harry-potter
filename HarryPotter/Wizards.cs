using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    class Wizards
    {
        static Random RNG = new Random();

        string name;
        int courage;
        int intelligence;
        int perseverance;
        int cunning;

        public Wizards(string name, int courage, int intelligence, int perseverance, int cunning)
        {
            this.name = name;
            this.courage = courage;
            this.intelligence = intelligence;
            this.perseverance = perseverance;
            this.cunning = cunning;
        }

        public Wizards()
        {
        }

        public override string ToString()
        {
            return this.name + " -";
        }

        public string Name { get => name; set => name = value; }
        public int Courage { get => courage; set => courage = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Perseverance { get => perseverance; set => perseverance = value; }
        public int Cunning { get => cunning; set => cunning = value; }


        public LinkedListex GenerateRandomWizards(LinkedListex wizardList, int size)
        {
            string[] firstNames = { "Harry", "Sirius", "Hermione", "Ron", "Albus", "Severus", "Daniel",
                "Can", "Liam", "Noah", "Oliver", "William", "Elijah", "James", "Benjamin", "Lucas", "Mason",
                "Ethan", "Olivia", "Emma", "Ava", "Sophia", "Isabella", "Charlotte", "Amelia", "Mia", "Harper", "Evelyn" };
            string[] lastNames = { "Weasley", "Potter", "Dumbledore", "Granger", "Snape", "Black", "Katmis",
                "Kiss","Smith","Johnson","Williams","Brown","Jones","Miller","Davis","Garcia","Rodriguez","Wilson",
                "Martinez","Anderson","Taylor","Thomas","Hernandez","Moore","Martin","Jackson","Thompson","White" };
            for (int i = 0; i < size; i++)
            {
                string fullName = firstNames[RNG.Next(firstNames.Length)] + " " + lastNames[RNG.Next(lastNames.Length)];
                Wizards newPlayer = new Wizards(fullName, RNG.Next(1, 11), RNG.Next(1, 11), RNG.Next(1, 11), RNG.Next(1, 11));
                wizardList.Insert(newPlayer);
            }
            return wizardList;
        }
    }
}
