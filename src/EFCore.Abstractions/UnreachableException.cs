namespace Microsoft.EntityFrameworkCore
{
    public sealed class UnreachableException : Exception
    {
        public UnreachableException(string message) : base(message)
        {
        }
    }
}