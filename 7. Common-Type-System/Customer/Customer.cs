namespace Customer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string secondName;
        private string lastName;
        private long id;
        private string address;
        private string phoneNumber;
        private string email;
        private CustomerType customerType;
        private IList<Payment> paymentType;

        public Customer(string firstName, string secondName, string lastName, long id, string address, string phoneNumber, string emai,
            CustomerType customerType, IList<Payment> paymentType) 
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.ID = id;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.CustomerType = customerType;
            this.PaymentType = paymentType;
        }

        public IList<Payment> PaymentType
        {
            get 
            { 
                return this.paymentType;
            }
            set
            {
                this.paymentType = value;
            }
        }

        public CustomerType CustomerType
        {
            get
            {
                return this.customerType;
            }
            set
            {
                this.customerType = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }


        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public long ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }


        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }


        public string SecondName
        {
            get
            {
                return this.secondName;
            }
            set
            {
                this.secondName = value;
            }
        }


        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if (this.firstName != customer.FirstName)
            {
                return false;
            }

            if (this.secondName != customer.SecondName)
            {
                return false;
            }

            if (this.lastName != customer.LastName)
            {
                return false;
            }

            if (this.id != customer.ID)
            {
                return false;
            }

            if (this.address != customer.Address)
            {
                return false;
            }

            if (this.email != customer.Email)
            {
                return false;
            }

            if (this.phoneNumber != customer.PhoneNumber)
            {
                return false;
            }

            if (this.customerType != customer.CustomerType)
            {
                return false;
            }

            if (this.paymentType != customer.PaymentType)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.SecondName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.ID.GetHashCode() ^
                this.Address.GetHashCode() ^ this.Email.GetHashCode() ^ this.PhoneNumber.GetHashCode() ^
                this.CustomerType.GetHashCode() ^ this.PaymentType.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder payment = new StringBuilder();

            foreach (var item in this.PaymentType)
            {
                payment.Append(item);
            }

            return string.Format("{0} {1} {2}\nID: {3} \nAddres: {4} \nEmail: {5} \nPhoneNumber: {6} \nCustomer type: {7} \nPayment type: {8}",
                this.FirstName, this.SecondName, this.LastName, this.ID, this.Address, this.Email, this.PhoneNumber, this.CustomerType, payment);
        }

        public static bool operator ==(Customer a, Customer b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(Customer a, Customer b)
        {
            return !Equals(a, b);
        }

        public object Clone()
        {
            Customer customerCloning = new Customer(
                this.FirstName,
                this.SecondName,
                this.LastName,
                this.ID,
                this.Address,
                this.Email,
                this.PhoneNumber,
                this.CustomerType,
                this.PaymentType);

            return customerCloning;
        }
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Customer obj)
        {
            
            if (obj == null) return 1;

            if (this.FirstName != obj.FirstName)
            {
                return this.FirstName.CompareTo(obj.FirstName);
            }

            return this.ID.CompareTo(obj.ID);

        }

    }
}
