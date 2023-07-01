using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Generics.Generic_Constraints
{
    public class DiscountCalculator<TProduct> where TProduct : Product
        // Constraint to a class
        //we are saying they TProduct should be of type product or any of its subclasses
    {
        public float calculateDiscount(TProduct product)
        {
            //because of the constraint we are ablt to access product.Title otherwise TProduct will be ob Object type
            return product.Price;
        }
    }
}
