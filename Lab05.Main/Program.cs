using lab05;
using System.Diagnostics;

MixedNumber canNotBeSimplified = new MixedNumber(1,2);
Console.WriteLine(canNotBeSimplified.GetHashCode());
Console.WriteLine(new MixedNumber(2,3).GetHashCode());
//Debug.Assert(new RationalNumber(1,2).Equals(new RationalNumber(1,2)));
Debug.Assert(canNotBeSimplified.Equals(new MixedNumber(2,3)));
