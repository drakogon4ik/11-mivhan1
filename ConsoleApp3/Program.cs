using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 2, 3, 1 }, { 1,2,3}, { 3, 1, 2} };
            for(int i = 0;  i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                    Console.WriteLine(arr[i,j]);
            }
            Console.WriteLine(targil3(arr));
        }

        static public bool targil3(int[,] arr)
        {
            int n = 0;
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            for (int q = 0; q < arr.GetLength(0); q++)
            {
                for (int w = 0; w < arr.GetLength(0); w++)
                {
                    if (arr[q, 0] == arr[w, 0])
                        n++;
                    if (n > 1)
                        return false;
                    n = 0;
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = 0;
            }
            for (int j = 0; j < arr2.Length; j++)
            {
                arr2[j] = 0;
            }
            for (int k=0; k< arr1.Length; k++)
            {
                arr1[k] = arr[0, k];

            }
            for (int t = 0; t < arr2.Length; t++)
            {
                for (int l = 0; l < arr1.Length; l++)
                {
                    if (arr[1, l] == arr1[l])
                        return false;
                }
                arr2[t] = arr[1, t];
            }
            for (int p = 0; p < arr1.Length; p++)
            {
                if ((arr[2, p] == arr1[p]) || (arr[2, p] == arr2[p]))
                    return false;
            }
            return true;
        }
    }
    class Test
    {
        private int sugar;
        private int pulse;
        private int saturation;
        public Test(int sugar, int pulse, int saturation)
        {
            this.sugar = sugar;
            this.pulse = pulse;
            this.saturation = saturation;
        }
        public int GetSugar()
        {
            return sugar;
        }
        public int GetPulse()
        {
            return pulse;
        }
        public int GetSaturation()
        {
            return saturation;
        }
        public void SetSugar(int sugar)
        {
            this.sugar = sugar;
        }
        public void SetPulse(int pulse)
        {
            this.pulse = pulse;
        }
        public void SetSaturation(int saturation)
        {
            this.saturation = saturation;
        }
    }
    class Patient
    {
        private Test[] tests;
        private string name;
        public Patient(string name)
        {
            this.name = name;
            tests = new Test[24];
        }
        public bool HadLifeThreatening()
        {
            for(int i = 0; i < tests.Length; i++)
            {
                if ((tests[i].GetSugar() == 0) && (tests[i].GetPulse() == 0) && (tests[i].GetSaturation() == 0))
                    break;
                if ((tests[i].GetSugar() < 50) || (tests[i].GetPulse() < 40) || (tests[i].GetPulse() > 120) || (tests[i].GetSaturation() < 93))
                    return true;
            }
            return false;
        }
        public int GetNumOfUnfunctional()
        {
            int n = 0;
            for (int i = 0; i < tests.Length; i++)
            {
                if ((tests[i].GetSugar() == 0) && (tests[i].GetPulse() == 0) && (tests[i].GetSaturation() == 0))
                    n++;
            }
            return n;
        }
    }
}
