namespace Fiorello.Models
{
    public class ProductImage : BaseEntity
    {
        public string ImageURL { get; set; }
    

        //relational
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
