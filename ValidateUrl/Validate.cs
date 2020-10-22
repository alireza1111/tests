using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ValidateUrl.model;

namespace ValidateUrl
{
    public static class Validate
    {
        private static StatusCode StatusCode { get; set; }
        private static readonly HttpClient Client = new HttpClient();
        public static async Task<object> IsValidUriAsync(Uri uri)
        {
            //using HttpClient Client = new HttpClient();
            StatusCode = new StatusCode { IsValid = false };
            try
            {

                HttpResponseMessage result = Task.Run( () => Client.GetAsync(uri)).Result;
                 StatusCode.Message = result.StatusCode;
            }
            catch (AggregateException ae)
            {
                foreach (var e in ae.InnerExceptions)
                {
                    // Handle the custom exception.
                    /*                    if (e is CustomException)
                                        {*/
                    
                    if (e.Message.Contains("No such host is known"))
                    {
                        StatusCode.Message = HttpStatusCode.NotFound;
                        return StatusCode;
                    }


                    // }
                        /*                    // Rethrow any other exception.
                                            else
                                            {
                                                throw;
                                            }*/
                }
                return "vaa?!";

                /*            return StatusCode switch
                            {
                                HttpStatusCode.Accepted => true,
                                HttpStatusCode.OK => true,
                                _ => false,
                            };*/
            }
            StatusCode.IsValid = true;
            return StatusCode;
        }
    }   
}
