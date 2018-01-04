using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Auto3DPlast.BL;

namespace Auto3DPlast.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValid()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Anja";
            customer.LastName = "Birkelund";

            string expected = "Birkelund, Anja";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.LastName = "Birkelund";

            string expected = "Birkelund";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer();
            customer.FirstName = "Anja";

            string expected = "Anja";

            // Act
            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer();
            customer.LastName = "Birkelund";
            customer.EmailAdress = "anbi@herningsholm.dk";

            var expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateLastNameIsMissing()
        {
            // Arrange
            var customer = new Customer();
            customer.EmailAdress = "anbi@herningsholm.dk";

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateEmailIsMissing()
        {
            // Arrange
            var customer = new Customer();
            customer.LastName = "Birkelund";

            var expected = false;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
