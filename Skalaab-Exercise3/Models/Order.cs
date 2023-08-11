namespace Skalaab_Exercise3.Models;
public class Order
{
    public void Checkout(IEnumerable<Product> products, Customer customer)
    {
        //If all products prices less than 10 we dont need to apply any discount
        if (products.All(x => x.Price < 10))
            return;

        // Check the customer is Premuim or not
        if(customer.IsPremium)
        {
            // Premuim customer
            products.Where(x => x.Price > 10).ToList().ForEach(item => item.ApplyDiscount(GetPremuimDiscountBasedOnProductPrice(item.Price)));
            return;
        }

        // Normal customer
        products.Where(x => x.Price > 10).ToList().ForEach(item => item.ApplyDiscount(GetDiscountBasedOnProductPrice(item.Price)));

    }

    private Discount GetPremuimDiscountBasedOnProductPrice(decimal productPrice)
    {
        if (productPrice > 100)
            return new Discount(0.1m);

        if (productPrice > 50 && productPrice <= 100)
            return new Discount(0.05m);

        if (productPrice > 10 && productPrice <= 50)
            return new Discount(0.02m);

        throw new ArgumentOutOfRangeException(nameof(productPrice));
    }

    private Discount GetDiscountBasedOnProductPrice(decimal productPrice)
    {
        if (productPrice > 100)
            return new Discount(0.05m);

        if (productPrice > 50 && productPrice <= 100)
            return new Discount(0.03m);

        if (productPrice > 10 && productPrice <= 50)
            return new Discount(0.01m);

        throw new ArgumentOutOfRangeException(nameof(productPrice));
    }


    /* More explain
     * it was possible tp create one method for getting the product discount and pass two params to the method (productPrice, isCustomerPremuim),
     * but when we will call the method inside foreach loop it's best to make the global check (is customer premuim) out of the loop in order to earn speed and performance
     */
}