using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace inClassExercise26122024.Models
{
    public class Product
    {   //NOT needed if you are  declaring functions BUT needed when declaring a list
        //public string name {get; set;}
        //public double price {get; set;}
        //public int QTY {get; set;}
        //public double total { get; set; }
   
        public string functions (string name)
        {
            return "Product Name is: " + name ;
        }
        public string functions (string name, double price)
        {
            return "Product Name is: " + name + ", price: " + price + " KD";
        }
        //public string functions (string name, double price, int QTY)
        //{
        //    calculation = price * QTY;

        //    return "Product: " + name + ", price: " + price + " KD " + "Quantity: " + QTY + " total " + calculation;
        //}
        public string functions(string name, double price, int QTY)
        {
           
            return "Product: " + name + ", price: " + price + " KD " + "Quantity: " + QTY + " total " + calctot(price,QTY);
        }
        public double calctot(double price, int QTY) 
        {
            return price * QTY;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public double Total { get; set; }
        public bool Stock { get; set; } // bool by defult is wrong
        public int Counter { get; set; }
      
        List<Product> productsList = new List<Product>(); //  "<" means off //object declaration from type product
                                                          // whatever list needs properties
        public void AddProducts(string name, double price, int qty, bool stock,  int counter)
        {
            productsList.Add(new Product { Name = name , Price = price, Qty = qty, Stock = stock, Counter = counter});
        }
        public string GetProducts()//get doesnt take parameters, why? because it takes the productList from the ste
        {
            int counter = 0;


            foreach (Product item in productsList) //we write var when we dont know what type of input itd be but here we know its priduct so its fine to write that
            {

                if (item.Stock == true)
                {
                    counter++;
                    //Console.WriteLine("Product " + item.Name + " price in KD " + item.Price +
                    //               " Quantity " + item.Qty + " total  " + calctot(item.Price, item.Qty)
                    //               + " In stock." + countIn);
                }
            }
            return " in stock " + counter + " out " + (productsList.Count - counter);

            /*my solution for asking about every item and quantity
            int countIn = 0;
            int countOut = 0;

            foreach (Product item in productsList) //we write var when we dont know what type of input itd be but here we know its priduct so its fine to write that
            {

                if (item.Stock==true)
                {
                    countIn ++;
                    //Console.WriteLine("Product " + item.Name + " price in KD " + item.Price +
                    //               " Quantity " + item.Qty + " total  " + calctot(item.Price, item.Qty)
                    //               + " In stock." + countIn);
                }
                else
                {
                    countOut++;
                    //Console.WriteLine("Product " + item.Name + " price in KD " + item.Price +
                    //                " Quantity " + item.Qty + " total  " + calctot(item.Price, item.Qty)
                    //                + " out of stock." + countOut);
                }
            }
            return "in stock" + countIn + " out "+ countOut;
            */
        }
    }
}
//product class
//3 funcs 
//each take different parameters from eaech other
//eg 1 name
//eg 2 name and price
//eg 3 name price quantaty print naem iphonw cost 300 qty 5 total
//if enter qty 3 name price and total (price*qty)
//print them 
// enter a loop to count multiple of produvts