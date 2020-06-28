using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace httpRequest_cSharp
{
    class Program
    {
        HttpClient client = new HttpClient();
        
        static async Task Main(string[] args)
        {
            Program program = new Program();

            await program.GetTodoItems();

        }

        private async Task GetTodoItems()
        {
            string responce = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos");


            Console.WriteLine(responce);
        }

    }
}
