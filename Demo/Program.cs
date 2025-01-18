
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
            //Console.WriteLine($"C3: {c3}");//C3: 5 + 4i 

            #endregion

            #endregion

            #region Part 05 Operators Overloading - Relational Operators (> <) (>= <=) (== !=)

            //Complex c1 = new Complex() { Real = 7, Imag = 4 };
            //Complex c2 = new Complex() { Real = 7, Imag = 4 };

            //if (c1 > c2)
            //{
            //    Console.WriteLine("C1 is greater than C2");
            //}
            //else if (c1 < c2)
            //{
            //    Console.WriteLine("C1 is less than C2");
            //}
            //else
            //{
            //    Console.WriteLine("C1 equals c2");
            //}

            #endregion

            #region Part 06 Casting Operators Overloading (type)

            #region Ex01 Explicit Casting of (int) casting operator

            //Complex c1 = new Complex() { Real = 3, Imag = 4 };
            //int x = (int)c1;

            //Console.WriteLine(x);//3


            #endregion

            #region Ex02 Implicit Casting of (string) casting operator

            //Complex c1 = new Complex() { Real = 6, Imag = 8 };
            //string x = c1; // Implicit Casting ( Instead of writing [ string x = (string) c1; ] ).

            //Console.WriteLine(x);// 6 + 8i

            /*

                 * But we don't recommend to make implicit casting overload on the casting operators for some reasons : 

                 * 1- Readability => 
                 * 
                 *  Complex c1 = new Complex() { Real = 6, Imag = 8 };
                 *  string x = c1
                 *  
                 *  When any one read this, he will say how convert from Complex to int or how refer by reference of type string to object of type Complex , although c# is strongly type language 
                 *  so => 
                 *  
                 *  Complex c1 = new Complex() { Real = 6, Imag = 8 };
                 *  string x = c1
                 *  
                 *  Is More Readable

                 *  2- Compiler Noticing 
                 *  
                 *  We recommend to use  explicit casting overload because if you forget writing the casting operator, it notice you to put it 
                 *  
                 *  Complex c1 = new Complex() { Real = 6, Imag = 8 };
                 *  string x = c1
                 *  
                 *  Compiler Will notice you here if you use explicit casting overload.

             */


            #endregion

            #endregion

        }

    }
}
