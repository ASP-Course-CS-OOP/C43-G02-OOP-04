
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

        }

    }
}
