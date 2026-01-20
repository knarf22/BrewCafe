using BrewCafe.Services.Interfaces;

namespace BrewCafe.Services.Implementations
{
    public class DateTimeProvider : IDateTimeProvider
    {
        //public DateTime Now => new DateTime(2026, 4, 1);

        public DateTime Now => DateTime.Now;
    }
}
