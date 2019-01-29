using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClasses
{
    class SupDelStatements
    {
        //Queries used in SuppliersDB. They are very long so they are stored in another class.
        public static readonly string PSS_Query = "DELETE Packages_Products_Suppliers FROM Suppliers LEFT JOIN Products_Suppliers ON" +
" Suppliers.SupplierId = Products_Suppliers.SupplierId LEFT JOIN Packages_Products_Suppliers ON Products_Suppliers.ProductSupplierId =" +
" Packages_Products_Suppliers.ProductSupplierId WHERE Suppliers.SupplierId = @sid;";
        public static readonly string PS_Query = "DELETE Products_Suppliers FROM Suppliers LEFT JOIN Products_Suppliers ON " +
"Suppliers.SupplierId = Products_Suppliers.SupplierId " +
"WHERE Suppliers.SupplierId = @sid;";
        public static readonly string BD_Query = "DELETE BookingDetails FROM Suppliers LEFT JOIN Products_Suppliers ON " +
"Suppliers.SupplierId = Products_Suppliers.SupplierId LEFT JOIN BookingDetails" +
            " ON Products_Suppliers.ProductSupplierId = BookingDetails.ProductSupplierId " +
"WHERE Suppliers.SupplierId = @sid;";
        public static readonly string S_Query = "DELETE FROM Suppliers WHERE SupplierId = @sid;";

        public static readonly string SC_Query = "DELETE SupplierContacts FROM Suppliers LEFT JOIN SupplierContacts ON " +
"SupplierContacts.SupplierId = Suppliers.SupplierId " +
"WHERE Suppliers.SupplierId = @sid;";
    }
}
