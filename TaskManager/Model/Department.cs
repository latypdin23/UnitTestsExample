using System;

namespace TaskManager
{
    public class Department
    {
        private long id;
        private string name;
        /// <summary>
        /// Номер отдела
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        public Department(long id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
