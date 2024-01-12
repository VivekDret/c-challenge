using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Entity;
using OrderManagement.DAO;

namespace OrderManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag = 1, ch;
            Boolean res;

            OrderProcessor orderProcessor = new OrderProcessor();

            Console.WriteLine("welcome to ecommerce---");

            do
            {
                Console.WriteLine("enter the operation--");
                Console.WriteLine("1.Create User.......");
                Console.WriteLine("2.Create Product.......");
                Console.WriteLine("3.Create Order.......");
                Console.WriteLine("4.Cancel Order.......");
                Console.WriteLine("5.get all products.......");
                Console.WriteLine("6.get order by user.......");

                Console.WriteLine("0.Exit........\n");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        try
                        {
                            User user = new User();

                            Console.Write("Enter user Name::");
                            user.UserName = Console.ReadLine();

                            Console.Write("Enter User password::");
                            user.Password = Console.ReadLine();

                            Console.Write("Enter User Role::");
                            user.Role = Console.ReadLine();

                            res = orderProcessor.CreateUser(user);
                            if (res)
                            {
                                Console.WriteLine("succefully inserted\n\n");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);

                        }

                        break;

                    case 2:

                        try
                        {
                            List<Product> list2 = new List<Product>();
                            Product product1 = new Product();
                            User user2 = new User();

                            Console.WriteLine("Enter user id");
                            user2.UserId = Convert.ToInt32(Console.ReadLine());
                            //checking user exist
                            bool ress = OrderProcessor.checkUserExist(user2.UserId);
                            if (ress)
                            {


                                Console.WriteLine("Enter product id");
                                product1.product_id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter quantity");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                list2.Add(product1);
                                res = orderProcessor.CreateOrder(user2, list2, quantity);
                                if (res)
                                {
                                    Console.WriteLine("succefully inserted\n\n");
                                };
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("\n");

                        }


                        break;


                    case 3:



                        try
                        {
                            User user1 = new User();
                            Product product = new Product();

                            Console.Write("Enter user id::");
                            user1.UserId = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Product name::");
                            product.ProductName = Console.ReadLine();

                            Console.Write("Enter Product description::");
                            product.Description = Console.ReadLine();

                            Console.Write("Enter Product price::");
                            product.Price = Convert.ToDecimal(Console.ReadLine());

                            Console.Write("Enter stock::");
                            product.quantityInStock = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Product type::");
                            product.Type = Console.ReadLine();

                            res = orderProcessor.CreateProduct(user1, product);
                            if (res)
                            {
                                Console.WriteLine("succefully inserted\n\n");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("\n");

                        }


                        break;
                    case 4:
                        try
                        {
                            Console.Write("Enter user ID::");
                            int userid = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter orderid ::");
                            int orderid = Convert.ToInt32(Console.ReadLine());


                            res = orderProcessor.CancelOrder(userid, orderid);
                            if (res)
                            {
                                Console.WriteLine("succefully deleted\n\n");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("\n");

                        }

                        break;


                    case 5:
                        try
                        {

                            List<Product> list1 = orderProcessor.GetAllProducts();
                            foreach (Product p in list1)
                            {
                                Console.WriteLine($"\nproductid={p.product_id}\tprice={p.Price} \tname={p.ProductName}\t description={p.Description}\t stock= {p.quantityInStock}\t type={p.Type}\n");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("\n");

                        }

                        break;

                    case 6:


                        try
                        {
                            List<Tuple<Product, int>> tuples = orderProcessor.GetOrderByUser();
                            foreach (Tuple<Product, int> tuple in tuples)
                            {
                                Console.WriteLine($"Product_ID={tuple.Item1.product_id} \tProduct Name={tuple.Item1.ProductName} \t Quantity={tuple.Item2}\n\n");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("\n");

                        }
                        break;



                    case 0:
                        flag = 0;
                        break;

                    default:
                        Console.WriteLine("Invalid input.....");
                        break;
                }





            } while (flag == 1);

           
        }

    }
}
