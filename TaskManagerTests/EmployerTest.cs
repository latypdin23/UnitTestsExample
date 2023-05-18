using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskManager;

namespace TaskManagerTests
{
    [TestClass]
    public class EmployerTest
    {
        [TestMethod]
        public void Employer_Name_ThrowsExceptionINameIsNotLetters()
        {
            Employer employer = new Employer();

            employer.Name = "Dina12#";

            
            // Такой тест не пройдет
            //Assert.AreEqual("Dina12#", employer.Name);
            Assert.ThrowsException<ArgumentException>(() => employer.Name);
        }
        [TestMethod]
        public void Employer_Name_ThrowsExceptionINameIsNotStartWithBigLetter()
        {
            Employer employer = new Employer();

            employer.Name = "dina";

            Assert.ThrowsException<ArgumentException>(() => employer.Name);
        }
        [TestMethod]
        public void Employer_Name()
        {
            Employer employer = new Employer();

            employer.Name = "Dina";
            
            Assert.AreEqual("Dina", employer.Name);
        }
        [TestMethod]
        public void Employer_DateOfBirth()
        {
            Employer employer = new Employer();

            employer.DateOfBirth = new DateTime(1996, 09, 23);

            Assert.AreEqual(new DateTime(1996, 09, 23), employer.DateOfBirth);
        }
        [TestMethod]
        public void Employer_DateOfBirth_ThrowsExceptionIDateOfBirthBiggerThanToday()
        {
            Employer employer = new Employer();

            employer.DateOfBirth = new DateTime(2023, 09, 23);

            Assert.ThrowsException<ArgumentException>(() => employer.DateOfBirth);
        }
    }
}
