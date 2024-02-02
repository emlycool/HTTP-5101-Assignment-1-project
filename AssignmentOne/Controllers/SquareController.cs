using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentOne.Controllers
{
    public class SquareController : ApiController
    {
        /* 
         * <summary>
         *  Returns the square of the integer input {id} in absolute value
         * </summary>
         * <param name="id">integer input<param>
         * <returns>integer</returns>
         * <example>
         *  GET: localhost:xx/api/square/2 => 4
         * </example>
         * <example>
         *  GET: localhost:xx/api/square/-2 => 2
         * </example>
        */
        public int Get(int id)
        { 
            return (int) Math.Pow(Math.Abs(id), 2);
        }
    }
}
