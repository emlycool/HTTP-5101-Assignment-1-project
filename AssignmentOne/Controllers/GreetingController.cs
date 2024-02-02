using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentOne.Controllers
{
    public class GreetingController : ApiController
    {
        /* 
         * <summary>
         *  Return Hello World !
         * </summary>
         * <returns>string.</returns>
         * <example>
         *  GET: localhost:xx/api/greeting => "Hello World!"
         * </example>
        */
        public string Get()
        {
            return "Hello World!";
        }

        /* 
         * <summary>
         *  Return greeting
         * </summary>
         * <param name="id">number of people to greet</param>
         * <returns>string</returns>
         * <example>
         *  GET: localhost:xx/api/greeting/3 => "Greetings to 3 people!"
         * </example>
         * <example>
         *  GET: localhost:xx/api/greeting/6 => "Greetings to 6 people!"
         * </example>
        */
        public string Get(int id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
