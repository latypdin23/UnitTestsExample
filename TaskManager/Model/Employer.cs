using System;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text.RegularExpressions;

namespace TaskManager
{
    public class Employer
    {
        private long tabNum;
        private string name;
        private string surname;
        private DateTime dateOfBirth;
        private Department department;
        /// <summary>
        /// Табельный номер
        /// </summary>
        public long TabNum 
        { 
            get
            {
                return tabNum;
            }
            set
            {
                tabNum = value;
            }
        }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name
        {
            get
            {
                if (Regex.Match(name, "^[A-Z][a-zA-Z]*$").Success)
                {
                    if (Char.IsUpper(name[0]))
                    {
                        return name;
                    }
                    else
                    {
                        throw new ArgumentException("Имя должно начинаться с заглавной буквы", nameof(Name));

                    }
                }
                else
                {
                    throw new ArgumentException("Имя может содержать только буквенные символы", nameof(Name));
                }
            }
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname 
        {
            get
            {
                if(Regex.Match(surname, "^[A-Z][a-zA-Z]*$").Success)
                {
                    if (Char.IsUpper(name[0]))
                    {
                        return surname;
                    }
                    else
                    {
                        throw new ArgumentException("Фамилия должна начинаться с заглавной буквы", nameof(Surname));

                    }
                }
                else
                {
                    throw new ArgumentException("Фамилия может содержать только буквенные символы", nameof(Surname));
                }
            }
            set
            {
                surname = value;
            }
        }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth 
        { 
            get
            {
                if (dateOfBirth < DateTime.Today)
                {
                    return dateOfBirth;
                }
                else
                {

                    throw new ArgumentException("Дата рождения не может быть больше или равной текущей дате");
                }
            }
            set
            {
                dateOfBirth = value;
            }
        }
        /// <summary>
        /// Отдел
        /// </summary>
        public Department Department 
        { 
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        /// <summary>
        /// Инциализирует объект значениями по умолчанию
        /// </summary>
        public Employer() { }
        /// <summary>
        /// Инициализирует сотрудника с заданными параметрами
        /// </summary>
        /// <param name="tabNum"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="department"></param>
        public Employer(long tabNum, string name, string surname, DateTime dateOfBirth, Department department)
        {
            this.tabNum = tabNum;
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
            this.department = department;
        }
        /// <summary>
        /// Получить возраст
        /// </summary>
        public int GetAge
        {
            get
            {
                return DateTime.Today.Year - DateOfBirth.Year;
            }
        }
        public string GetFullName
        {
            get
            {
                return Surname+" "+Name;
            }
        }
        public void GiveTask(Task task,Employer to)
        {

        }
    }
}
