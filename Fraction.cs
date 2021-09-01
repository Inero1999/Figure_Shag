using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Fraction
    {
        public int chisl { get; set; }
        public int znam { get; set; }

        public Fraction(int chisl,int znam)
        {
            this.chisl = chisl;
            this.znam = znam;
        }

        public static bool operator true(Fraction f)
        {
            return f.chisl < f.znam ? true : false;
        }

        public static bool operator false(Fraction f)
        {
            return f.chisl >= f.znam ? true : false;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction
            {
                chisl = f1.chisl * f2.chisl,
                znam = f1.znam * f2.znam
            };
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction
            {
                chisl = f1.chisl * f2.znam,
                znam = f1.znam * f2.chisl
            };
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.Equals(f2);
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            //int nod = 1;
            //if ((f1.znam >= f2.znam) ? nod = (int) (f1.znam / f2.znam) : nod = (int)(f2.znam / f1.znam)) ;
            return new Fraction
            {                               
                chisl = f1.chisl * f2.znam+f2.chisl*f1.znam,
                znam = f1.znam * f2.znam
            };
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            //int nod = 1;
            //if ((f1.znam >= f2.znam) ? nod = (f1.znam / f2.znam) : nod = (f2.znam / f1.znam)) ;
            return new Fraction
            {
                chisl = f1.chisl * f2.znam - f2.chisl * f1.znam,
                znam = f1.znam * f2.znam
            };
        }

    }

}
