using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShaipovMR_01_06;

namespace TESTS
{
    [TestClass]
    public class CabelTests
    {

        public void reset()
        {
            Cabel.Spisok.Clear();
            CabelChild.Spisok.Clear();
        }
        [TestMethod]
        public void ShouldReturn_under1 ()
        {
            Cabel c = new Cabel("Сетквой", -4, 4);
            Assert.AreEqual (-1, c.Q());
        }

        [TestMethod]
        public void ShouldReturn_false ()
        {
            Cabel c = new Cabel("Сетквой", -4, 4);
            Assert.AreEqual(false, c.IsValid());
        }


        [TestMethod]
        public void ShouldReturn_falseInAddItem ()
        {
            Cabel c = new Cabel("Сетквой", -4, 4);
            Assert.AreEqual(false, Cabel.AddToBaseList(c));
            reset();
        }


        [TestMethod]
        public void ShouldReturn_falseInRemoveAtwithOneIndex ()
        {
            
            Cabel c = new Cabel("Сетквой", 4, 4);
            Cabel c1 = new Cabel("Сетквой", 7, 12);
            Cabel.AddToBaseList(c);
            Cabel.AddToBaseList(c1);
            Assert.AreEqual(false, Cabel.RemoveAt(-1));
            reset();
        }
        [TestMethod]
        public void ShouldReturn_falseInRemoveAtwithTwoIndex ()
        {

            Cabel c = new Cabel("Сетквой", 4, 4);
            Cabel c1 = new Cabel("Сетквой", 7, 12);
            Cabel.AddToBaseList(c);
            Cabel.AddToBaseList(c1);
            Assert.AreEqual(false, Cabel.RemoveAt(-1, 2));
            reset();
        }
        //базовый проверен




        [TestMethod]
        public void ShouldReturn_under1_Child ()
        {
            CabelChild c = new CabelChild("Сетквой", -4, 4, 4);
            Assert.AreEqual(-1, c.Q());
        }

        [TestMethod]
        public void ShouldReturn_false_Child ()
        {
            CabelChild c = new CabelChild("Сетквой", -4, 4, 4);
            Assert.AreEqual(false, c.IsValid());
        }


        [TestMethod]
        public void ShouldReturn_falseInAddItem_Child ()
        {
            CabelChild c = new CabelChild("Сетквой", -4, 4, 4);
            Assert.AreEqual(false, CabelChild.AddToChildList(c));
            reset();
        }


        [TestMethod]
        public void ShouldReturn_falseInRemoveAtwithOneIndex_Child ()
        {

            CabelChild c = new CabelChild("Сетквой", 4, 4,4);
            CabelChild c1 = new CabelChild("Сетквой", 7, 12,10);
            CabelChild.AddToChildList(c);
            CabelChild.AddToChildList(c1);
            Assert.AreEqual(false, CabelChild.RemoveAt(-1));
            reset();
        }
        [TestMethod]
        public void ShouldReturn_falseInRemoveAtwithTwoIndex_Child ()
        {

            CabelChild c = new CabelChild("Сетквой", 4, 4, 4);
            CabelChild c1 = new CabelChild("Сетквой", 7, 12, 20);
            CabelChild.AddToChildList(c);
            CabelChild.AddToChildList(c1);
            Assert.AreEqual(false, CabelChild.RemoveAt(-1, 2));
            reset();
        }
    }
}
