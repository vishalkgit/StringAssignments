using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignments
{
    public delegate int MyDelegate(int x, int y);

    public delegate string MyDelegate2(string name);    
    
    public class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Sub(int a,int b)
        {
            return a - b;
        }

        public int Multiply(int a,int b)
        {
            return a * b;
        }
    }

    public class User
    {
      public string AcceptName(string name)
        {
            return name.ToUpper();
        }
          
    }


    

}
