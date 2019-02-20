using System;

namespace dockerapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(new { Result = "Ok" }));
        }
    }
}
