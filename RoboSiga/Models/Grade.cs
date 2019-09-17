using System.Collections.Generic;
using System.Text;

namespace RoboSiga.Models
{
    public class Grade
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Date { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }


    public class Discipline
    {
        public string Name { get; set; }
        public List<Grade> Grades { get; set; }

        public Discipline()
        {
            this.Grades = new List<Grade>();
        }

        public override string ToString()
        {
            return this.Name;
        }

        public string GetValues()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Grade grade in Grades)
            {
                sb.AppendLine($"Disciplina: {this.Name} | Avaliação: {grade.Name} | Nota: {grade.Value}");
            }
            return sb.ToString();
        }
    }
}
