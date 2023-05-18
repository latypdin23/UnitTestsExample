using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Report
    {
        public int Id { get; set; }
        public string Desription { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public Status Status { get; set; }
        public void SendToCheck()
        {
            //todo
        }
    }
}
