using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const double Country_ShippingCost = 5.0;
    private const double International_ShippingCost = 35.0;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;

        foreach (var product in products)
        {
            total += product.TotalCost();
        }

        double shippingCost = customer.LivesInSomewhere() ? Country_ShippingCost : International_ShippingCost;
        total += shippingCost;

        return total;
    }

    public string GetPackingLabel()
    {
        var packingLabel = "Packing Label:\n";
        foreach (var product in products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        var shippingLabel = $"Shipping Label:\n{customer.Name}\n{customer.Address.GetFullAddress()}";
        return shippingLabel;
    }
}
