using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ExceptionUnitTest
{
    public class PersonTest
    {


        [Fact]
        public void Age_is_invalid()
        {
            Assert.Throws<ArgumentException>(() => new Person("Said", 200));
            Assert.Throws<ArgumentException>(() => new Person("Said", -1));
        }

        [Fact]
        public void Age_is_valid()
        {
            var exception = Record.Exception(() => new Person("Said", 20));
            Assert.Null(exception);
        }



    }
}
