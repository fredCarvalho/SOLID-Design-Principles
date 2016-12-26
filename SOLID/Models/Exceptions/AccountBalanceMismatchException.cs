using System;
using System.Runtime.Serialization;

namespace SOLID.Models.Exceptions
{
    internal class AccountBalanceMismatchException : Exception
    {
        public AccountBalanceMismatchException()
        {
        }
    }
}