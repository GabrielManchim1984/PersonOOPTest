namespace PersonOOPTest
{
    public class GraduateCourse : ICourse
    {
        //Added the courseName and courseCode to implement the ICourse Interface
        private string courseName;
        private string courseCode;

        //Addition field researchFocus
        private string researchFocus;

        public List<Person> participants = new List<Person>();
        public GraduateCourse(string _courseName, string _courseCode, string _researchFocus)
        {
            courseName = _courseName;
            courseCode = _courseCode;
            researchFocus = _researchFocus;
        }
        public string getCourseCode()
        {
            return courseCode;
        }

        public string getCourseName()
        {
            return courseName;
        }

        public string getResearchFocus()
        {
            return researchFocus;
        }

        public void addParticipant(Person person)
        {
            participants.Add(person);
        }

        public List<Person> getParticipants()
        {
            return participants;
        }
    }
}
