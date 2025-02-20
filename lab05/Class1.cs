namespace lab05;

public class Class1
{
}

public class MixedNumber : RationalNumber 
{
    private int WholeNumber;
    private RationalNumber PartialUnits;

    public MixedNumber(int _numerator, int _denominator) : this(new RationalNumber(_numerator,_denominator))
    {
        RationalNumber rationalNumber = new RationalNumber(_numerator, _denominator);
        new MixedNumber(rationalNumber);
    }

    public MixedNumber(RationalNumber fraction)
    {
        WholeNumber = fraction.Numerator / fraction.Denominator;
        int newNumerator = fraction.Numerator % fraction.Denominator;
        PartialUnits = new RationalNumber(newNumerator,fraction.Denominator);
    }

    public void displayMixedNumber()
    {
        if(WholeNumber > 0)
        {
            Console.Write($"{WholeNumber} ");
            if(PartialUnits.Numerator > 0)
            {
                PartialUnits.ShowRationalNumber();
            }
        }else
        {
            PartialUnits.ShowRationalNumber();
        }
    }

    public override int GetHashCode()
    {
        if(WholeNumber > 0)
        {
            double combine = WholeNumber + PartialUnits.GetHashCode();
            return HashCode.Combine(combine);
        }else
        {
            return PartialUnits.GetHashCode();
        }
    }

    public override bool Equals(object? obj)
    {
        double combine = WholeNumber + PartialUnits.GetHashCode();
        if(HashCode.Combine(combine) == obj.GetHashCode())
        {
            return true;
        }else
        {
            return false;
        }  
    }
}

public class RationalNumber
{
    public  int Numerator{get; private set;}
    public  int Denominator{get; private set;}

    public RationalNumber()
    {
    }

    public RationalNumber(int numerator, int denominator)
    {
        if(GreatestCommonDenominator(numerator,denominator) > 0)
        {
            Numerator = numerator / GreatestCommonDenominator(numerator,denominator);
            Denominator = denominator / GreatestCommonDenominator(numerator,denominator);
        }else
        {
            Numerator = numerator;
            Denominator = denominator;
        }
    }

    public void ShowRationalNumber()
    {
        Console.Write($"{Numerator}/{Denominator} ");
    }

    static int GreatestCommonDenominator(int a, int b)
    {
        if(b == 0)
        {
            return Math.Abs(a);
        }else
        {
            return GreatestCommonDenominator(b, a % b);
        }
    }

    public override int GetHashCode()
    {
        double combine = Numerator/Denominator;
        return HashCode.Combine(combine);
    }

    public override bool Equals(object? obj)
    {
        double combine = Numerator/Denominator;
        if(HashCode.Combine(combine) == obj.GetHashCode())
        {
            return true;
        }
        return false;
    }
}