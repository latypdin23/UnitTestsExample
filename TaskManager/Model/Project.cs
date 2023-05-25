using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManager.Model
{
    public enum State
    {
        Проект,
        Исполнение,
        Закрыт,
        Назначена,
        Работа,
        Проверка,
        Выполнено
    }
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public State Status { get; set; }
        public Employer TeamLead { get; set; }
        public List<Task> Tasks { get; set; }
        public Project() { }
        public Project(int id, string name, DateTime dateStart, DateTime dateEnd, Employer teamLead)
        {
            Id = id;
            Name = name;
            DateStart = dateStart;
            DateEnd = dateEnd;
            TeamLead = teamLead;
            Status = State.Проект;
            Tasks= new List<Task>();
        }
        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
        //Продумать, что статус можно менять только на один вперед или назад(из Проект в Выполнено вернуться нельзя)
        public bool ChangeState(State state)
        {
            if (state == State.Выполнено && Status==State.Исполнение)
            {
                foreach(Task task in Tasks)
                {
                    if(task.Status!=State.Выполнено)
                    {
                        MessageBox.Show("Не все задачи по проекту выполнены","Ошибка!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                Status = state; 
                return true;
            }
            else
            {
                Status=state; 
                return true;
            }
        }
    }
}
