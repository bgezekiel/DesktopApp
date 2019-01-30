using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Project: OOSD Threaded Project 2
* Products class with getters and setters
* Author: Brandon Ezekiel
* Date: Jan 2019
* Commenter: Brandon Ezekiel
*/

namespace DBClasses
{
    // Make product class
    public class Products
    {
        // public methods for get and set

        public Products() { } 

        public int ProductId { get; set; }

        public string ProdName { get; set; }
    }
}
