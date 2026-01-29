using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap09
{
    internal class MyAppException : Exception
    {
        public MyAppException() { }

        public MyAppException(string message) : base(message) { }

        public MyAppException(string message, Exception innerException) : base(message, innerException) { }

        public MyAppException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
