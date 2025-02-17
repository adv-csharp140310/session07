namespace session06.Model;

public class Product: BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Discontinued { get; set; }
}
