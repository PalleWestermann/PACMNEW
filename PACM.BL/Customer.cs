namespace PACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }

        // FirstName uses Auto-implemented property (for when you do not need to check on Set and Get).
        public string FirstName { get; set; }

        public string FullName {
            get
            {
                return LastName + "," + FirstName;
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


    }
}
