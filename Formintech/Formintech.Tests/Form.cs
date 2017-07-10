using FluentAssertions;
using System;
using Xunit;

namespace Formintech.Tests
{
    public class Form
    {
        [Fact]
        public void Test1()
        {
            int i = 5;
            i.Should().Be(5);
        }
    }
}
