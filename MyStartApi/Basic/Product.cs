namespace MyStartApi.Basic
{
  public class Product
  {
    // TODO essa é uma forma antiga de se fazer
    private string _name = null!;
    public string Name
    {
      get
      {
        if (string.IsNullOrEmpty(_name)) {
          System.Console.WriteLine("Deu ruim...");
          throw new Exception("Error empty name property...");
        }
        
        return _name;
      }
      set
      {
        _name = value;
      }
    }

    // TODO essa é a forma mais atual de se fazer
    public string Description { get; set; } = null!;
    public DateTime  CreatedAt { get; set; }
  }
}