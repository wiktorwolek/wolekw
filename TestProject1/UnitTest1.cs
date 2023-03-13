using BankAccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Empty()
        {
            var s = new StringCalculator();
            Assert.AreEqual(0, s.Calculate(""));
            
        }
        [TestMethod]
        public void TestMethod_SingleNumber()
        {
            var s = new StringCalculator();
            Assert.AreEqual(12, s.Calculate("12"));
            Assert.AreEqual(58, s.Calculate("58"));

        }
        [TestMethod]
        public void TestMethod_2NumbersComa()
        {
            var s = new StringCalculator();
            Assert.AreEqual(2,s.Calculate("1,1")); 
            Assert.AreEqual(40,s.Calculate("10,30"));

        }
        
        [TestMethod]
        public void TestMethod_2NumbersNewLine()
        {
            var s = new StringCalculator();
            Assert.AreEqual(40,s.Calculate("10\n30"));

        }
       
        [TestMethod]
        public void TestMethod_3Numbers()
        {
            var s = new StringCalculator();
            Assert.AreEqual(42, s.Calculate("10,30,2"));
            Assert.AreEqual(42, s.Calculate("10\n30\n2"));

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod_Negative()
        {
            var s = new StringCalculator();

            s.Calculate("-1");

        }
        [TestMethod]
        public void TestMethod_MoreThan1000()
        {
            var s = new StringCalculator();
            Assert.AreEqual(12, s.Calculate("1000\n10\n1"));
        }
        [TestMethod]
        public void TestMethod_CustomSplit()
        {
            var s = new StringCalculator();
            Assert.AreEqual(5, s.Calculate("\\\\$2$3"));
        }
    }
}