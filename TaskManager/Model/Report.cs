using System;

namespace TaskManager.Model
{
    public class Report
    {
        public int Id { get; set; }
        public string Desription { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public State Status { get; set; }
        public Report() { }
        public Report(int id, string desription, DateTime dateStart, DateTime dateEnd)
        {
            Id = id;
            Desription = desription;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Status = State.Проект;
        }

        public void SendToCheck(Employer to)
        {
            //todo
        }
    }
}
