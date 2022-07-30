

namespace Store
{
    public class Details:Record
    {
        public string ProductDetail { get; set; }
        public Details() { }
        public Details(string productName,string productDescription,string productPrice,string productDetail)
        {
            ProductDetail = productDetail;
        }
        
    }
}
