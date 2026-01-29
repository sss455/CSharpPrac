using System.Runtime.Serialization;

namespace SelfCSharp.Chap09
{
    internal class MyAppException : Exception
    {
        public MyAppException()
        {
        }

        public MyAppException(string message) : base(message)
        {
        }

        public MyAppException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public MyAppException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }

    internal class MyAppExceptionClient
    {
        static void Main(string[] args)
        {
            throw new MyAppException("例外発生！");
        }
    }
}
