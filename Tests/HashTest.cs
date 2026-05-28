using System.Text;
using Bead.Logics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bead.Tests
{
    [TestClass]
    public class HashTest
    {
        AuthService service;
        string jelszo1;
        string jelszo2;
        public HashTest()
        {
            service = new AuthService();
            jelszo1 = "Alma123!";
            jelszo2 = "Korte456!";
        }
        [TestMethod]
        public void HashPW_IsNotNull()
        {
            string hashA1 = service.HashPassword(jelszo1);
            Assert.IsFalse(string.IsNullOrEmpty(hashA1), "A hash nem lehet üres!");
        }

        [TestMethod]
        public void HashPW_SameHash()
        {
            string hashA1 = service.HashPassword(jelszo1);
            string hashA2 = service.HashPassword(jelszo1);
            Assert.AreEqual(hashA1, hashA2, "Ugyanannak a jelszónak ugyanazt a hasht kell eredményeznie!");
        }

        [TestMethod]
        public void HashPW_DifferentHash()
        {
            string hashA1 = service.HashPassword(jelszo1);
            string hashB1 = service.HashPassword(jelszo2);
            Assert.AreNotEqual(hashA1, hashB1, "Különböző jelszavaknak különböző hasht kell adniuk!");
        }

        [TestMethod]
        public void HashPW_128char()
        {
            string hashA1 = service.HashPassword(jelszo1);
            Assert.AreEqual(128, hashA1.Length, "A SHA512 hash-nek 128 karakter hosszúnak kell lennie!");
        }
    }
}