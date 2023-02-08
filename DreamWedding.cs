using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class DreamWedding
    {
        public bool ValidatePackage(string packageType)
        {
            if (packageType == "FSW" || packageType == "DW" | packageType == "D" || packageType == "fsw" || packageType == "dw" | packageType == "d")
            {
                return true;
            }
            else
            {
                Console.WriteLine("No Such Wedding package available");
                return false;
            }
        }
        public bool ValidateEventList(string packageType, List<string> events)
        {
            if (packageType == "FSW" || packageType == "fsw")
            {
                events.Add("wedding venues");
                events.Add("vendor management");
                events.Add("wedding invites");
                events.Add("photography & videography");
                events.Add("bridal styling");
                return true;
            }
            else if (packageType == "dw" || packageType == "DW")
            {
                events.Add("wedding venues");
                events.Add("transportation");
                events.Add("bridal styling");
                return true;
            }
            else if (packageType == "d" || packageType == "D")
            {
                events.Add("floor design");
                events.Add("lighting design");
                events.Add("furniture linen");
                return true;
            }
            else
            {
                Console.WriteLine("Not all events valid for this package");
                return false;
            }
        }
        public bool ValidateEventCost(double eventCost)
        {
           if( eventCost >= 5000)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public double GetTotalCost(Dictionary<string, double> wedding)
        {
            double sum = 0;
          foreach(KeyValuePair<string,double> item in wedding)
            {
                if (item.Value >= 5000)
                {
                    sum += item.Value;
                    break;
                }
                else
                {
                    sum = 0;
                    break;
                }
            }
            return sum;
        }

    }
}