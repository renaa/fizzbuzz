﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Library
{
    public class FizzBuzzService : IFizzBuzzService
    {
        const int FIZZDIGIT = 3;
        const int BUZZDIGIT = 5;

        IEnumerable<string> IFizzBuzzService.GetFizzBuzz(int length)
        {
            return GetFizzBuzzWithLinq(1, length);
        }

        private bool correctFizzBuzzInputParameters(int low, int high, int fizzDigit, int buzzDigit)
        {
            if (low > 0 && low < high && fizzDigit > 0 &&  buzzDigit > 0)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<string> GetFizzBuzz(int start, int stop, int fizzDigit = FIZZDIGIT, int buzzDigit = BUZZDIGIT)
        {
            if (!correctFizzBuzzInputParameters(start, stop, fizzDigit, buzzDigit))
            {
                return new List<string>();
            }
            var results = new List<string>();
            var s = "";
            for (var i = start; i <= stop; i++)
            {
                if (i % fizzDigit == 0)
                {
                    s += "Fizz";
                }
                if (i % buzzDigit == 0)
                {
                    s += "Buzz";
                }
                if (s.Length == 0)
                {
                    s = i.ToString();
                }
                results.Add(s);
                s = "";

            }
            return results;
        }

        public IEnumerable<string> GetFizzBuzzWithLinq(int start, int stop, int fizzDigit = FIZZDIGIT, int buzzDigit = BUZZDIGIT)
        {
            if (!correctFizzBuzzInputParameters(start, stop, fizzDigit, buzzDigit))
            {
                return new List<string>();
            }
            var result = new List<string>();
            Enumerable.Range(start, stop).ToList().ForEach(x =>
            {
                string fizz = x % fizzDigit == 0 ? "Fizz" : "";
                string buzz = x % buzzDigit == 0 ? "Buzz" : "";
                string number = x % 3 != 0 & x % 5 != 0 ? x.ToString() : "";
                result.Add($"{fizz}{buzz}{number}");
            });
            return result;
        }
    }
}
