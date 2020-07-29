using Condominium.Application.Common.Interfaces;
using System;

namespace Condominium.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}