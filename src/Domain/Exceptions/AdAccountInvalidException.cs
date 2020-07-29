using System;

namespace Condominium.Domain.Exceptions
{
    public class AdAccountInvalidException : Exception
    {
        public AdAccountInvalidException(string adAccount, Exception ex)
            : base($"AD Account \"{adAccount}\" is invalid.", ex)
        {
        }

        public AdAccountInvalidException()
        {
        }

        public AdAccountInvalidException(string message) : base(message)
        {
        }
    }
}