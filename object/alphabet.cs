using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obj
{
    public class alphabet
{
        public string name = "";
        public string nop = "";

        public void Input()
        {
            name = Console.ReadLine();

            //foreach(char alph in name)
            //{
            //    nop = nop + Convert.ToChar(alph + 1);
                
            //}
        }
        public void Display()
        {
            for (int i = 0; i < name.Length; i++)
            {
                nop += Convert.ToChar(name[i] + 1);
            }
            Console.WriteLine(nop);
        }
}
}
