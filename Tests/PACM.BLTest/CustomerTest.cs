using PACM.BL;

namespace PACM.BLTest
{
    [TestClass]
    public sealed class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            //// Using an object initializer to create a Test Customer Object
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            
            string expected = "Baggins, Bilbo"; // Variable to hold the expected value result when actually running the FullName Property
            // Act
            string actual = customer.FullName;  // Actually performing the operation we are testing for.
            // Assert
            Assert.AreEqual(expected, actual);  // Verifying the expected result is the same as the actual result.
        }

        [TestMethod]
        public void FullNameTFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";
            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";
            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobitton.me"
            };
            var expected = true;
            // Act
            var actual = customer.Validate();
            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            Customer customer = new Customer
            {
                EmailAddress = "fbaggins@hobitton.me"
            };
            var expected = false;
            // Act
            var actual = customer.Validate();
            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
