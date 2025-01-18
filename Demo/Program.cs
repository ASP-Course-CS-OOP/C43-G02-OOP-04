
using Demo.Operators_Overloading;

namespace Demo
{
    internal class Program
    {

        #region Part 02 Polymorphism - Overloading

        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Sum(int x, int y, int z)//Different [Numbers] Of Parameters
        {
            return x + y + z;
        }
        static double Sum(double x, double y)//Different [Type] Of Parameters
        {
            return x + y;
        }
        static double Sum(int x, double y)//Different [Type] Of Parameters
        {
            return x + y;
        }

        #endregion

        static void Main(string[] args)
        {

            #region Part 01 Polymorphism

            //Done [Check NoteBad].

            #endregion

            #region Part 02 Polymorphism - Overloading

            #region 1st overload (int,int)

            //dynamic result = Sum(5, 5);
            //Console.WriteLine(result);//10 

            #endregion

            #region 2nd overload (int,int,int) [Different Numbers Of Parameters]

            //result = Sum(4, 3, 2);
            //Console.WriteLine(result);//9 

            #endregion

            #region 3rd overload (int,double) [Different Type Of Parameters]

            //result = Sum(5, 5.5);
            //Console.WriteLine(result);//10.5 

            #endregion

            #region 4th overload (double,double) [Different Type Of Parameters]

            //result = Sum(5.5, 4.3);
            //Console.WriteLine(result);//9.8 

            #endregion

            #region WriteLine() has 19+ overload

            //Console.WriteLine("Eslam");//overload take string.
            //Console.WriteLine('E');//overload take char.
            //Console.WriteLine(10);//overload take int.
            //Console.WriteLine(true);//overload take bool.

            ////Instead of do this => 

            ////Console.WriteLineString("Eslam");
            ////Console.WriteLineChar('E');
            ////Console.WriteLineInt(10);
            ////Console.WriteLineBool(true);

            #endregion

            #endregion

            #region Part 03 Operators Overloading - Binary Operators

            #region Ex01

            //Complex c1 = new Complex() { Real = 5, Imag = 4 };
            //Complex c2 = new Complex() { Real = 3, Imag = 2 };

            //Complex c3 = c1 + c2;

            //Console.WriteLine($"C1: {c1}"); //  C1: 5 + 4i
            //Console.WriteLine($"C2: {c2}"); //  C2: 3 + 2i
            //Console.WriteLine("----------");//  ----------
            //Console.WriteLine($"C3: {c3}"); //  C3: 8 + 6i

            #endregion

            #region Ex02

            //Complex c1 = new Complex() { Real = 5, Imag = 4 };
            //Complex c2 = new Complex() { Real = 3, Imag = 2 };

            //Complex c3 = c1 + c2;
            //Complex c4 = c1 + c2 + c3;

            //Console.WriteLine($"C1: {c1}");//  C1: 5 + 4i
            //Console.WriteLine($"C2: {c2}");//  C2: 3 + 2i
            //Console.WriteLine($"C3: {c3}");//  C3: 8 + 6i
            //Console.WriteLine("----------");// ----------
            //Console.WriteLine($"C3: {c4}");//  C3: 16 + 12i

            #endregion

            #endregion

            #region Part 04 Operators Overloading - Unary Operators ++ --

            #region Ex01 - Complex c3 = ++c1 [Prefix]

            //Complex c1 = new Complex() { Real = 5, Imag = 4 };
            //Complex c2 = new Complex() { Real = 2, Imag = 3 };

            //Complex c3 = ++c1;// c3 will contain the result of (++c1) which is new object, and (++c1 mean c1 = c1+1) so the reference "c1" also will refer to the new object (new Complex(){Real = 6, Imag = 5}), so the object ( new Complex() { Real = 5, Imag = 4 } ) Became Unreachable

            //Console.WriteLine($"C1: {c1}");//C1: 6 + 5i
            //Console.WriteLine($"C1: {c3}");//C3: 6 + 5i 

            #endregion

            #region Ex02 - Complex c3 = c1++ [Suffix]

            //Complex c1 = new Complex() { Real = 5, Imag = 4 };
            //Complex c2 = new Complex() { Real = 2, Imag = 3 };

            //Complex c3 = c1++;// "c3" will contain the result of "c1" first which is the object ( new Complex() { Real = 5, Imag = 4 } ),
            //                  // and then (c1++ mean c1 = c1+1) so the reference "c1" also will refer to the new object (new Complex(){Real = 6, Imag = 5}),
            //                  // the object ( new Complex() { Real = 5, Imag = 4 } ) is not unreachable because "c3" Hold it 

            //Console.WriteLine($"C1: {c1}");//C1: 6 + 5i
            Console.WriteLine($"C3: {c3}");//C3: 5 + 4i 

            #endregion

            #endregion

        }

    }
}
