using System;

namespace ValidateUrl
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {

            Console.WriteLine(await Validate.IsValidUriAsync(new Uri("chalmers.se")));
        }
    }
}
