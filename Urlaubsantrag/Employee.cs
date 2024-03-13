using System.Text.Json.Serialization;

namespace Urlaubsantrag
{
    public class Employee
    {
        [JsonConstructor]
        public Employee() { }
        public Employee( string firstName, string lastName) {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
        }
        public String Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }    
}