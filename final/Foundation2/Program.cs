using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating Objects
        Address address1 = new Address("456 Oak Avenue", "Springfield", "Illinois", "USA");
        Address address2 = new Address("789 Maple Street", "Toronto", "Ontario", "Canada");

        Product product1 = new Product("All-Purpose Cleaner", "APC001", (float)9.99, 50);
        Product product2 = new Product("Bath Towel Set", "BTS002", (float)24.99, 30);
        Product product3 = new Product("Organic Hand Soap", "OHS003", (float)5.95, 15);
        Product product4 = new Product("Wireless Earbuds", "WEB004", (float)44.99, 10);
        Product product5 = new Product("Steel Cookware Set", "SCS005", (float)65.49, 5);
        Product product6 = new Product("Portable Power Bank", "PPB006", (float)34.99, 20);

        Customer customer1 = new Customer("John Reilley", address1);
        Customer customer2 = new Customer("Yves Laurent", address2);

        List<Product> productList1 = new List<Product>(){product1, product2, product3};
        List<Product> productList2 = new List<Product>(){product4, product5, product6};

        Order order1 = new Order(productList1, customer1);
        Order order2 = new Order(productList2, customer2);

        // Displaying total price, packing labels, shipping labels
        order1.DisplayAll();
        order2.DisplayAll();



    }
}