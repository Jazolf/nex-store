// See https://aka.ms/new-console-template for more information
using Store;

Console.WriteLine("Please Select The Operation:");
Console.WriteLine("1.Record");
Console.WriteLine("2.list");
Console.WriteLine("3.Edit");

try
{
    
    int operation = Convert.ToInt32(Console.ReadLine());
    int productId = 1;
    Details[] productMoreInfo = new Details[4];
    Record[] product = new Record[3];
    switch (operation)
    {
        case 1:
            {

                Console.WriteLine("Please Enter ProductName: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Please Enter ProductDescription: ");
                string productDescription = Console.ReadLine();
                Console.WriteLine("Please Enter ProductPrice: ");
                string productPrice = Console.ReadLine();
                Console.WriteLine("Please Enter ProductDetail: ");
                string productDetail = Console.ReadLine();
                Details p1 = new Details(productName, productDescription, productPrice,productDetail);
                Record p2 = new Record(productName, productDescription, productPrice);
                productMoreInfo[productId] = p1;
                product[productId] = p2;
                break;
            }

        case 2:
            {
               
                Console.WriteLine("Products List:");
                for (int i = 0; i < productId; i++)
                {
                    Console.WriteLine($"Product[{(i + 1)}]. {product[(i + 1)]}");
                }
                break;
            }
        case 3:
            {
                Console.WriteLine("Do You Have Intention The Product Information? (Yes/No)");
                string res = Console.ReadLine();
                res.ToUpper();
                if (res == "Yes")
                {
                    goto case 1;
                }
                else if(res == "No")
                {
                    Console.WriteLine("Products List With Detail:");
                    for (int j = 0; j < productId; j++)
                    {
                        Console.WriteLine($"Product[{(j + 1)}]:{productMoreInfo[(j + 1)]}");
                    }
                }
                break;
            }
        default:
            {
                Console.WriteLine("Select Just 1/2/3 ....");
                break;
            }

    }
    productId += 1;
    Console.ReadKey();
}

catch (Exception ex)
{
    Console.WriteLine("App Stope!");
}
finally
{
    Console.WriteLine("End Of Stor List.");
}



