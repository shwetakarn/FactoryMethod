namespace FactoryMethod
{
    public class SalesTVConcreteCreator : Creator
    {
        public override LGProduct LGRequest()
        {
           //TV need to instantiate manually due to absence of IOC/Unity container
           TVConcreteProduct Plasma = new TVConcreteProduct();
           Plasma.ProductExpiry = 4;
           return Plasma;
        }
    }

     public class SalesMobileConcreteCreator : Creator
    {
        public override LGProduct LGRequest()
        {
           //Mobile need to instantiate
           MobileConcreteProduct Samsung = new MobileConcreteProduct();
           Samsung.ProductExpiry = 5;
           return Samsung;
        }
    }
}