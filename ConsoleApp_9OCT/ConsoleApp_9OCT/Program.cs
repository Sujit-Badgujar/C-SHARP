class Sample 
{
    static void Main()
    {
        //object creation
        product p1= new product();
        product p2= new product();
        product p3= new product();

        //initialising
        p1.productName = "Keyboard";
        p1.proID = 1010;
        p1.productCost = 1000;
        p1.productQty = 15;

        p2.productName = "Mouse";
        p2.proID = 1020;
        p2.productCost = 1000;
        p2.productQty = 15;

        p1.productName = "Laptop";
        p1.proID = 1030;
        p1.productCost = 31000;
        p1.productQty = 15;

        System.Console.Out.WriteLine("Product-1");
        System.Console.Out.WriteLine("Product ID "+p1.proID);
        System.Console.Out.WriteLine("Product Name : "+p1.productName);
        System.Console.Out.WriteLine("Product Cost : "+p1.productCost);
        System.Console.Out.WriteLine("Product QTY : "+p1.productQty);

        System.Console.ReadKey();
    //    System.Console.Out.WriteLine();
    //    System.Console.Out.WriteLine();
    //    System.Console.Out.WriteLine();
    //    System.Console.Out.WriteLine();
    //    System.Console.Out.WriteLine();
    //    System.Console.Out.WriteLine();
    }

}