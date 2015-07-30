using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathfinderLibrary;

namespace LibraryTest
{
    [TestClass]
    public class CharacterTests
    {
        Character testChar = new Character("Testing Character 1");
        
        [TestMethod]
        public void blankConstructorTest()
        {
            Assert.IsInstanceOfType(testChar, typeof(Character));
        }

        [TestMethod]
        public void namePropertyTest()
        {
            Assert.AreEqual("Testing Character 1", testChar.Name);

            testChar.Name = "New Name";

            Assert.IsInstanceOfType(testChar.Name, typeof(string));
            Assert.AreEqual("New Name", testChar.Name);

            testChar.Name = Convert.ToString(12);

            Assert.IsInstanceOfType(testChar.Name, typeof(string));
            Assert.AreEqual("12", testChar.Name);
        }

        [TestMethod]
        public void agePropertyTest()
        {
            Assert.IsInstanceOfType(testChar.Age, typeof(int));
            Assert.AreEqual(0, testChar.Age);

            testChar.Age = 10;

            Assert.AreEqual(10, testChar.Age);
        }

        [TestMethod]
        public void alignmentPropertyTest()
        {        
            Assert.IsInstanceOfType(testChar.Alignment, typeof(Array));
            Assert.AreEqual(2, testChar.Alignment.Length);
            Assert.AreEqual(0, testChar.Alignment[0]);
            Assert.AreEqual(0, testChar.Alignment[1]);
        }

        [TestMethod]
        public void racePropertyTest()
        {
            Assert.IsInstanceOfType(testChar.Race, typeof(string));
            Assert.AreEqual(testChar.Race, null);
        }
    }
}
