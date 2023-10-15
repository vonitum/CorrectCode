using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CorrectCode;

namespace CorrectCodeLibraryTest
{
    [TestClass]
    public class CorrectCodeClassTests
    {
        [DataTestMethod]
        [DataRow("1234123400", true)]
        [DataRow("3000030001", true)]
        [DataRow("3000130009", true)]
        public void Test_CorrectCode_ReturnsTrue(string code, bool expected)
        {
            // Act
            bool result = CorrectCodeLibrary.IsCorrectCode(code);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [DataTestMethod]
        [DataRow("", false)]
        [DataRow("123", false)]
        [DataRow("123123123123123", false)]
        [DataRow("strokasymb", false)]
        [DataRow("1234123401", false)]
        [DataRow("1234123404", false)]
        public void Test_CorrectCode_ReturnsFalse(string code, bool expected)
        {
            // Act
            bool result = CorrectCodeLibrary.IsCorrectCode(code);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
