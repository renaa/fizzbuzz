using System;
using System.Collections.Generic;

namespace FizzBuzz.Library
{
    public interface IFizzBuzzService
    {
        IEnumerable<string> GetFizzBuzz(int v);
    }
}
