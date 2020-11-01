using System;

namespace FactoryMethod
{
    public static class Customer
    {
        public static void Request()
        {
        string i = Console.ReadLine();
        LGProduct product;

        int expiry=0;
        switch (i)
        {
            case "1":
                SalesTVConcreteCreator concreteTV = new SalesTVConcreteCreator();
                product = concreteTV.LGRequest();
                expiry= product.ProductExpiry;
                Console.WriteLine(expiry);
                Console.ReadLine();
                break;
                
            case "2":
                SalesMobileConcreteCreator concretephone = new SalesMobileConcreteCreator();
                product = concretephone.LGRequest();
                expiry = product.ProductExpiry;
                Console.WriteLine(expiry);
                Console.ReadLine();
                break;
            default:
                break;
        }

        }
    }
}