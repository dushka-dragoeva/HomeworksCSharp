namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : People, IComment
    {
        private List<Discipline> teachersDisciplines;

        public Teacher(string firstName, string lastName, params Discipline[] disciplines)
            : base(firstName, lastName)
        {
            this.teachersDisciplines = new List<Discipline>();
            this.teachersDisciplines.AddRange(disciplines);
        }
        public List<Discipline> TeachersDisciplines
        {
            get
            {
                return new List<Discipline>(this.teachersDisciplines);  
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.teachersDisciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.teachersDisciplines.Remove(discipline);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Teacher name: " + base.FirstName + " " + base.LastName);
            sb.AppendLine("Teacher disciplines: ");
            sb.AppendLine(string.Join(", ", TeachersDisciplines));

            return sb.ToString();
        }
    }
}