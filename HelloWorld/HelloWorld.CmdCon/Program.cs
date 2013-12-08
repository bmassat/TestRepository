using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Domain;

namespace HelloWorld.CmdCon
{
    class Program
    {
        static void Main(string[] args)
        {

            Message msg = new Message();
            ;
            for (int i = 0; i < msg.DisplayText.Length;i++ )
            {
                Console.WriteLine(msg.DisplayText[i]);


            }


            foreach (var item in msg.DisplayText)
            {
                Console.WriteLine(item);

            }

            Console.ReadKey();
        }
    }
}
