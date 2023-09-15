using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritence
{
  
    class Program
    {
        
        static void Main(string[] args)
        {
            Accountcreditinfo myObj1 = new Accountcreditinfo();
            Console.WriteLine(myObj1.Credit());
            Console.ReadLine();
        }
        

    }
    public class Accountcreditinfo //base class
    {
        public string Credit()
        {
            return "balance is credited";
        }
    }
    public class debitinfo : Accountcreditinfo //derived class
    {
        public string debit()
        {
            Credit();                       ////derived class method
            return "balance is debited";
        }
    }

}
