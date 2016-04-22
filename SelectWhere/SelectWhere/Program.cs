using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectWhere
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        SELECT* FROM CUSTOMER ;
        SELECT FIRSTNAME, LASTNAME FROM CUSTOMER;

        SELECT* FROM CUSTOMER, INVOICE ;

            SELECT ID, Name
FROM Product
WHERE Name = 'Blade';
    }
}
