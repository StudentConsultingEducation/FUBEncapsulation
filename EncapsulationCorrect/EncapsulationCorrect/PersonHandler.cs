using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationCorrect
{
    #region Assignment5
    public class PersonHandler
    {
        #region Assignment6
        public void SetAge(Person person, int age)
        {
            #region Assignment7
            person.Age = age;
            #endregion
        }
        #endregion
        #region Assignment8
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person temporaryPerson = new Person();
            temporaryPerson.Age = age;
            temporaryPerson.FName = fName;
            temporaryPerson.LName = lName;
            temporaryPerson.Height = height;
            temporaryPerson.Weight = weight;

            return temporaryPerson;
        }
        #endregion
        #region Assignment9
        //The following methods are examples for what you could want. Not required.
        public void Birthday(Person person)
        {
            person.Age += 1;
        }

        public void GetMarried(Person nameGiver, Person nameTaker, bool doubleName)
        {
            if (!doubleName)
            {
                nameTaker.LName = nameGiver.LName;
            }
            else
            {
                nameTaker.LName += " " + nameGiver.LName;
            }
        }

        public void LoseWeight(Person person, int weightloss)
        {
            person.Weight -= weightloss;
        }

        public void NameChange(Person person, string newfName, string newlName)
        {
            person.FName = newfName;
            person.LName = newlName;
        }


        #endregion
    }
    #endregion
}
