using Newtonsoft.Json;
using System;

namespace JsonPropertyAttribute_name
{
    class Program
    {
        static void Main(string[] args)
        {

            //Serialize
            //https://www.newtonsoft.com/json/help/html/jsonpropertyname.htm

            Videogame starcraft = new Videogame
            {
                Name = "Starcraft",
                ReleaseDate = new DateTime(1998, 1, 1)
            };

            string jsonSerialize = JsonConvert.SerializeObject(starcraft, Formatting.Indented);
            Console.WriteLine("Serialize");
            Console.WriteLine(jsonSerialize);

            Console.WriteLine("--------------------------------------------------------");

            //--------------------------------------------------------------------

            //Deserialize
            //https://www.newtonsoft.com/json/help/html/DeserializeObject.htm
            
            string jsonDeserialize = @"{
                            'Email': 'james@example.com',
                            'Active': true,
                            'CreatedDate': '2022-04-11T00:00:00Z',
                            'Roles': [
                            'User',
                            'Admin'
                                     ]
                            }";

            Account account = JsonConvert.DeserializeObject<Account>(jsonDeserialize);

            Console.WriteLine("Deserialize");
            Console.WriteLine(account.Email + ", " + account.CreatedDate);
        }
    }
}
