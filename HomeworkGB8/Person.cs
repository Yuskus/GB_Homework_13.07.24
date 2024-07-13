using System.Text;
using System.Xml.Serialization;

namespace HomeworkGB8
{
    [XmlRoot]
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly Birthday { get; set; }
        public List<string>? Hobbies { get; set; }
        public List<Person>? Children { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Имя: {FirstName}");
            sb.Append(", ");
            sb.Append($"Фамилия: {LastName}");
            sb.Append(", ");
            sb.Append($"День рождения: {Birthday}");
            sb.Append(", ");
            sb.Append("[ Хобби: " + string.Join(", ", Hobbies ?? []) + " ]");
            sb.Append(", ");
            sb.Append("[ Дети: " + Children?.Count + " ]");
            sb.Append(". ");
            return sb.ToString();
        }
    }
}
