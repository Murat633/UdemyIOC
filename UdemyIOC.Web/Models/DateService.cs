
namespace UdemyIOC.Web.Models
{
    public class DateService : IDateService, ISingletonDateService, IScopedDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;
            _logger.LogWarning( "Date Service Constructor'ına girdi");
        }

        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
