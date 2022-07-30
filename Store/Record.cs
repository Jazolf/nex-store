
namespace Store
{
    public class Record
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        
        
        public Record() { }
        public Record(string productName, string productDescription, string productPrice)

        {
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
        }
       
    }
}
