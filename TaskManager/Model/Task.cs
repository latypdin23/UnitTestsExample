using System;
using System.Collections.Generic;

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
        public List<Report> Reports { get; set; }
        public void DoReport()
        {
            Report report = new Report();
            Reports.Add(report);
        }
    }
}
