//OOP: 
// classes
// inheritance 
// polymorphisim: override:same name same parameter but different function, overload:same function different data type or parameters name 
// incapsulation example: class
// Abstraction 


using System.Diagnostics.Metrics;
using inClassExercise26122024.Models;
Product prdx = new Product();
#region decleration
string NAME;
double PRICE;
int QTY;
int pCount;
bool stock=false;
int counter=0;
//int countIn=0;
//int countOut=0;
#endregion

#region action
Console.WriteLine("enter how many products you have: ");
pCount = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= pCount; i++)
{
    Console.WriteLine("enter the name of the product ");
    NAME = Console.ReadLine();
    //Console.WriteLine(prdx.functions(NAME));
    Console.WriteLine("enter the price of the product ");
    PRICE = Convert.ToDouble(Console.ReadLine());
    //Console.WriteLine(prdx.functions(NAME, PRICE));
    Console.WriteLine("enter the quantity of the product:");
    QTY = Convert.ToInt32(Console.ReadLine());
    /*if i want to ask about each item 
    Console.WriteLine(prdx.functions(NAME, PRICE, QTY));
    for (int j = 1; j <= QTY; j++)
    {
        Console.WriteLine("enter availability for the product"+j+" please:");
        stock = Convert.ToBoolean(Console.ReadLine());
        prdx.AddProducts(NAME, PRICE, QTY, stock, counter);
        //prdx.AddProducts(NAME, PRICE, QTY, stock, countIn, countOut);//VOID SO WE CAN NOT PUT IT IN WRITE LINE  //inside the loop
    }*/
    Console.WriteLine("enter availability of the products please:");
    stock = Convert.ToBoolean(Console.ReadLine());
    prdx.AddProducts(NAME, PRICE, QTY, stock, counter);
}
Console.WriteLine(prdx.GetProducts());
#endregion