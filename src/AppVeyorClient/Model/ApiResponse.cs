using System.Collections.Generic;

namespace AppVeyorClient.Model
{
    public class ApiResponse
    {
        private List<int> SuccessCodes => new List<int> { 200, 201, 202, 203, 204, 205, 206, 207, 208, 226 };
        
        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        public int StatusCode { get; private set; }

        public bool Succeeded => !Timeout && SuccessCodes.Contains(StatusCode);

        public bool Timeout { get; set; }



        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse&lt;T&gt;" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        public ApiResponse(int statusCode)
        {
            this.StatusCode = statusCode;
        }

    }

    public class ApiResponse<T> : ApiResponse
    {
        /// <summary>
        /// Gets or sets the data (parsed HTTP body)
        /// </summary>
        /// <value>The data.</value>
        public T Data { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse&lt;T&gt;" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        public ApiResponse(int statusCode, T data) : base(statusCode)
        {
            this.Data = data;
        }

    }
}
