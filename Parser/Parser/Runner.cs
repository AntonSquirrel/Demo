using Newtonsoft.Json;
using Parser.Model;
using System;

namespace Parser
{
    class Runner
    {
        static void Main(string[] args)
        {
            var htppContext = new HttpContext(HttpConfig.Uri);
            var entityUser =   htppContext.GetUserById("2");

            Users user = JsonConvert.DeserializeObject<Users>(entityUser);
            Console.WriteLine("Hello! " + user.data.first_name);

            Console.ReadKey();
        }
    }
}
