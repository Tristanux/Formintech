using FluentAssertions;
using Formintech.Model;
using System;
using Xunit;

namespace Formintech.Tests
{
    public class FormTests
    {
        [Fact]
        public void CreateForm()
        {
            Form form = new Form("myForm");

            form.Name.Should().Be("myForm");
        }
    }
}
