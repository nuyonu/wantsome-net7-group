namespace OOP.Intro.Homework.Solution.ExerciseSix
{
    public class Professor
    {
        // Fields
        public string name;
        public string faculty;
        public string specialization;
        public List<Student> studentsWhoGiveTheirDegree;

        public Professor(string name, string faculty, string specialization)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;
            this.studentsWhoGiveTheirDegree = new List<Student>();
        }

        // Constructor with name, faculty, specialization, and studentsWhoGiveTheirDegree
        public Professor(string name, string faculty, string specialization, List<Student> studentsWhoGiveTheirDegree)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;
            this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
        }
    }
}