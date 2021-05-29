using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestContextDemo.Tests
{
    [TestClass]
    public class CustomerManagerTest
    {
        
        public TestContext TestContext { get; set; }
        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("--TestInitialize--\n");
            TestContext.WriteLine("Test Adi : {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu {0}", TestContext.CurrentTestOutcome); //Mevcut Test Sonucu
            TestContext.Properties["bilgi"] = "Deneme Metni";

        }

        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("--TestCleanup--\n");
            TestContext.WriteLine("Test Adi : {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu {0}", TestContext.CurrentTestOutcome); //Mevcut Test Sonucu
            TestContext.WriteLine("Test Properties {0}", TestContext.Properties["bilgi"]);

        }
        
        public void TestContex_Nasil_Calisir()
        {
            TestContext.WriteLine("--TestContex_Nasil_Calisir--\n");
            TestContext.WriteLine("Test Adi : {0}", TestContext.TestName);
            TestContext.WriteLine("Test Durumu {0}", TestContext.CurrentTestOutcome); //Mevcut Test Sonucu
            TestContext.WriteLine("Test Sinifi {0}", TestContext.FullyQualifiedTestClassName); // Tam Nitelikli Test Sınıfı Adı
            TestContext.WriteLine("Test Properties {0}", TestContext.Properties["bilgi"]);

            Assert.AreEqual(1, 1);
        }
    }
}
