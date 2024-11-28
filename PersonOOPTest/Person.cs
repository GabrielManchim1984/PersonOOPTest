namespace PersonOOPTest
{
    public abstract class Person
    {
        private string name;
        private int age;
        protected string address;
        protected Person(string _name, int _age, string _address)
        {
            name = _name;
            age = _age;
            address = _address;
        }

        public string getName() => name;
        public int getAge() => age;
        public string getAddress() => address;
        public abstract string getRole();
    }
}
