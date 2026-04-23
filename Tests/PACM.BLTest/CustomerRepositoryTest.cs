using PACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();

            // Remember, the CustomerId property is 'private set', so we use the constructor to set it.
            // We created an overloaded constructor to handle just that.

            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // -- Assert 
            // Notice: we cannot use the Assert functionality in the normal way!
            // Why? Because, if we compare the 2 objects, we will be comparing the memory addresses of the 2 objects,
            // and they will be different. So, we need to compare the properties of the 2 objects.
            // Assert.AreEqual(expected, actual); // This will fail because it compares the memory addresses of the 2 objects.
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
