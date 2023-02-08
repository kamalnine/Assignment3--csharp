using Assignment_3;
using System;
using System.Diagnostics.CodeAnalysis;

internal class Program

{
    private static void Main(string[] args)
    {
        DreamWedding dream = new DreamWedding();
        String events;
        Console.WriteLine("Welcome to the conto wedding services.........");
        Console.WriteLine();
        Console.WriteLine("Enter the wedding package you wish: ");
       string packageType = Console.ReadLine();
        String Events;
        if (dream.ValidatePackage(packageType))
        {
            if (packageType == "FSW" || packageType == "fsw")
            {
                Dictionary<string, double> d = new Dictionary<string, double>();
                Console.WriteLine("Enter 5 events names and cost seperated by , for the selected package");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Event details " + (i + 1));
                    String key = Console.ReadLine();
                    double value = double.Parse(Console.ReadLine());
                    d.Add(key, value);
                 

                }
                double sum = 0;
                if (d.Keys.Contains("wedding venues") && d.Keys.Contains("vendor management") && d.Keys.Contains("wedding invites") && d.Keys.Contains("photography & videography") && d.Keys.Contains("bridal styling"))
                {
                    if (sum > 0)
                    {
                        Console.WriteLine("Event name" + "   " + "Cost");
                    }
                }
                    
                
                foreach (KeyValuePair<string,double> item in d)
                {
                    if(d.Keys.Contains("wedding venues") && d.Keys.Contains("vendor management") && d.Keys.Contains("wedding invites") && d.Keys.Contains("photography & videography") && d.Keys.Contains("bridal styling"))
                    {
                        if (dream.ValidateEventCost(item.Value))
                        {

                            Console.WriteLine(item.Key + "              " + item.Value);
                            
                        }
                        else
                        {
                            Console.WriteLine("Low Cost Amount...Restart the Application");
                            break;
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("Not all events are valid for this package");
                        break;
                    }
                   }
                if (d.Keys.Contains("wedding venues") && d.Keys.Contains("vendor management") && d.Keys.Contains("wedding invites") && d.Keys.Contains("photography & videography") && d.Keys.Contains("bridal styling"))
                {
                    sum = dream.GetTotalCost(d);
                    Console.WriteLine("Total cost for the wedding is : " + sum); }

            }
            else if (packageType == "DW" || packageType == "dw")
            {
                Dictionary<string, double> d = new Dictionary<string, double>();
                Console.WriteLine("Enter 3 events names and cost seperated by , for the selected package");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Event details " + (i + 1));
                    String key = Console.ReadLine();
                    double value = Double.Parse(Console.ReadLine());
                    d.Add(key, value);
                }
                double Sum = 0;
                if (d.Keys.Contains("wedding venues") && d.Keys.Contains("transportation") && d.Keys.Contains("bridal styling"))
                {
                    if (Sum > 0)
                    {
                        Console.WriteLine("Event name" + "   " + "Cost");
                    }
                }
                    
                foreach (KeyValuePair<string, double> item in d)
                {
                    if(d.Keys.Contains("wedding venues") &&d.Keys.Contains("transportation") && d.Keys.Contains("bridal styling"))
                    {
                        if (dream.ValidateEventCost(item.Value))
                        {
                            Console.WriteLine(item.Key + "              " + item.Value);
                           
                        }
                        else
                        {
                            Console.WriteLine("Low Cost Amount...Restart the Application");
                            break;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Not all events are valid for this package");
                        break;
                    }
                    
                }
                if (d.Keys.Contains("wedding venues") && d.Keys.Contains("transportation") && d.Keys.Contains("bridal styling"))
                {

                    Sum = dream.GetTotalCost(d);
                    
                        Console.WriteLine("Total cost for the wedding is : " + Sum);
                }

            }
            else if (packageType == "D" || packageType == "d")
            {
                Dictionary<string, double> d = new Dictionary<string, double>();
                Console.WriteLine("Enter 3 events names and cost seperated by , for the selected package");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Event Details " + (i + 1));
                    String key = Console.ReadLine();
                    double value  = double.Parse(Console.ReadLine());
                    d.Add(key, value);
                }
                double sum = 0;
                if (d.Keys.Contains("floor design") && d.Keys.Contains("lighting design") && d.Keys.Contains("furniture linen"))
                {
                    if (sum > 0)
                    {
                        Console.WriteLine("Event name" + "   " + "Cost");
                    }
                }
                   
                foreach (KeyValuePair<string, double> item in d)
                {
                    if (d.Keys.Contains("floor design") && d.Keys.Contains("lighting design") && d.Keys.Contains("furniture linen"))
                    {
                        if (dream.ValidateEventCost(item.Value))
                        {
                            Console.WriteLine(item.Key + " " + item.Value);
                            
                        }
                        else
                        {
                            Console.WriteLine("Low Cost Amount...Restart the Application");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not all events are valid for this package");
                        break;
                    }
                }
                if (d.Keys.Contains("floor design") && d.Keys.Contains("lighting design") && d.Keys.Contains("furniture linen"))
                {

                    sum = dream.GetTotalCost(d);
                    if (sum > 0)
                    {
                        Console.WriteLine("Total cost for the wedding is : " + sum);
                    }
      
                }
            }
          
        }
       




    }
}