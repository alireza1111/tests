using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ValidateUrl.model
{
    public class StatusCode
    {
        public bool IsValid { get; set; }
        public HttpStatusCode Message { get; set; }
    }
}
