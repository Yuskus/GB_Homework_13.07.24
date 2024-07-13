using System.Xml.Serialization;
using System.Text.Json;

namespace HomeworkGB8
{
    internal class Program
    {
        const string jsonExample = """
            {
              "FirstName": "Julia",
              "LastName": "Vinogradova",
              "Birthday": "1995-01-22",
              "Hobbies": [
                "Painting",
                "Music",
                "Reading",
                "Brewing",
                "CSharp"
              ],
              "Children": [
                {
                  "FirstName": "Maxim",
                  "LastName": "Erashov",
                  "Birthday": "2021-04-07",
                  "Hobbies": [
                    "Music",
                    "Whims",
                    "Eating delicious",
                    "Playing phone games"
                  ],
                  "Children": []
                }
              ]
            }
            """;
        static void Main()
        {
            Console.WriteLine("Так выгдядит наш json: \n");
            Console.WriteLine(jsonExample + "\n");

            Console.WriteLine("Это экземпляр класса, десериализованный из json: \n");
            Person? someJsonPerson = JsonSerializer.Deserialize<Person>(jsonExample);
            Console.WriteLine(someJsonPerson + "\n");

            Console.WriteLine("Конвертируем json в xml: \n");
            new XmlSerializer(typeof(Person)).Serialize(Console.Out, someJsonPerson);

            Console.ReadKey(true);
        }
    }
}
