namespace OOP.Intro.Homework.Solution.ExerciseSeven
{
    public class Professor
    {
        // Fields
        public string name;
        public College faculty;
        public string specialization;
        private List<Student> studentsWhoGiveTheirDegree;

        // Constructor with name, faculty, specialization
        public Professor(string name, College faculty, string specialization)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;
            this.studentsWhoGiveTheirDegree = new List<Student>();
        }

        // Constructor with name, faculty, specialization, and studentsWhoGiveTheirDegree
        public Professor(string name, College faculty, string specialization, List<Student> studentsWhoGiveTheirDegree)
        {
            this.name = name;
            this.faculty = faculty;
            this.specialization = specialization;

            foreach (var student in studentsWhoGiveTheirDegree)
            {
                if (IsStudentAssignedToADifferentCollege(student))
                {
                    throw new Exception("Can't help a student from different college.");
                }
            }

            this.studentsWhoGiveTheirDegree = studentsWhoGiveTheirDegree;
        }

        public void AddStudent(Student student)
        {
            if (IsStudentAssignedToADifferentCollege(student))
            {
                throw new Exception("Can't help a student from different college.");
            }

            studentsWhoGiveTheirDegree.Add(student);
        }

        public List<Student> GetStudentsWhoGiveTheirDegree()
        {
            return this.studentsWhoGiveTheirDegree;
        }

        private bool IsStudentAssignedToADifferentCollege(Student student)
        {
            return student.college.name != faculty.name;
        }
    }
}