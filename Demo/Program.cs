
using Demo.Casting_Operators_Overloading;
using Demo.Operators_Overloading;
using Demo.Polymorphism;

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

        #region Part 11 Binding is a Behaviour

        #region Ex01 - No Binding [this is Reference "employee" from Child "FullTimeEmployee" refer to object "fullTimeEmployee = new FullTimeEmployee();" of type Child "FullTimeEmployee"].

        public static void ProcessEmployee(FullTimeEmployee employee) // employee = fullTimeEmployee => new FullTimeEmployee() { Id = 1000, Name = "Eslam Elsaadany", Age = 22, Salary = 10_000 }; => No Binding [this is Reference from Child refer to object of type Child].
        {
            if (employee is { })
            {
                employee.MyFunc01();
                employee.MyFunc02();
            }
        }

        #endregion

        #region Ex02 - No Binding [this is Reference "employee" from Child "PartTimeEmployee" refer to object "partTimeEmployee = new PartTimeEmployee()" of type Child "PartTimeEmployee"].

        public static void ProcessEmployee(PartTimeEmployee employee) // employee = partTimeEmployee => new PartTimeEmployee() { Id = 1001, Name = "Ahmed Ashraf", Age = 25, HourRate = 250 }; => No Binding [this is Reference from Child refer to object of type Child].
        {
            if (employee is { })
            {
                employee.MyFunc01();
                employee.MyFunc02();
            }
        }

        #endregion

        // But This Overload Is Useless Because The Behavior In The Two Methods Is The Same[ Make one method that can take object of type class "Employee" or object of type any class inherit from "Employee" like "FullTimeEmployee" - "PartTimeEmployee"] 

        #region Ex03 - Binding [this is Reference "employee" from Parent "Employee" refer to object "fullTimeEmployee = new FullTimeEmployee()" of type Child "FullTimeEmployee"] || [this is Reference "employee" from Parent "Employee" refer to object "partTimeEmployee = new PartTimeEmployee()" of type Child "PartTimeEmployee"]

        public static void ProcessEmployee(Employee employee) // employee = fullTimeEmployee => new FullTimeEmployee() { Id = 1000, Name = "Eslam Elsaadany", Age = 22, Salary = 10000 }; =>  Binding [this is Reference from Parent refer to object of type Child].
                                                              // employee = PartTimeEmployee => new PartTimeEmployee() { Id = 1001, Name = "Ahmed Ashraf", Age = 25, HourRate = 250 };    =>  Binding [this is Reference from Parent refer to object of type Child].
        {
            if (employee is { })
            {
                employee.MyFunc01();// Static Binding[new] => "Iam Employee!" - Regardless The object is of type "FullTimeEmployee" Or "PartTimeEmployee".
                employee.MyFunc02();// Dynamic Binding[override] => "FullTimeEmployee => Id = 1000, Name = Eslam Elsaadany, Age = 22, Salary = $10,000.00" [In case the object is of type "FullTimeEmployee"]
                                    //                           => "PartTimeEmployee => Id = 1001, Name = Ahmed Ashraf, Age = 25, HourRate = 250" [In case the object is of type "PartTimeEmployee"]
            }
        }

        #endregion

        #endregion

        static void Main(string[] args)
        {

            #region Part 01 Polymorphism

            //Done [Check NoteBad].

            #endregion

            #region Overloading

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

            #region Operators Overloading

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

            #endregion

            #region Casting Operators Overloading

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

            #region Part 07 Casting Operator Overloading - Need

            //User user = new User()
            //{
            //    Id = 12345,
            //    FullName = "Eslam Elsaadany",
            //    Email = "eslam.saadany22@gmail.com",
            //    Password = "123456",
            //    SecurityStmp = Guid.NewGuid()
            //};

            #region But I Don't need to view this user in this form of data, I need to cast it to user of Type (UserViewModel), to view it in Form Of Data Of (UserViewModel). 

            //// But I Don't need to view this user in this form of data, I need to cast it to user of Type (UserViewModel), to view it in Form Of Data Of (UserViewModel). 

            ////UserViewModel userViewModel01 = user;//Error , because Reference of Type "UserViewModel" can only refer to object of type "UserViewModel"

            ////UserViewModel userViewModel02 = (UserViewModel)user;//Error, Because the casting operator (UserViewModel) can only cast from object of type "UserViewModel" to object of type "UserViewModel".

            ////Like in this case => 

            //object obj = new UserViewModel() { Id = 1001 ,FName = "Eslam",LName = "Elsaadany",Email = "eslam.saadany222@gmail.com",Password = "123456"};
            //UserViewModel userViewModel03 = (UserViewModel)obj;

            //Console.WriteLine(userViewModel03); // ID: 1001
            //                                    // FName: Eslam
            //                                    // LName: Elsaadany
            //                                    // Email: eslam.saadany222 @gmail.com
            //                                    // Password: 123456 

            #endregion

            #region Cast From object of type "User" to object of type "UserViewModel" by overload on the casting operator (UserViewModel) to let it do this new behaviour [Mapping from "User" to "UserViewModel"]

            //UserViewModel userViewModel = (UserViewModel)user;

            //Console.WriteLine(userViewModel);

            //// ID: 12345
            //// FName: Eslam
            //// LName: Elsaadany
            //// Email: eslam.saadany22 @gmail.com
            //// Password: 123456

            #endregion

            #endregion

            #endregion

            #endregion

            #region Overriding

            #region Part 08 Polymorphism - Overriding

            #region Ex01 - Reference from type refer to object of same type [ TypeA typeA = new TypeA(5); ].  

            //TypeA typeA = new TypeA(5);

            ////Through this reference "typeA" you can access any thing inside the class TypeA.
            //typeA.A = 11;
            //typeA.MyFunc01();// MyFunc01 => Iam Base [Parent]
            //typeA.MyFunc02();// MyFunc01 => TypeA : A = 11 

            #endregion

            #region Ex02 - Reference from type refer to object of same type [ TypeB typeB = new TypeB(5, 6); ].

            //TypeB typeB = new TypeB(5, 6);

            //typeB.A = 4;
            //typeB.B = 2;

            //typeB.MyFunc01();// MyFunc01 => Iam Derived [Child]
            //typeB.MyFunc02();// MyFunc02 => TypeB: A = 4, B = 2 

            #endregion

            #region Ex03 - Reference from parent can refer to object of type parent or object of type any class inherit from parent [ TypeA typeA = new TypeB(5, 3); ].

            ////The Reference "typeA" which is of type "TypeA" can access only the properties and methods of "TypeA" that "TypeB" inherit from "TypeA".  

            //TypeA typeA = new TypeB(5, 3);
            //typeA.A = 11;// "TypeB" inherit Property "A" from "TypeA" so the reference "typeA" which of type "TypeA" can access it.
            ////typeA.B = 6;// "TypeB" not inherit Property "B" from "TypeA" so the reference "typeA" which of type "TypeA" can't access it.

            //typeA.MyFunc01();// MyFunc01 => Iam Base [Parent]  - [Static Binding]
            //typeA.MyFunc02(); // MyFunc02 => TypeB: A = 11, B = 3 - [Dynamic Binding]

            #endregion

            #endregion

            #endregion

            #region Part 09 What is Binding

            //Done [Check NoteBook].

            #endregion

            #region Part 10 Child is Parent [not vice versa]

            //TypeA typeA = new TypeA(1);//Reference of type Parent "TypeA" can refer to object of type Parent "TypeA" or object of type Child "TypeB";
            //typeA = new TypeB(1,2);//Reference of type Parent "TypeA" can refer to object of type Child "TypeB";

            #region Ex01 - Reference "typeB" of type Child "TypeB" Hold Reference "typeA" which of type Parent "TypeA" - but the reference "typeA" Refer To object of type "TypeB"  - so no runTime error when casting. 

            ////Note => Reference of type Child "TypeB" can only refer to object of type Child "TypeB".

            ////TypeB typeB = typeA;
            //// Reference From Child "TypeB" can refer to object from Child "TypeB" only - But Why it not work , although the reference "typeA" refer to object of type "TypeB" ?
            //// That's because the reference "typeA" not only can refer to object of type "TypeB", it can refer to another objects of another types inherit from "TypeA", so compiler want you to specify the type of this object [that this reference "typeA" refer to]  first by make explicit casting using casting operator (TypeB).

            //TypeB typeB = (TypeB)typeA;
            //Console.WriteLine(typeB.A);// 1
            //Console.WriteLine(typeB.B);// 2 

            #endregion

            #region Ex02 - Reference "typeB" of type Child "TypeB" Hold Reference "typeA" which of type Parent "TypeA" - but the reference "typeA" Refer To object of type "TypeC"  - so it cause runTime error when casting Because can't assign address of "TypeC" object to Reference of type "TypeB". 

            //typeA = new TypeC(2, 4);

            //TypeB typeB = (TypeB)typeA;
            //Console.WriteLine(typeB.A);// RunTimeError : Unable to cast object of type 'TypeC' to type 'TypeB'.
            //Console.WriteLine(typeB.B);// RunTimeError : Unable to cast object of type 'TypeC' to type 'TypeB'.

            #endregion

            #endregion

            #region Part 11 Binding is a Behaviour

            #region Ex01 - No Binding [this is Reference "fullTimeEmployee" from Child "FullTimeEmployee" refer to object "new FullTimeEmployee()" of type Child "FullTimeEmployee"].

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee() { Id = 1000, Name = "Eslam Elsaadany", Age = 22, Salary = 10_000 };

            //ProcessEmployee(fullTimeEmployee);// Iam Full Time Employee!
            //                                  // FullTimeEmployee => Id = 1000, Name = Eslam Elsaadany, Age = 22, Salary = $10,000.00

            #endregion

            #region Ex02 - No Binding [this is Reference "PartTimeEmployee" from Child "PartTimeEmployee" refer to object "new PartTimeEmployee()" of type Child "PartTimeEmployee"].

            //PartTimeEmployee PartTimeEmployee = new PartTimeEmployee() { Id = 1001, Name = "Ahmed Ashraf", Age = 25, HourRate = 250 };

            //ProcessEmployee(PartTimeEmployee); // Iam Part Time Employee!
            //                                   // PartTimeEmployee => Id = 1001, Name = Ahmed Ashraf, Age = 25, HourRate = 250

            #endregion

            #region  Ex03 

            #region Ex03.1 - Binding [this is Reference "fullTimeEmployee" from Parent "Employee" refer to object "new FullTimeEmployee()" of type Child "FullTimeEmployee"]

            //Employee fullTimeEmployee = new FullTimeEmployee() { Id = 1000, Name = "Eslam Elsaadany", Age = 22, Salary = 10_000 };

            //ProcessEmployee(fullTimeEmployee); // Iam Employee!
            //                                   // FullTimeEmployee => Id = 1000, Name = Eslam Elsaadany, Age = 22, Salary = $10,000.00
            #endregion

            #region Ex03.2 - Binding [this is Reference "partTimeEmployee" from Parent "Employee" refer to object "new PartTimeEmployee()" of type Child "PartTimeEmployee"]

            //Employee partTimeEmployee = new PartTimeEmployee() { Id = 1001, Name = "Ahmed Ashraf", Age = 25, HourRate = 250 };

            //ProcessEmployee(partTimeEmployee); // Iam Employee!
            //                                   // PartTimeEmployee => Id = 1001, Name = Ahmed Ashraf, Age = 25, HourRate = 250
            #endregion

            #endregion

            #endregion

            #region Part 12 More Practice On Binding

            #region Ex01 - TypeA typeA = new TypeC(1, 2, 3); - Binding

            //TypeA typeA = new TypeC(1, 2, 3);
            //typeA.A = 11;// "typeA" can see only the members of class "TypeA" inside class "TypeC" which are ( A,MyFunc01(),MyFunc02() ). 
            ////typeA.B = 12;// "typeA" can't see the "B" which is property of class "TypeB" Inside class "TypeC".
            ////typeA.C = 15;// "typeA" can't see the "C" which is property of class "TypeC" Inside class "TypeC".

            //typeA.MyFunc01();// MyFunc01 => Iam Base [Parent] => [Because it's static binded method ( Binded based on reference Type "TypeA" )].
            //typeA.MyFunc02();// MyFunc02 => TypeC: A = 1,B = 2, C = 3 => [because it's dynamic binded method ( Binded based on object Type "TypeC" )] 

            #endregion

            #region Ex02 - TypeB typeB = new TypeC(1, 2, 3); - Binding

            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 11;// "typeB" can see only the members of class "TypeB" inside class "TypeC" which are ( A,B,MyFunc01(),MyFunc02() ). 
            //typeB.B = 12;// "typeB" can see the "B" which is property of class "TypeB" Inside class "TypeC".
            ////typeB.C = 15;// "typeB" can't see the "C" which is property of class "TypeC" Inside class "TypeC".

            //typeB.MyFunc01();// MyFunc01 => Iam Derived [Child] => [Because it's static binded method ( Binded based on reference Type "TypeB" )].
            //typeB.MyFunc02();// MyFunc02 => TypeC: A = 1,B = 12, C = 3 => [because it's dynamic binded method ( Binded based on object Type "TypeC" )] 

            #endregion

            #region Ex03 - TypeC typeC = new TypeC(1, 2, 3); - No Binding

            //TypeC typeC = new TypeC(1, 2, 3);
            //typeC.A = 11;// "typeC" can see only the members of class "TypeC" inside class "TypeC" which are ( A,B,C,MyFunc01(),MyFunc02() ). 
            //typeC.B = 12;// "typeC" can see the "B" which is property of class "TypeB" Inside class "TypeC".
            //typeC.C = 15;// "typeC" can see the "C" which is property of class "TypeC" Inside class "TypeC".

            //typeC.MyFunc01();// MyFunc01 => Iam Derived [GrandChild] - No Binding
            //typeC.MyFunc02();// MyFunc02 => TypeC: A = 11,B = 12, C = 15 - No Binding

            #endregion

            #region Ex04
            
            //TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5);

            //typeA.MyFunc02();// MyFunc02 => TypeC: A = 1,B = 2, C = 3
            //typeB.MyFunc02();// MyFunc02 => TypeC: A = 1,B = 2, C = 3
            //typeC.MyFunc02();// MyFunc02 => TypeC: A = 1,B = 2, C = 3

            //Console.WriteLine("\n= After Break The Chain of overriding in class \"TypeD\" =\n");

            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);

            //typeD.MyFunc02();// MyFunc02 => TypeE: A = 1,B = 2, C = 3, D = 4, E = 5 

            #endregion

            #endregion

        }

    }
}
