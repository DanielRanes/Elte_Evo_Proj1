using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bead.Logics;

namespace Bead.Tests
{
    [TestClass]
    public class CheckUsernameTests
    {
        AuthService service;
        public CheckUsernameTests()
        {
            service = new AuthService();
        }

        [TestMethod]
        public void CheckUsername_IsShort()
        {
            bool result = service.CheckUsername("Abcde");
            Assert.IsFalse(result, "A 6 karakternél rövidebb névnek hibát kellene dobnia.");

        }

        [TestMethod]
        public void CheckUsername_IsValid()
        {
            bool result = service.CheckUsername("ToletesNev");
            Assert.IsTrue(result);
        }
    }
}
