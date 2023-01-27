namespace MyStartApi.Basic
{
  public class Product
  {
    private string _name = null!;
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    }

    public string Description { get; set; } = null!;
    public DateTime  CreatedAt { get; set; }
  }
}