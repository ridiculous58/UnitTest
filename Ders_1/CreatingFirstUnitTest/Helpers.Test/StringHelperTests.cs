using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Test
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Girilen_ifadenin_basindaki_ve_sonundaki_fazla_bosluklar_silinmelidir()
        {
            //Bir teste uc kısım bulunur 
            //1.Kısım ılk kısım Arrange
            //2.Kısım Act
            //3.Kısım Assert
            /*******************************************************************/

            //Arrange
            var ifade = "    Emirhan Çifci    ";
            var beklenen = "Emirhan Çifci";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert

            Assert.AreEqual(beklenen, gerceklesen);

        }

        [TestMethod]
        public void Girilen_ifadenin_icindeki_fazla_bosluklar_silinmelidir()
        {
            //Arrange
            var ifade = "Emirhan                 Çifci                Paris      Dilara   France   Germany    Solingen   Frankfurt  ";
            var beklenen = "Emirhan Çifci Paris Dilara France Germany Solingen Frankfurt";

            //Act
            var gerceklesen = StringHelper.FazlaBosluklariSil(ifade);

            //Assert

            Assert.AreEqual(beklenen, gerceklesen);
        }
    }
}


