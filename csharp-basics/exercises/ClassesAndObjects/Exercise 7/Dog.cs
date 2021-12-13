namespace Exercise_7
{
    class Dog
    {
        private string _name;
        private string _sex;
        private readonly string _mother;
        private readonly string _father;

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public Dog(string name, string sex, string mother, string father)
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }

        public string FathersName()
        {
            return _father ?? "Unknown";
        }

        public bool HasSameMotherAs(Dog dog1)
        {
            return dog1._mother == _mother;
        }
    }
}
