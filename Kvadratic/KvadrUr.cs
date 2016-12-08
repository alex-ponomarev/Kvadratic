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
        double x1, x2;

        public KvadrUr(string a, string b, string c)
        {
            if (!(double.TryParse(a, out this.a)))
                throw new Exception("Ошибка значения A");
            if (double.TryParse(b, out this.b) == false)
                throw new Exception("Ошибка значения B");
            if (double.TryParse(b, out this.c) == false)
                throw new Exception("Ошибка значения C");
        }

        public string KvadrMath(int x_Number)
        {
            double D;
            if (a != 0) //проверка классического уравнения
            {
                D = b * b - 4 * a * c;
                if (D == 0)
                {
                    if (x_Number == 1)
                    {
                        x1 = -b / 2 * a; //x1
                        return "" + x1;
                    }
                    else
                        return "Не существует"; //x2   
                }
                else
                if (D < 0)
                    return "Ответа нет.";
                else  //D > 0
                {
                    if (x_Number == 1)
                    {
                        x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        return "" + x1; //x1

                    }
                    else
                    {
                        x2 = (-b - Math.Sqrt(D)) / (2 * a);
                        return "" + x2; //x1
                    }
                }
            }
            else {  //проверка варианта bx+c=0
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
                    {
                        x1 = -c / b;
                        return "" + x1; //x1 
                    }
                    else
                        return "Значения нет"; //x2
                }
            }
        }
        public double X1
        {
            get
            {
                double D;
                if (a != 0) //проверка классического уравнения
                {
                    D = b * b - 4 * a * c;
                    if (D == 0)
                        x1 = -b / 2 * a; //x1                       
                    else
                    if (D < 0)
                        throw new Exception("Для x1 ответа нет");
                    else  //D > 0                

                        x1 = (-b + Math.Sqrt(D)) / (2 * a);
                }
                else {  //проверка варианта bx+c=0
                    if (b == 0)
                    {
                        if (c == 0)
                            throw new Exception("x1 любое значение");
                        else
                            throw new Exception("x1 не существует");
                    }

                    else
                        x1 = -c / b;
                }

                return x1;
            }
        }
        public double X2
        {
            get
            {
                double D;
                if (a != 0) //проверка классического уравнения
                {
                    D = b * b - 4 * a * c;
                    if (D == 0)
                        throw new Exception("x2 не существует"); //x2   
                    else
                    if (D < 0)
                        throw new Exception("Для x2 ответа нет.");
                    else  //D > 0
                    {
                        x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    }
                }
                else {  //проверка варианта bx+c=0
                    if (b == 0)
                    {
                        if (c == 0)
                            throw new Exception("x2 - любое значение");
                        else
                            throw new Exception("x2 - не существует");
                    }

                    else
                        throw new Exception("Для x2 значения нет");
                }


                return x2;
            }
        }
        public void KvadrBoth() //NaN //infinity
        {
            double D;
            if (a != 0) //проверка классического уравнения
            {
                D = b * b - 4 * a * c;
                if (D == 0)
                {
                    x1 = -b / 2 * a; //x1
                    x2 = double.NaN;
                }
                else
                if (D < 0)
                {
                    x1 = double.NaN;
                    x2 = double.NaN;
                }
                else  //D > 0
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                }
            }
            else {  //проверка варианта bx+c=0
                if (b == 0)
                {
                    if (c == 0)
                        x1 = double.PositiveInfinity;
                    else
                        x1 = double.NaN;
                    x2 = double.NaN;
                }

                else
                {
                    x1 = -c / b;
                    x2 = double.NaN;
                }
            }
        }
        public double KvadrResult(int x_Number) //Naninfinity //Для одного поля
        {
            double D;
            if (a != 0) //проверка классического уравнения
            {
                D = b * b - 4 * a * c;
                if (D == 0)
                {
                    if (x_Number == 1)
                    {
                        x1 = -b / 2 * a; //x1
                        return x1;
                    }
                    else
                    {
                        x2 = double.NaN;
                        return x2; //x2   
                    }
                }
                else
                if (D < 0)
                {
                    x1 = double.NaN;
                    x2 = double.NaN;
                    return double.NaN;
                }             
                else  //D > 0
                {
                    if (x_Number == 1)
                    {
                        x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        return x1; //x1

                    }
                    else
                    {
                        x2 = (-b - Math.Sqrt(D)) / (2 * a);
                        return x2; //x2
                    }
                }
            }
            else {  //проверка варианта bx+c=0
                if (b == 0)
                {
                    if (c == 0)
                    {
                        x1 = double.PositiveInfinity;
                        return x1;
                    }
                    else
                    {
                        x2 = double.NaN;
                        return x2;
                    }
                }

                else
                {
                    if (x_Number == 1)
                    {
                        x1 = -c / b;
                        return x1; //x1 
                    }
                    else
                    {
                        x2 = double.NaN;
                        return x2; //x2
                    }
                }
            }
        }
    }
}
 