namespace Customer
{
    using System;
    using System.Collections.Generic;

    class Payment
    {
        private string productName;
        private decimal price;

        public Payment(string productName, decimal price)
        {
            this.Price = price;
            this.ProductName = productName;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("invalid product name");
                }
                this.productName = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Prace can't be negative.");
                }
                this.price = value;
            }
        }
    }
}
