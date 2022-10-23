using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    class SortingHat
    {
        Houses gryffindor;
        Houses ravenclaw;
        Houses hufflepuff;
        Houses slytherin;
        LinkedListex wizardList = new LinkedListex();

        public SortingHat(LinkedListex wizardList, Houses gryffindor, Houses ravenclaw, Houses hufflepuff, Houses slytherin)
        {
            this.wizardList = wizardList;
            this.gryffindor = gryffindor;
            this.ravenclaw = ravenclaw;
            this.hufflepuff = hufflepuff;
            this.slytherin = slytherin;
        }

        public void AssignWizards()
        {
            foreach (Wizards item in wizardList)
            {
                if (item.Courage >= item.Intelligence && item.Courage >= item.Perseverance && item.Courage >= item.Cunning)
                {
                    gryffindor.Insert(item, item.Courage);
                }
                else if (item.Intelligence >= item.Courage && item.Intelligence >= item.Perseverance && item.Intelligence >= item.Cunning)
                {
                    ravenclaw.Insert(item, item.Intelligence);
                }
                else if (item.Perseverance >= item.Courage && item.Perseverance >= item.Intelligence && item.Perseverance >= item.Cunning)
                {
                    hufflepuff.Insert(item, item.Perseverance);
                }
                else if (item.Cunning >= item.Courage && item.Cunning >= item.Intelligence && item.Cunning >= item.Perseverance)
                {
                    slytherin.Insert(item, item.Cunning);
                }
                else
                {
                    throw new InsertionException();
                }
            }
        }
        public void InputManager(string input, Houses gryffindor, Houses ravenclaw, Houses hufflepuff, Houses slytherin)
        {
            string qualityName = input.Split(' ')[0];
            if (IntegerTest(input.Split(' ')[1]) == false)
            {
                throw new InputNumberException();
            }
            int qualityNum = int.Parse(input.Split(' ')[1]);

            if ((qualityName == "Courage") || (qualityName == "courage"))
            {
                if (gryffindor.TraversalCheck(CountCourage, qualityNum) > 0)
                {
                    Console.Write("Gryffindor: ");
                    gryffindor.Traversal(TestCourage, qualityNum);
                    Console.WriteLine();
                }
                if (ravenclaw.TraversalCheck(CountCourage, qualityNum) > 0)
                {
                    Console.Write("Ravenclaw: ");
                    ravenclaw.Traversal(TestCourage, qualityNum);
                    Console.WriteLine();
                }
                if (hufflepuff.TraversalCheck(CountCourage, qualityNum) > 0)
                {
                    Console.Write("Hufflepuff: ");
                    hufflepuff.Traversal(TestCourage, qualityNum);
                    Console.WriteLine();
                }
                if (slytherin.TraversalCheck(CountCourage, qualityNum) > 0)
                {
                    Console.Write("Slytherin: ");
                    slytherin.Traversal(TestCourage, qualityNum);
                    Console.WriteLine();
                }
            }
            else if ((qualityName == "Intelligence") || (qualityName == "intelligence"))
            {
                if (gryffindor.TraversalCheck(CountIntelligence, qualityNum) > 0)
                {
                    Console.Write("Gryffindor: ");
                    gryffindor.Traversal(TestIntelligence, qualityNum);
                    Console.WriteLine();
                }
                if (ravenclaw.TraversalCheck(CountIntelligence, qualityNum) > 0)
                {
                    Console.Write("Ravenclaw: ");
                    ravenclaw.Traversal(TestIntelligence, qualityNum);
                    Console.WriteLine();
                }
                if (hufflepuff.TraversalCheck(CountIntelligence, qualityNum) > 0)
                {
                    Console.Write("Hufflepuff: ");
                    hufflepuff.Traversal(TestIntelligence, qualityNum);
                    Console.WriteLine();
                }
                if (slytherin.TraversalCheck(CountIntelligence, qualityNum) > 0)
                {
                    Console.Write("Slytherin: ");
                    slytherin.Traversal(TestIntelligence, qualityNum);
                    Console.WriteLine();
                }
            }

            else if ((qualityName == "Perseverance") || (qualityName == "perseverance"))
            {
                if (gryffindor.TraversalCheck(CountPerseverance, qualityNum) > 0)
                {
                    Console.Write("Gryffindor: ");
                    gryffindor.Traversal(TestPerseverance, qualityNum);
                    Console.WriteLine();
                }
                if (ravenclaw.TraversalCheck(CountPerseverance, qualityNum) > 0)
                {
                    Console.Write("Ravenclaw: ");
                    ravenclaw.Traversal(TestPerseverance, qualityNum);
                    Console.WriteLine();
                }
                if (hufflepuff.TraversalCheck(CountPerseverance, qualityNum) > 0)
                {
                    Console.Write("Hufflepuff: ");
                    hufflepuff.Traversal(TestPerseverance, qualityNum);
                    Console.WriteLine();
                }
                if (slytherin.TraversalCheck(CountPerseverance, qualityNum) > 0)
                {
                    Console.Write("Slytherin: ");
                    slytherin.Traversal(TestPerseverance, qualityNum);
                    Console.WriteLine();
                }
            }
            else if ((qualityName == "Cunning") || (qualityName == "cunning"))
            {
                if (gryffindor.TraversalCheck(CountCunning, qualityNum) > 0)
                {
                    Console.Write("Gryffindor: ");
                    gryffindor.Traversal(TestCunning, qualityNum);
                    Console.WriteLine();
                }
                if (ravenclaw.TraversalCheck(CountCunning, qualityNum) > 0)
                {
                    Console.Write("Ravenclaw: ");
                    ravenclaw.Traversal(TestCunning, qualityNum);
                    Console.WriteLine();
                }
                if (hufflepuff.TraversalCheck(CountCunning, qualityNum) > 0)
                {
                    Console.Write("Hufflepuff: ");
                    hufflepuff.Traversal(TestCunning, qualityNum);
                    Console.WriteLine();
                }
                if (slytherin.TraversalCheck(CountCunning, qualityNum) > 0)
                {
                    Console.Write("Slytherin: ");
                    slytherin.Traversal(TestCunning, qualityNum);
                    Console.WriteLine();
                }
            }
            else
            {
                throw new InputException();
            }
        }
        private bool IntegerTest(string input)
        {
            try
            {
                int.Parse(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        static void TestCourage(LinkedListex wizardList, int quality)
        {
            wizardList.TestCourage(quality);
        }
        static bool CountCourage(LinkedListex wizard, int quality)
        {
            if (wizard.CountCourage(quality) > 0)
                return true;
            else return false;
        }
        static void TestIntelligence(LinkedListex wizardList, int quality)
        {
            wizardList.TestIntelligence(quality);
        }
        static bool CountIntelligence(LinkedListex wizard, int quality)
        {
            if (wizard.CountIntelligence(quality) > 0)
                return true;
            else return false;
        }
        static void TestPerseverance(LinkedListex wizardList, int quality)
        {
            wizardList.TestPerseverance(quality);
        }
        static bool CountPerseverance(LinkedListex wizard, int quality)
        {
            if (wizard.CountPerseverance(quality) > 0)
                return true;
            else return false;
        }
        static void TestCunning(LinkedListex wizardList, int quality)
        {
            wizardList.TestCunning(quality);
        }
        static bool CountCunning(LinkedListex wizard, int quality)
        {
            if (wizard.CountCunning(quality) > 0)
                return true;
            else return false;
        }
    }
}

