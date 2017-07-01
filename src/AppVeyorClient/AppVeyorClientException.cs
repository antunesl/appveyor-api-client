using System;

namespace AppVeyorClient
{
    [Serializable]
    public class AppVeyorClientException : Exception
    {
        public AppVeyorClientException() { }
        public AppVeyorClientException(string message) : base(message) { }
        public AppVeyorClientException(string message, System.Exception inner) : base(message, inner) { }
    }
}
