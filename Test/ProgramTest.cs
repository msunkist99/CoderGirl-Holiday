using Holiday;
using System;
using Xunit;

namespace Test
{
    public class ProgramTest
    {
        [Fact]
        public void DayReturning_ReturnValue()
        {
            Assert.Equal("Tuesday", Program.DayReturning(DateTime.Today, (((int)DayOfWeek.Monday - (int)DateTime.Today.DayOfWeek + 7) % 7) + 1));
        }
    }
}
