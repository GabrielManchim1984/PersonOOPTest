namespace PersonOOPTest
{
    internal class UndergraduateCourse : ICourse
    {
        private string courseName;
        private string courseCode;
        private List<Person> Participants = new List<Person>();

        public UndergraduateCourse(string _courseName, string _courseCode)
        {
            courseName = _courseName;
            courseCode = _courseCode;
        }
        public string getCourseCode()
        {
            return courseCode;
        }

        public string getCourseName()
        {
            return courseName;
        }

        public void addParticipant(Person person)
        {
            Participants.Add(person);
        }

        public List<Person> getParticipants()
        {
            return Participants;
        }
    }
}
