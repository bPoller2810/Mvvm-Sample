using System.Collections.Generic;
using System.Threading.Tasks;

namespace BasicMvvm
{
    public class ApiClient
    {

        public async Task<Dictionary<string,string>> GetItemsAsync()
        {
            await Task.Delay(1000); //this just simulates things going on in the background
            return new Dictionary<string, string>
            {
                {"Title 1", "Hello World" },
                {"In", "I am not visible" },
            };
        }


    }
}
