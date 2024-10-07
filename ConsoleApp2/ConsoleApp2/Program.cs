
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal  class Program
    {

      public  int personid;
      public  string name;
        public static  int  ratei;

        public  Program(int  personid, string name)
        {
            this.personid = personid;
            this.name = name;   
        }
        static Program()
        {
            ratei = 12;

        }
        public void show()
        {
            Console.WriteLine("data"+personid+name+ratei);

        }


    }
    class Test
    {
        public static void Main(string[] args)
        {
            // not to initaniate

           Program program =new Program(22,"rakib");
            program.show();


        }
    }

}
