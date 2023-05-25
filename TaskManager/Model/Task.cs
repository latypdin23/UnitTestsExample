using System;
using System.Collections.Generic;
using TaskManager.Model;

namespace TaskManager
{
    public class Task
    {
        private long id;
        private string description;
        private DateTime dateStart;
        private DateTime dateEnd;
        private Employer initiator;
        private Employer ispolnitel;

        public long Id { get { return id; } set {  id = value; } }
        public string Description 
        { 
            get 
            { 
                return description; 
            }
            set
            {
                description = value;
            } 
        }
        public DateTime DateStart { get { return dateStart; } set { dateStart = value; } }
        public DateTime DateEnd { get { return dateEnd; } set { dateEnd = value; } }
        public Employer Initiator { get { return initiator; } set {  initiator = value; } }
        public Employer Ispolnitel { get { return ispolnitel; } set {  ispolnitel = value; } }
        public State Status { get; set; }
        public List<Report> Reports { get; set; }
        public Task() { }
        public Task(long id, string description, DateTime dateStart, DateTime dateEnd, 
                    Employer initiator, Employer ispolnitel)
        {
            Id = id;
            Description = description;
            DateStart = dateStart;
            DateEnd = dateEnd;
            Initiator = initiator;
            Ispolnitel = ispolnitel;
            Reports = new List<Report>();
            Status = State.Проект;
        }

        public void DoReport()
        {
            Report report = new Report();
            Reports.Add(report);
        }
    }
}
