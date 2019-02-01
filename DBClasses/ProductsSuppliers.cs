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
    // create the ProductsSuppliers Class
    public class ProductsSuppliers
    {
        // setting the getters and setters for columns in table
        public ProductsSuppliers() { }

        public int ProductSupplierId { get; set; }

        public int SupplierId { get; set; }

        public int ProductId { get; set; }
    }
}
