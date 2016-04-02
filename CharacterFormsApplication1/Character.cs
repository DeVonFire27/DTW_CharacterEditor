using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterFormsApplication1
{
    public class Character
    {
        string name;
        string lastName;
        string race;
        decimal age;

        CharSkills skill;

        public CharSkills Skill
        {
            get { return skill; }
            set { skill = value; }
        }
        public string Race
        {
            get { return race; }
            set { race = value; }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public decimal Age
        {
            get { return age; }
            set { age = value; }
        }

        public Character()
        {
            skill = new CharSkills();
        }

        public override string ToString()
        {
            string fullName;
            fullName = name + ' ' + lastName;
            return fullName;
        }

    }
}
