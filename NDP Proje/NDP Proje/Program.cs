using System;
using System.Collections;

namespace NDP_Proje
{
    class Program
    {
        static Boolean isOperand(char x)
        {
            return (x >= 'a' && x <= 'z') ||
                    (x >= 'A' && x <= 'Z');
        }

       
        static String getInfix(String exp)
        {
            Stack s = new Stack();

            for (int i = 0; i < exp.Length; i++)
            {
               
                if (isOperand(exp[i]))
                {
                    s.Push(exp[i] + "");
                }

               
                else
                {
                    String op1 = (String)s.Peek();
                    s.Pop();
                    String op2 = (String)s.Peek();
                    s.Pop();
                    s.Push("(" + op2 + exp[i] +
                            op1 + ")");
                }
            }
            
            return (String)s.Peek();
        }

        
        public static void Main(String[] args)
        {
            Console.WriteLine("Postfix İfadenizi Giriniz :");
            String exp = Console.ReadLine();
            Console.WriteLine(getInfix(exp));
        }
    }
}
