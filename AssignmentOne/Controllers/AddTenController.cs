using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentOne.Controllers
{
    /* 
     * <summary>
     *  Returns 10 more than the integer input {id}
     * </summary>
     * <param name="id">integer input<param>
     * <returns>integer</returns>
     * <example>
     *  GET: localhost:xx/api/addten/2 => 12
     * </example>
     * <example>
     *  GET: localhost:xx/api/addten/-5 => 5
     * </example>
    */
    public class AddTenController : ApiController
    {
        // GET api/addten/5
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
