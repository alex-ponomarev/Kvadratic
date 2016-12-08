using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabkaOOP
{ //Эллипс
    class Figura
    {
        protected double a, b; // большая, малая полуоси
        protected double s, p; // площадь, периметр
             
        /// <summary>
        ///  конструктор класса 
        /// </summary>
        /// <param name="a">большая полуось</param>
        /// <param name="b">малая полуось</param>
        public Figura(double a, double b) 
        {
            this.a = a;
            this.b = b;           
        }

        /// <summary>
        /// вычисление периметра
        /// </summary>
        virtual public void P()  
        {
            p = 4 * ((Math.PI * a * b + (a - b)) / (a + b)); 
        }
        /// <summary>
        /// вычисление площади
        /// </summary>
        virtual public void S()  
        {
            s = Math.PI * a * b;
        }
        /// <summary>
        /// выдать название
        /// </summary>
        /// <returns>название фигуры</returns>
        virtual public string About()  
        {
            return ("Эллипс");
        }
        /// <summary>
        /// сравнение
        /// </summary>
        /// <param name="a">первая фигура</param>
        /// <param name="b">вторая фигура</param>
        /// <returns>наибольшая фигура</returns>
        static string ComparisonEl(Figura a, Figura b)  
        {
            a.S();
            b.S();
            if (a.s > b.s)
                return ("Первый эллипс больше");
            else
                return ("Второй эллипс больше");
        }
         
    }
    class TolFigura : Figura
    {
        double c,v; // толщина, обьем

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="a">большая полуось</param>
        /// <param name="b">малая полуось</param>
        /// <param name="c">толщина</param>
        public TolFigura(double a, double b, double c) : base(a,b)
        {
            this.c = c;
        }

        /// <summary>
        /// вычисление периметра
        /// </summary>
        override public void P()  
        {
            p = 2*(4 * ((Math.PI * this.a * b + (a - b)) / (a + b)));
        }

        /// <summary>
        /// вычисление площади
        /// </summary>
        override public void S()  
        {
            s = Math.PI * a * b*2+(4 * ((Math.PI * this.a * b + (a - b)) / (a + b)*c));
        }

        /// <summary>
        /// выдать название
        /// </summary>
        /// <returns>название фигуры</returns>
        override public string About()
        {
            return ("Толстый эллипс");
        }

        /// <summary>
        /// объем
        /// </summary>
        void V() 
        {
            v = s * c;  
        }
        /// <summary>
        /// сравнение
        /// </summary>
        /// <param name="a">первая фигура</param>
        /// <param name="b">вторая фигура</param>
        /// <returns>наибольшая фигура</returns>
        static string ComparisonTolEl(TolFigura a, TolFigura b)  
        {
            a.V();
            b.V();
            if (a.v > b.v)
                return ("Первый толстый эллипс больше");
            else
                return ("Второй толстый эллипс больше");
        }
    }
}
