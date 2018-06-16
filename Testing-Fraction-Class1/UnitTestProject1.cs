//Test result sheet located at https://docs.google.com/spreadsheets/d/1bIiSQwrj7LSBSmeOk3bWt3Ret3YQwSYbfLd6_K5Tibc/edit?usp=sharing


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionMath2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            Fraction f1 = new Fraction("1/2");
            Fraction f2 = new Fraction("1/2");
            Fraction f3 = f1 + f2;
            Assert.AreEqual(f3.ToString(), "1");
        }
        
        
        [TestMethod]
        public void TestSubtraction()
        {
            Fraction f1 = new Fraction("1/2");
            Fraction f2 = new Fraction("1/2");
            Fraction f3 = f1 - f2;
            Assert.AreEqual(f3.ToString(), "1/2");
        }
               
       
       [TestMethod]
        public void TestDivision()
        {
            Fraction f1 = new Fraction("1/2");
            Fraction f2 = new Fraction("2");
            Fraction f3 = f1/f2;
            Assert.AreEqual(f3.ToString(), "1/4");
        }
        
        
        [TestMethod]
        public void TestMultiplicatoin()
        {
            Fraction f1 = new Fraction("1");
            Fraction f2 = new Fraction("1/2");
            Fraction f3 = f1 *f2;
            Assert.AreEqual(f3.ToString(), "1");
        }
        
        

        [TestMethod]
        public void TestGreaterThan()
        {
            Fraction f1 = new Fraction("3/4");
            Fraction f2 = new Fraction("1/8");
           
            Assert.IsTrue(f1>f2);
        }
                
                
        [TestMethod]
        public void TestLessThan()
        {
            Fraction f1 = new Fraction("1/4");
            Fraction f2 = new Fraction("1/2");
           
            Assert.IsTrue(f1<f2);
        }

    }


}
