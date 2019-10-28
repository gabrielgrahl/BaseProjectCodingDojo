using FluentAssertions;
using Xunit;

namespace BaseProjectCodingDojo
{
    public class DummyTests
    {
        private Dummy _dummy;

        public DummyTests()
        {
            _dummy = new Dummy();
        }


        [Fact]
        public void should_return_1()
        {
            var returnedInformation = _dummy.ReturnSomething();
            returnedInformation.Should().Be(1);
        }
    }
}
