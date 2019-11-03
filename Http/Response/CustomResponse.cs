using Newtonsoft.Json;

namespace Advisor.Http.Response
{
    public class CustomResponse
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        [JsonProperty(PropertyName = "status_code")]
        public int StatusCode { get; set; }

        public CustomResponse(string message, int statusCode)
        {
            Message = message;
            StatusCode = statusCode;
        }
    }
}
