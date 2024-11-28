namespace PersonOOPTest
{
    public class Student : Person
    {
        private string studentId;

        public Student(string _studentId, string _name, int _age, string _address)
            : base(_name, _age, _address)
        {
            studentId = _studentId;
        }
        public override string getRole()
        {
            return "Student";
        }

        public string study()
        {
            return $"Studing";
        }
        public string getstudentId() => studentId;
    }
}
