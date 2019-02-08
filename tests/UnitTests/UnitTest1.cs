using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            bool expected = false
            var age = 14
         bool actual =  checkAge(age)
         Assert.Equal(expected,actual);
        }
    

    bool checkAge(int age)
    {
      if(age > 18)
      {
          return true
      }
      else
      {
          return false
      }
    }

    }
}
