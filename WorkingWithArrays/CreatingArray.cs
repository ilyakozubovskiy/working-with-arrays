﻿using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return Array.Empty<int>();
        }

        public static bool[] CreateEmptyArrayOfBooleans()
        {
            return Array.Empty<bool>();
        }

        public static string[] CreateEmptyArrayOfStrings()
        {
            return Array.Empty<string>();
        }

        public static char[] CreateEmptyArrayOfCharacters()
        {
            return Array.Empty<char>();
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            int[] res = new int[10];
            return res;
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            bool[] res = new bool[20];
            return res;
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            string[] res = new string[5];
            return res;
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            char[] res = new char[15];
            return res;
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            double[] res = new double[18];
            return res;
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
           float[] res = new float[100];
           return res;
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            decimal[] res = new decimal[1000];
            return res;
        }

        public static int[] CreateIntArrayWithOneElement()
        {
          return new[] { 123456 };
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            return new[] { 1111111, 9999999 };
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            return new[] { 0, 4234, 3845, 2942, 1104, 9794, 923943, 7537, 4162, 10134 };
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            return new[] { true };
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            return new[] { true, false, true, false, true };
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            return new[] { false, true, true, false, true, true, false };
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            return new[] { "one" };
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            return new[] { "one", "two", "three" };
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            return new[] { "one", "two", "three", "four", "five", "six" };
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            return new[] { 'a' };
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            return new[] { 'a', 'b', 'c' };
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            return new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            return new[] { 1.12 };
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            return new[] { 1.12, 2.23, 3.34, 4.45, 5.56 };
        }

        public static double[] CreateDoubleWithNineElements()
        {
            return new[] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            return new[] { 123456789.123456f };
        }

        public static float[] CreateFloatWithThreeElements()
        {
            return new[] { 1000000.123456f, 2223334444.123456f, 9999.999999f };
        }

        public static float[] CreateFloatWithFiveElements()
        {
            return new[] { 1.0123f, 20.012345f, 300.01234567f, 4000.01234567f, 500000.01234567f };
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            return new[] { 10000.123456m };
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            return new[] { 1000.1234m, 100000.2345m, 100000.3456m, 1000000.456789m, 10000000.5678901m };
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
           return new[] { 10.122112m, 200.233223m, 3000.344334m, 40000.455445m, 500000.566556m, 6000000.677667m, 70000000.788778m, 800000000.899889m, 9000000000.911991m };
        }
    }
}
