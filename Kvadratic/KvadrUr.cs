using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadratic
{
    class KvadrUr
    {
        double a, b, c;

        public KvadrUr(string a, string b, string c)
        {
            double.TryParse(a, out this.a);
            double.TryParse(b, out this.b);
            double.TryParse(c, out this.c);
        }
     
        public string KvadrMath(int x_Number)
        {
            double D;
            if (a != 0) //проверка на точное существование ответа
            {
                D = b * b - 4 * a * c;
                if (D == 0)
                {
                    if (x_Number == 1)
                        return "" + (-b / 2 * a); //x1
                    else
                        return "Не существует"; //x2   
                }
                else
                if (D < 0)
                    return "Ответа нет.";
                else  //D > 0
                {
                    if (x_Number == 1)              
                        return "" + ((-b + Math.Sqrt(D)) / (2 * a)); //x1
                    else                  
                        return "" + ((-b - Math.Sqrt(D)) / (2 * a)); //x2
                }
            }
            else {   //возможно отсутствие ответа, проверка b, c
                if (b == 0)
                {          
                    if (c == 0)          
                        return "Любое значение";
                    else                  
                        return "Не существует";
                }

                else
                {    
                    if (x_Number == 1)                 
                        return ("" + (-c / b)); //x1 
                    else                    
                        return "Значения нет"; //x2
                }
            }
        }
    }
}
