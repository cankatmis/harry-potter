using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace HarryPotter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Wizards w = new Wizards();
                    Houses gryffindor = new Houses();
                    Houses ravenclaw = new Houses();
                    Houses hufflepuff = new Houses();
                    Houses slytherin = new Houses();

                    Console.WriteLine("How many wizards do you want to create?");
                    string inputWiz = Console.ReadLine();

                    if (IntegerTest(inputWiz) == false)
                    {
                        throw new InputNumberException();
                    }

                    int numWiz = int.Parse(inputWiz);

                    LinkedListex wizardList = new LinkedListex();
                    w.GenerateRandomWizards(wizardList, numWiz);

                    SortingHat h = new SortingHat(wizardList, gryffindor, ravenclaw, hufflepuff, slytherin);
                    h.AssignWizards();

                    Console.WriteLine("Input: ");
                    string input = Console.ReadLine();
                    h.InputManager(input, gryffindor, ravenclaw, hufflepuff, slytherin);
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (KeyException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Unexpected key problem. Please contact your software vendor.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (InsertionException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: An error happened while assigning wizards to the houses.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (InputException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: The given quality name wasn't in correct form.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (InputNumberException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: The given number wasn't in correct form.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        static bool IntegerTest(string input)
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
    }
}
