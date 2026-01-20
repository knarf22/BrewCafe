using BrewCafe.Services.Interfaces;

namespace BrewCafe.Services.Implementations
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => DateTime.Now;
    }
}
