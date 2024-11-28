namespace PersonOOPTest
{
    interface ICourse
    {
        public string getCourseName();
        public string getCourseCode();
        public void addParticipant(Person person);
        public List<Person> getParticipants();

    }
}
