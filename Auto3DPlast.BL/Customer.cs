using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto3DPlast.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
        }

        public Customer(int customerId, string firstName, string lastName, string homeAddress, string workAddress, string emailAddress)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = LastName;
            HomeAdress = homeAddress;
            WorkAdress = workAddress;
            EmailAdress = emailAddress;
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string FirstName { get; set; }

        public string HomeAdress { get; set; }

        public string WorkAdress { get; set; }

        public string EmailAdress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName))
                isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress))
                isValid = false;
            return isValid;
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            List<Customer> customerList = new List<Customer>()
            {
                //Customer cust1 = new Customer(1, "Anja", "Birkelund", "Roskildevej 3", "Lillelundvej 21", "anbi@herningsholm.dk" )
                { new Customer(1, "Anja", "Birkelund", "Roskildevej 3", "Lillelundvej 21", "anbi@herningsholm.dk" ) },
                { new Customer(1, "Brian", "Soltau", "Anemonevej 3", "Lillelundvej 21", "brso@herningsholm.dk") },
                { new Customer(1, "Helle", "Hansen", "Lavendelvej 24", "Lillelundvej 21", "heha@herningsholm.dk" ) },
                { new Customer(1, "Otto", "Gadegaard", "Svinget 7", "Lillelundvej 21", "otg@herningsholm.dk" ) },
                { new Customer(1, "Kenneth", "Lauritsen", "Bornholmsvej 123", "Lillelundvej 21", "kela@herningsholm.dk" ) },
                { new Customer(1, "Anne", "Olsen", "Niels Damgaards Plads 98", "Lillelundvej 21", "anne_olsen@gmail.com" ) },
                { new Customer(1, "Liv", "Sørensen", "Olufsvænget 14", "Lillelundvej 21", "ls@herningsholm.dk" ) },
                { new Customer(1, "Morten", "Løve", "Ligusterhaven 1", "Lillelundvej 21", "molo@gmail.com" ) },
                { new Customer(1, "Søren", "Hansen", "Thyvej 21", "Lillelundvej 21", "soh@herningsholm.dk" ) },
                { new Customer(1, "Mette", "Vuns", "Algade 41", "Lillelundvej 21", "mev@herningsholm.dk" ) }

            };
            return customerList;
        }

        public void Save()
        {

        }
    }
}
