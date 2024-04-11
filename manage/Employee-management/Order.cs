using System;

public class Order
{
    private List<Product> outgoingProducts = new List<Product>();
    private List<Product> incoming = new List<Product>();
    
    public void AddProduct(Product product)
    {
        outgoingProducts.Add(product);
    }

    public void IncomingProduct(Product product)
    {
        incoming.Add(product);
    }    
}