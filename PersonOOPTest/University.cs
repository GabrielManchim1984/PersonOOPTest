using PersonOOPTest;

public class University
{
    public static void Main(string[] args)
    {
        /* Create List of Students and Professors */
        List<Person> Persons = new List<Person>()
        {
            new Student( _studentId:"1", _name:"stu1", _age:23,_address:"Rehovot"),
            new Student("2", "stu2", 25, "Tel-Aviv"),
            new Professor( _department:"Algo", _name:"Pro1", _age:51,_address:"Ashdod"),
            new Professor("AI", "Pro2", 42, "Kfar-Saba")
        };
        /* Create List of Courses*/
        List<ICourse> courses = new List<ICourse>()
        {
            new UndergraduateCourse(_courseName:"algo101" ,_courseCode:"1"),
            new UndergraduateCourse("AI101","2"),
            new GraduateCourse(_courseName:"algo102",_courseCode:"3",_researchFocus:"Algo"),
            new GraduateCourse("AI102", "4", "AI"),
        };

        //Add the first Student to UndergraduateCourse 
        courses[0].addParticipant(Persons[0]);
        //Add the Second Student to GraduateCourse 
        courses[2].addParticipant(Persons[1]);
        //Add the Professor to UndergraduateCourse 
        courses[0].addParticipant(Persons[2]);
        //Add the Professor to UndergraduateCourse 
        courses[3].addParticipant(Persons[3]);

        //Test
        foreach (ICourse course in courses)
        {
            var listOfParticipants = course.getParticipants();
            foreach (var participant in listOfParticipants)
            {
                #region get participant action
                var role = participant.getRole();
                string action = string.Empty;
                if (role is "Student")
                {
                    Student student = (Student)participant;
                    action = student.study();
                }
                if (role is "Professor")
                {
                    Professor professor = (Professor)participant;
                    action = professor.teach();
                }
                #endregion

                Console.WriteLine("{0} is a {1} {2} in cours: {3}"
                    , participant.getName(), participant.getRole()
                    , action
                    , course.getCourseName());

            }
        }
    }
}