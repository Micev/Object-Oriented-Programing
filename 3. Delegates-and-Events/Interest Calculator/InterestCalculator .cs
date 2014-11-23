using System;

namespace Interest_Calculator
{
    public delegate double CalculateInterest(double sum, double interest, int year);
    class InterestCalculator
    {
        private double sum;
        private double interest;
        private int year;
        private double typeOfInterest;

        public double Sum
        {
            get { return this.sum; }
            set
            {
                this.sum = value;
            }
        }
        public double Interest
        {
            get { return this.interest; }
            set
            {
                this.interest = value;
            }
        }
        public int Year
        {
            get { return this.year; }
            set
            {
                this.year = value;
            }
        }
        public double TypeOfInterest
        {
            get { return this.typeOfInterest; }
            set
            {
                this.typeOfInterest = value;
            }
        }

        public InterestCalculator(double sum, double interest, int year, CalculateInterest type)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Year = year;
            this.TypeOfInterest = type(sum, interest, year);
        }

        private static double GetSimpleInterest(double sum, double interest, int year)
        {
            double result = sum * (double)(1 + interest * year / 100);
            return result;
        }
        private static double GetCompoundInterest(double sum, double interest, int year)
        {
            int n = 12;
            double result = sum * (double)Math.Pow(1 + (interest / n / 100), year * n);
            return result;
        }

        private static void Main()
        {
            InterestCalculator componentInterest = new InterestCalculator(500, 5.6, 10, GetCompoundInterest);
            Console.WriteLine("{0:0.0000}",componentInterest.TypeOfInterest);

            InterestCalculator simpelInterest = new InterestCalculator(2500, 7.2, 15, GetSimpleInterest);
            Console.WriteLine("{0:0.0000}",simpelInterest.typeOfInterest);
        }
    }
}
