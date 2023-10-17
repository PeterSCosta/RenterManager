using RenterManager.Application.Interfaces.Services;
using System;

namespace RenterManager.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}