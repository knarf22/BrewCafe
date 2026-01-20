using BrewCafe.Services.Interfaces;

namespace BrewCafe.Services.Implementations
{
    public class CoffeeCounter : ICoffeeCounter
    {
        private static int _counter = 0;

        public bool IsOutOfCoffee()
        {
            _counter++;
            return _counter % 5 == 0;
        }
    }
}
