using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MallSdk
{
    [Serializable]
    public class MallResponse
    {
         public ResponseStatus ResponseStatus { get; set; }
         public MallResponse()
         {
             ResponseStatus = new ResponseStatus("0");
         }

         /// <summary>
         /// 是否成功
         /// </summary>
         public bool IsSuccess
         {
             get { return ResponseStatus.ErrorCode == "0"; }
         }
    }
    public class ResponseStatus
    {
        // 摘要: 
        //     Initializes a new instance of the ServiceStack.ResponseStatus class.  A response
        //     status without an errorcode == success
        public ResponseStatus() { }
        //
        // 摘要: 
        //     Initializes a new instance of the ServiceStack.ResponseStatus class.  A response
        //     status with an errorcode == failure
        public ResponseStatus(string errorCode) {
            this.ErrorCode = errorCode;
        }
        //
        // 摘要: 
        //     Initializes a new instance of the ServiceStack.ResponseStatus class.  A response
        //     status with an errorcode == failure
        public ResponseStatus(string errorCode, string message) 
        {
            this.ErrorCode = errorCode;
            this.Message = message;
        }

        // 摘要: 
        //     Holds the custom ErrorCode enum if provided in ValidationException otherwise
        //     will hold the name of the Exception type, e.g. typeof(Exception).Name A value
        //     of non-null means the service encountered an error while processing the request.
        public string ErrorCode { get; set; }
        //
        // 摘要: 
        //     For multiple detailed validation errors.  Can hold a specific error message
        //     for each named field.
        public List<ResponseError> Errors { get; set; }
        //
        // 摘要: 
        //     A human friendly error message
        public string Message { get; set; }
        //
        public string StackTrace { get; set; }
    }
    public class ResponseError
    {
        public ResponseError() { }

        public string ErrorCode { get; set; }
        public string FieldName { get; set; }
        public string Message { get; set; }
    }
}
