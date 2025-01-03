using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GradesAreEmpty()
        {
            // Arrange
            List<int> grades = Program.GetGrades();

            // Assert
            Assert.AreNotEqual(0, grades.Count, "No grades were found.");
        }

        [TestMethod()]
        public void GradesAreAllPositive()
        {
            // Arrange
            List<int> grades = Program.GetGrades();

            // Act
            bool allPositive = grades.All(grade => grade > 0);

            // Assert
            Assert.IsTrue(allPositive, "Not all grades are positive.");
        }

        [TestMethod()]
        public void AverageIsCorrect()
        {
            // Arrange
            List<int> grades = new List<int> { 85, 90, 78, 92, 88, 43 };

            // Act
            int average = Program.GetAverage(grades);

            // Assert
            Assert.AreEqual(73, average, "Average is incorrect.");
        }

        [TestMethod()]
        public void SlowTest()
        {
            // Wait 3 seconds
            System.Threading.Thread.Sleep(3000);

            // Assert
            Assert.IsTrue(true);
        }
    }
}