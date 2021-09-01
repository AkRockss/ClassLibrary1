using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void StudentNameTest()
        {
            Student student = new Student("Anders", "ValpeVej 2", 3);
            student.Name = "Anders";
            Assert.AreEqual("Anders", student.Name);

            Assert.ThrowsException<ArgumentException>(
                () => student.Name = "");

          
                   
        }

        [TestMethod()]
        public void StudentAdressTest()
        {
            Student student = new Student("Anders", "ValpeVej 2", 3);
            student.Adress = null;
            Assert.IsNotNull(null, student.Adress);

            Assert.ThrowsException<ArgumentException>(
                () => student.Name = "");

        }


        [TestMethod()]
        public void StudentSemesterTest()
        {
            Student student = new Student("Anders", "ValpeVej 2", 3);
            student.Semester = -1;
            Assert.AreEqual(-1, student.Semester);

            Assert.ThrowsException<ArgumentException>(
                () => student.Name = "");

        }



    }
    }
