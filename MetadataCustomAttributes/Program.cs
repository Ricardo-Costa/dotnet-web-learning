using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MetadataCustomAttributes
{
  class Program
  {
    static void Main(string[] args)
    {
      var person = new Person();
      Console.WriteLine(JsonConvert.SerializeObject(person));

      var cache = new Dictionary<Type, IEnumerable<Attribute>>();

      // obj is some object
      var type = person.GetType();
      var attributes = type.GetCustomAttributes(true);
      //cache.Add(type, attributes);

      Console.WriteLine(attributes);


      foreach (var member in typeof(Person).GetMembers()) {
        Console.WriteLine(JsonConvert.SerializeObject(member.GetCustomAttributes(true)));
      }

      Console.WriteLine("------------------------------");
      foreach (var prop in person.GetType().GetProperties())
      {
        Console.WriteLine(JsonConvert.SerializeObject(
          prop.GetCustomAttributes(true).ToDictionary(a => a.GetType().Name, a => a)
        ));
        // Console.WriteLine(prop);
      }
      Console.WriteLine("------------------------------");

      foreach (var item in person.GetType().GetProperty("Name").GetCustomAttributesData())
      {
        Console.WriteLine(
          (item)
        );
      }

      Console.WriteLine("------------------------------");

      person.GetType().GetProperty("Name").SetValue(person, "Ricardo");
      Console.WriteLine(JsonConvert.SerializeObject(person));

      Console.WriteLine("------------------------------");

    }
  }

  class Person
  {
    [FieldName("NAME")]
    public string Name { get; set; }
  }
}