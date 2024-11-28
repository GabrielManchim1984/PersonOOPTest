namespace PersonOOPTest
{
    public class Professor : Person
    {
        private string department;
        public Professor(string _department, string _name, int _age, string _address)
            : base(_name, _age, _address)
        {
            department = _department;
        }
        public override string getRole()
        {
            return "Professor";
        }

        public string teach()
        {
            return $"Teaching";
        }

        public string getDepartment() => department;
    }
}
