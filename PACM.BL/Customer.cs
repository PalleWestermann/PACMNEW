namespace PACM.BL
{
    public class Customer
    {
        public Customer()
        {
            
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        // FirstName uses Auto-implemented property (for when you do not need to check on Set and Get).
        public string FirstName { get; set; }

        public string FullName {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        // Property LastName uses a private 'backing' field, _lastName.
        // (for when you need to check on Set and Get, fx. Validating or Authenticating).
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }   // Get accessor returns the value of the private field _lastName.
            set { _lastName = value; }  // Value is a keyword that represents the value being assigned to the property.
        }


        /// Retrieves one customer.
        //public Customer Retrieve(int customerId)
        //{
        //    // Code that retrieves the defined customer.
        //    return new Customer();
        //}

        /// Retrieves all customers.
        /// 
        //public List<Customer> Retrieve()
        //{
        //    // Code that retrieves all customers.
        //    return new List<Customer>();
        //}

        /// Saves the current customer.
        /// 
        //public bool Save()
        //{
        //    // Code that saves the defined customer.
        //    return true;
        //}

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

    }
}
