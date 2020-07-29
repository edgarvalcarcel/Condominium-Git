using Condominium.Application.Common.Interfaces;
using System;

namespace Condominium.WebUI.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}