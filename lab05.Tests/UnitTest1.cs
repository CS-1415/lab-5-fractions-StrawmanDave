namespace lab05.Tests;

using System.Diagnostics;
using lab05;
using NUnit.Framework.Internal;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        Test1();
        Test2();
        Test3();
        Test4();
        Test5();
        Test6();
        Test7();
        Test8();
        //Test9();
        Test10();
    }

    [Test]
    public void Test1()
    {
        RationalNumber Positives = new RationalNumber(12,6);
        Debug.Assert(Positives.Equals(new RationalNumber(2,1)));
    }
    public void Test2()
    {
        RationalNumber negativeDenominator = new RationalNumber(12,-6);
        Debug.Assert(negativeDenominator.Equals(new RationalNumber(2,-1)));
    }
    public void Test3()
    {
        RationalNumber negativeNumerator = new RationalNumber(-12,6);
        Debug.Assert(negativeNumerator.Equals(new RationalNumber(-2,1)));
    }
    public void Test4()
    {
        RationalNumber Negatives = new RationalNumber(-12,-6);
        Debug.Assert(Negatives.Equals(new RationalNumber(2,1)));
    }
    public void Test5()
    {
        RationalNumber simplify = new RationalNumber(25,10);
        Debug.Assert(simplify.Equals(new RationalNumber(5,2)));
    }

    public void Test6()
    {
        RationalNumber notSimplify = new RationalNumber(25,3);
        Debug.Assert(!notSimplify.Equals(new RationalNumber(5,2)));
    }
    public void Test7()
    {
        Debug.Assert(new RationalNumber(20,10).Equals(new RationalNumber(4,2)));
    }

    public void Test8()
    {
        MixedNumber CanBeSimplified = new MixedNumber(3, 2);
        Debug.Assert(!CanBeSimplified.Equals(new RationalNumber(3,2)));
    }

    public void Test9()
    {
        MixedNumber canNotBeSimplified = new MixedNumber(1,2);
        Console.WriteLine(canNotBeSimplified.GetHashCode());
        Debug.Assert(canNotBeSimplified.Equals(new RationalNumber(1,2)));
        Console.WriteLine(new RationalNumber(1,2).GetHashCode());
    }

    public void Test10()
    {
        Debug.Assert(new MixedNumber(125,50).Equals(new MixedNumber(5,2)));
    }
}
