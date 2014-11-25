public struct Fraction
{
    private long numerator;
    private long denominator;

    public Fraction(long numerator, long denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }
    public long Numerator
    {
        get { return this.numerator; }
        set
        {
            this.numerator = value;
        }
    }
    public long Denominator
    {
        get { return this.denominator; }
        set
        {
            this.denominator = value;
        }
    }

    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        if (f1.denominator == f2.denominator)
            return new Fraction(f1.numerator + f2.numerator, f1.denominator);
        else
            return new Fraction(f1.numerator * f2.denominator + f2.numerator * f1.denominator, f1.denominator * f2.denominator);
    }

    public static Fraction operator -(Fraction f1, Fraction f2)
    {
        if (f1.denominator == f2.denominator)
            return new Fraction(f1.numerator - f2.numerator, f1.denominator);
        else
            return new Fraction(f1.numerator * f2.denominator - f2.numerator * f1.denominator, f1.denominator * f2.denominator);
    }

    public override string ToString()
    {
        return string.Format("{0}",(decimal)numerator / denominator);
    }
}