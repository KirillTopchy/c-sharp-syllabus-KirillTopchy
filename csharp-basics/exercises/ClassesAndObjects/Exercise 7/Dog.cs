using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Dog
    {
        private string Name { get; set; }
        private string Sex { get; set; }
        private string Mother { get; set; }
        private string Father { get; set; }

        public Dog(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }

        public Dog(string name, string sex, string mother, string father)
        {
            Name = name;
            Sex = sex;
            Mother = mother;
            Father = father;
        }

        public string FathersName()
        {
            return Father ?? "Unknown";
        }

        public bool HasSameMotherAs(Dog dog1)
        {
            return dog1.Mother == Mother;
        }
    }
}
