namespace WebFrontToBack.Models;

public class Category
{
    public Category()
    {
        Services=new List<Service>();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsDeleted { get; set; } //Bazani silmemeliyem chunki ilin axiri shirket menden hemin bazanin hesabatini isteyecek.
    public List<Service> Services { get; set;}

}
