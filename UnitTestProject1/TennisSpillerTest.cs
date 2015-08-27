using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using trådopgave;

namespace UnitTestProject1 {
    [TestClass]
    public class TennisSpillerTest {
        [TestMethod]
        public void TestNyTennisSpillerFrederikIkkeHarBolden() {
            //3 Setup
            TennisSpiller Frederik;
            const string navn = "Frederik";
            //2 Execution
            Frederik = new TennisSpiller(navn);
            //1 Verification
            Assert.AreEqual(navn, Frederik.Navn);
            Assert.IsFalse(Frederik.HarBolden);
            //4 Teardown
            //virk git
        }
        [TestMethod]
        public void TestNyTennisSpillerCarolineIkkeHarBolden() {
            //3 Setup
            TennisSpiller Caroline;
            const string navn = "Caroline";
            //2 Execution
            Caroline = new TennisSpiller(navn);
            //1 Verification
            Assert.AreEqual(navn, Caroline.Navn);
            Assert.IsFalse(Caroline.HarBolden);
            //4 Teardown
        }


    }
}
