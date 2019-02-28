using System;
using System.Net;

namespace MobileProject
{
    public sealed class HttpResponse<T>
    {
        private readonly bool deserializationFailed;

        public HttpResponse(HttpStatusCode? statusCode, T content)
        {
            this.StatusCode = statusCode;
            this.Content = content;
        }

        public HttpResponse(HttpStatusCode? statusCode, T content, Exception exception, string rawData, bool deserializationFailed)
        {
            this.StatusCode = statusCode;
            this.Content = content;
            this.Exception = exception;
            this.RawData = rawData;
            this.deserializationFailed = deserializationFailed;
        }

        public T Content { get; private set; }

        public Exception Exception { get; private set; }

        public bool IsSuccessStatusCode
        {
            get
            {
                return this.StatusCode.HasValue && (int)this.StatusCode >= 200 && (int)this.StatusCode <= 299;
            }
        }

        public string RawData { get; private set; }

        public HttpStatusCode? StatusCode { get; private set; }

    }
}
