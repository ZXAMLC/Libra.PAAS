using System;

using Xunit;

namespace Libra.PAAS.Test
{
    public class JobTest
    {
        [Fact]
        public void JobSayTest()
        {
            var result = new Job().Say();

            Assert.Equal("Hello", result);
        }
    }
}
