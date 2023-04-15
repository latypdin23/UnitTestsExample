using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Rectangle;


namespace RectangleTest
{
    [TestClass]
    public class MainFormViewModelTests
    {
        [TestMethod]
        public void ViewModel_HasWidthProperty()
        {
            var vm = new MainFormViewModel();

            vm.Width = "3";
            Assert.IsInstanceOfType(vm.Width,typeof(string));
            Assert.AreEqual("3", vm.Width);
        }

        [TestMethod]
        public void ViewModel_HasLengthProperty()
        {
            var vm = new MainFormViewModel();
            vm.Length = "3";

            Assert.IsInstanceOfType(vm.Length, typeof(string));
            Assert.AreEqual("3", vm.Length);

        }
        [TestMethod]
        public void ViewModel_CalculateArea_ThrowsExceptionIfWidthIsNegativeNumber()
        {
            var vm = new MainFormViewModel();
            vm.Width = "-3";
            vm.Length = "3";

            Assert.ThrowsException<ArgumentException>(() => vm.GetArea());
        }
        [TestMethod]
        public void ViewModel_CalculateArea_ThrowsExceptionIfWidthEqualsZero()
        {
            var vm = new MainFormViewModel();
            vm.Width = "0";
            vm.Length = "3";

            Assert.ThrowsException<ArgumentException>(() => vm.GetArea());
        }
        [TestMethod]
        public void ViewModel_CalculateArea_ThrowsExceptionIfWidthIsNotNumber()
        {
            var vm = new MainFormViewModel();
            vm.Width = "a";
            vm.Length = "3";

            Assert.ThrowsException<ArgumentException>(() => vm.GetArea());
        }
        [TestMethod]
        public void ViewModel_CalculateArea_ThrowsExceptionIfLengthIsNegativeNumber()
        {
            var vm = new MainFormViewModel();
            vm.Width = "3";
            vm.Length = "-3";

            Assert.ThrowsException<ArgumentException>(() => vm.GetArea());
        }
        [TestMethod]
        public void ViewModel_CalculateArea_ThrowsExceptionIfLenthEqualsZero()
        {
            var vm = new MainFormViewModel();
            vm.Width = "3";
            vm.Length = "0";

            Assert.ThrowsException<ArgumentException>(() => vm.GetArea());
        }
        [TestMethod]
        public void ViewModel_CalculateArea_ThrowsExceptionIfLenthIsNotNumber()
        {
            var vm = new MainFormViewModel();
            vm.Width = "3";
            vm.Length = "a";

            Assert.ThrowsException<ArgumentException>(() => vm.GetArea());
        }
        [DataTestMethod]
        [DataRow("3","3",9)]
        public void ViewModel_CalculateArea(string width, string length, int output)
        {
            var vm = new MainFormViewModel();
            vm.Width = width;
            vm.Length = length;

            int area = vm.GetArea();

            Assert.AreEqual(output, area);
        }
        [DataTestMethod]
        [DataRow("3", "3",12)]
        public void ViewModel_CalculatePerimetr(string width, string length, int output)
        {
            var vm = new MainFormViewModel();
            vm.Width = width;
            vm.Length = length;

            int perimetr = vm.GetPerimeter();

            Assert.AreEqual(output, perimetr);
        }
    }
}
