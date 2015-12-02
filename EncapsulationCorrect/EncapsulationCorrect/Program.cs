using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationCorrect
{
    class Program
    {
        //For assignment 1, see Person.CS
        static void Main(string[] args)
        {
            #region Assignment4
            Person person = new Person();
           // person.age = 7; SVAR: Nej, ger error person.age is inaccessible
            #endregion
            //For assignment 5, see PersonHandler.cs
            #region Assignment10
            PersonHandler PH = new PersonHandler();
            Person Evert = PH.CreatePerson(21, "Evert", "Taub", 175, 100);
            Person Eva = PH.CreatePerson(40, "Eva", "Lindgren", 168, 70);

            Console.WriteLine(Evert.FName + " " + Evert.LName + " is " + Evert.Age + " years old");
            Console.WriteLine(Eva.FName + " " + Eva.LName + " is " + Eva.Age + " years old");
            Console.WriteLine("Evert marries eva, evas name is now:");

            PH.GetMarried(Evert, Eva, true);
            Console.WriteLine(Eva.FName + " " + Eva.LName);

            PH.Birthday(Evert);
            PH.Birthday(Eva);
            Console.WriteLine("A year passes and they are now: " + Evert.Age + " and " + Eva.Age);
            Console.WriteLine("Eva earlier weighed " + Eva.Weight + "kg but has during this year lost 10kg");
            PH.LoseWeight(Eva, 10);
            Console.WriteLine("Now she weighs " + Eva.Weight);

            Console.ReadKey();


            #endregion
        }
    }
}
