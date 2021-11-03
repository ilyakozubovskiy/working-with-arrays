using System;

#pragma warning disable CA1062

namespace WorkingWithArrays
{
    public static class UsingRanges
    {
        public static int[] GetArrayWithAllElements(int[] array)
        {
            int[] res = new int[array.Length];
            array.CopyTo(res, 0);
            return res;
        }

        public static int[] GetArrayWithoutFirstElement(int[] array)
        {
            int[] res = new int[array.Length - 1];
            Array.Copy(array, 1, res, 0, res.Length);
            return res;
        }

        public static int[] GetArrayWithoutTwoFirstElements(int[] array)
        {
            int[] res = new int[array.Length - 2];
            Array.Copy(array, 2, res, 0, res.Length);
            return res;
        }

        public static int[] GetArrayWithoutThreeFirstElements(int[] array)
        {
            int[] res = new int[array.Length - 3];
            Array.Copy(array, 3, res, 0, res.Length);
            return res;
        }

        public static int[] GetArrayWithoutLastElement(int[] array)
        {
            int[] res = new int[array.Length - 1];
            Array.Copy(array, 0, res, 0, res.Length);
            return res;
        }

        public static int[] GetArrayWithoutTwoLastElements(int[] array)
        {
            int[] res = new int[array.Length - 2];
            Array.Copy(array, 0, res, 0, res.Length);
            return res;
        }

        public static int[] GetArrayWithoutThreeLastElements(int[] array)
        {
            int[] res = new int[array.Length - 3];
            Array.Copy(array, 0, res, 0, res.Length);
            return res;
        }

        public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
        {
            bool[] res = new bool[array.Length - 2];
            Array.Copy(array, 1, res, 0, res.Length);
            return res;
        }

        public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            bool[] res = new bool[array.Length - 4];
            Array.Copy(array, 2, res, 0, res.Length);
            return res;
        }

        public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            bool[] res = new bool[array.Length - 6];
            Array.Copy(array, 3, res, 0, res.Length);
            return res;
        }
    }
}
