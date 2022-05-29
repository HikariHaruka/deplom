using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryAddUserPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAddUserPassword.Tests
{
    [TestClass()]
    public class ClassAddUserPasswordTests
    {
        [TestMethod()]
        public void TestCorrectPassword_1()
        {
            string password = "Ivanov_1";
            bool result = ClassAddUserPassword.checkPassword(password);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void TestCorrectPassword_2()
        {
            string password = "Petr$23";
            bool result = ClassAddUserPassword.checkPassword(password);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void TestCorrectPassword_3()
        {
            string password = "Svet!56";
            bool result = ClassAddUserPassword.checkPassword(password);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void TestIncorrectPassword_1()
        {
            string password = "Ин12";
            bool result = ClassAddUserPassword.checkPassword(password);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void TestIncorrectPassword_2()
        {
            string password = "Ин$$";
            bool result = ClassAddUserPassword.checkPassword(password);
            Assert.AreEqual(false, result);
        }

        [TestMethod()]
        public void TestIncorrectPassword_3()
        {
            string password = "Inna13";
            bool result = ClassAddUserPassword.checkPassword(password);
            Assert.AreEqual(false, result);
        }
    }
}