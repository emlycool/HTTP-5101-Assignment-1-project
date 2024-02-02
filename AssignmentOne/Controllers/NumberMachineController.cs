using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentOne.Controllers
{
    public class NumberMachineController : ApiController
    {
        /* 
         * <summary>
         *  Perform the followinig arithmetic to the param ((n + 10)^2 / n) - 2
         * </summary>
         * <param name="id">number to run arithmetic on</param>
         * <returns> integer result.</returns>
         * <example>
         *  GET: localhost:xx/api/numbermachine/2 => 70
         * </example>
         * <example>
         *  GET: localhost:xx/api/numbermachine/10 => 38
         * </example>
        */
        public int Get(int id)
        {
            int result = id + 10; // addition
            result = (int) Math.Pow(Math.Abs(result), 2); //square
            result = result / id; // division
            result -= 2; //subtraction
            return result;
        }
    }
}
