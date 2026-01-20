using BrewCafe.Services.Implementations;
using Xunit;

namespace BrewCafe.Tests.Unit
{
    public class CoffeeCounterTests
    {
        [Fact]
        public void EveryFifthCall_ReturnsOutOfCoffee()
        {
            var counter = new CoffeeCounter();

            for (int i = 0; i < 4; i++)
                Assert.False(counter.IsOutOfCoffee());

            Assert.True(counter.IsOutOfCoffee());
        }
    }
}
