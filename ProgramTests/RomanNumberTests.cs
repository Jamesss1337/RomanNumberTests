using Microsoft.VisualStudio.TestTools.UnitTesting;
using romannumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romannumbers.Tests
{



    [TestClass()]
        public class RomanNumberTests
        {
             [TestMethod()]
              public void ZeroExceptionTest()
        {
            RomanNumber a;
            Assert.ThrowsException<RomanNumberException>(() => a = new(0));
        }
        
        [TestMethod()]
        public void ZeroExceptionTest2()
        {
            RomanNumber a = new(10);
            RomanNumber b = new(12);
            Assert.ThrowsException<RomanNumberException>(() => a - b);
        }
        
        [TestMethod()]
        public void RomanNumberTest()
        {
            RomanNumber a = new(55);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber a = new(21);
                string result = "XXI";
            Assert.AreEqual(a.ToString(), result);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber a = new(111);
            RomanNumber b = (RomanNumber)a.Clone();
            Assert.AreNotSame(a, b);
        }

        [TestMethod()]
        public void ArraySortTest()
        {
            RomanNumber a = new(111);
            RomanNumber b = new(543);
            RomanNumber c = new(35);
            RomanNumber d = new(12);
                RomanNumber[] result = { d, c, a, b };
                RomanNumber[] massive = { a, b, c, d };

            Array.Sort(massive);
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(massive[i], result[i]);
            }
        }

        [TestMethod()]
        public void CompareToTest()
        {
            RomanNumber a = new(111);
            RomanNumber b = new(111);
            int expected = 0;
            int actual = a.CompareTo(b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest()
        {
            RomanNumber a = new(111);
            RomanNumber b = new(543);
                RomanNumber result = new(654);
            Assert.AreEqual(result.ToString(), (a + b).ToString());
        }

        [TestMethod()]
        public void SubTest()
        {
            RomanNumber a = new(1540);
            RomanNumber b = new(543);
                RomanNumber result = new(997);
            Assert.AreEqual(result.ToString(), (a - b).ToString());
        }
        [TestMethod()]
        public void DivTest()
        {
            RomanNumber a = new(350);
            RomanNumber b = new(110);
                RomanNumber result = new(3);
            Assert.AreEqual(result.ToString(), (a / b).ToString());
        }
        [TestMethod()]
        public void MulTest()
        {
            RomanNumber a = new(5);
            RomanNumber b = new(8);
                RomanNumber result = new(40);
            Assert.AreEqual(result.ToString(), (a * b).ToString());
        }
    }
}