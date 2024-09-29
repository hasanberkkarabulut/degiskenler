using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
 
namespace Personel
{
    public static class Class1
    {
        // static olarak belirlenen Class örneklenemez
        // Class1 C1 = new Class1();
        //
        //public void Test()
        //{

        //}

        public static void emailgönder(string emailal, string konu, string içerik)
        {
            Console.WriteLine("mail gönderme işlemi başarılı :");
        }
         
        //public Class1()
        //{

        //}

        static Class1()
        {
            Console.WriteLine("Helper => static class => static CTOR");
        }

    }
}
