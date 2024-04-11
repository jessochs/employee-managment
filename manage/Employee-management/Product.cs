using System;


public class Product
{
    private string _productName;
    private string _productId;
    private int _quantity;
    private string _eta;
    private Product(){}

    public Product(string productName, string productId, int quantity, string eta)
    {
        _productName = productName;
        _productId = productId;
        _quantity = quantity;
        _eta = eta;
    }  

    public string ProductName{get{return _productName;}}
    public string ProductId{get{return _productId;}}
    public int Quantity{get{return _quantity;}}
    public string Eta{get{return _eta;}}

     

    public void AddProduct()
    {
        Console.WriteLine(_productName);
        Console.WriteLine(_productId);
        Console.WriteLine(_quantity);
        Console.WriteLine(_eta);

    }

    public void IncomingProduct()
    {
        Console.WriteLine(_productName);
        Console.WriteLine(_productId);
        Console.WriteLine(_quantity);
        Console.WriteLine(_eta);
    }
    
}