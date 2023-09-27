using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitTestDemo
{
    public class ProgramTest
    {

        [Fact]
        public void ErMyndig()
        {
            Assert.True(Program.ErMyndig(18));
            Assert.True(Program.ErMyndig(19));
            Assert.False(Program.ErMyndig(17));
        }

        [Fact]
        public void FindAlder()
        {
            Assert.Equal(28, Program.FindAlder(1995, true));
            Assert.Equal(27, Program.FindAlder(1995, false));
            Assert.Equal(27, Program.FindAlder(1995));
            Assert.Equal(-1, Program.FindAlder(2030));
            Assert.Equal(0, Program.FindAlder(2023));
        }

        [Theory]
        [InlineData("Said", "Hej Said")]
        [InlineData("  Said  ", "Hej Said")]
        [InlineData("", "Hej med dig")]
        [InlineData("  ", "Hej med dig")]
        [InlineData(".", "Hej .")]
        public void Hilsen(string navn, string forventet)
        {
            Assert.Equal(forventet, Program.Hilsen(navn));
        }
    }
}
