using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentOne.Controllers
{
    public class HostingCostController : ApiController
    {
        /* 
         * <summary>
         *  Endpoint return hosting cost for client per number of day elapsed
         * </summary>
         * <param name="id">number of days</param>
         * <returns>An array of strings representing the cost breakdown.</returns>
         * <example>
         *  GET: localhost:xx/api/hostingcost/0 => ['1 fortnights at $5.5 / FN = $5.5 CAD', 'HST 13 % = $0.72 CAD', 'Total = $6.22 CAD']
         * </example>
         * <example>
         *  GET: localhost:xx/api/hostingcost/0 => ['2 fortnights at $5.5 / FN = $5.5 CAD', 'HST 13 % = $1.43 CAD', 'Total = $12.43 CAD']
         * </example>
        */
        public string[] Get(int id)
        {
            // Hosting pricing conditions
            int daysPerFortnight = 14;
            double hstRate = 13;
            double costPerFortnight = 5.5;

            int noOfDays = id; // user's inputted days
            double tempNoOfFortnight = (noOfDays / daysPerFortnight) + 1;
            int noOfFortnights = (int) Math.Floor(tempNoOfFortnight); // round fortnights down to the nearest integer 
            double fornightCost = Math.Round(noOfFortnights * costPerFortnight, 2);
            double hstCost = Math.Round((hstRate / 100) * fornightCost, 2); 
            double totalCost = fornightCost + hstCost;

            string[] result = {
                noOfFortnights + " fortnights at $"+costPerFortnight + " / FN = $" + costPerFortnight +" CAD",
                "HST 13 % = $" + hstCost + " CAD",
                "Total = $" + totalCost + " CAD"
            };
            return result;
        }

    }
}
