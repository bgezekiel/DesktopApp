using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Project: OOSD Threaded Project 2
* Manage Products/Suppliers GUI code to manage suppliers and products
* Author: Brandon Ezekiel
* Date: Jan 2019
* Commenter: Brandon Ezekiel
*/

namespace DBClasses
{
    // Make supplier class
    public class Suppliers
    {
        // public get and set methods for colunms in suppliers table
        public Suppliers() { }

        public int SupplierId { get; set; }

        public string SupName { get; set; }
    }
}
