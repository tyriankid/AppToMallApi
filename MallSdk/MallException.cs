using System;
using System.Runtime.Serialization;

namespace MallSdk
{
    /// <summary>
    /// Mall客户端异常。
    /// </summary>
    public class MallException : Exception
    {
        private string errorCode;
        private string errorMsg;

        public MallException()
            : base()
        {
        }

        public MallException(string message)
            : base(message)
        {
        }

        protected MallException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public MallException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public MallException(string errorCode, string errorMsg)
            : base(errorCode + ":" + errorMsg)
        {
            this.errorCode = errorCode;
            this.errorMsg = errorMsg;
        }

        public string ErrorCode
        {
            get { return this.errorCode; }
        }

        public string ErrorMsg
        {
            get { return this.errorMsg; }
        }
    }
}
