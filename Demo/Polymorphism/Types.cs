using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{

    #region Part 09 What is Binding

    class TypeA
    {
        #region Properties

        public int A { get; set; }

        #endregion

        #region Constructors

        public TypeA(int a)
        {
            A = a;
        }

        #endregion

        #region Methods

        public void MyFunc01()
        {
            Console.WriteLine("MyFunc01 => TypeA: Iam Base [Parent]");
        }
        public virtual void MyFunc02()
        {
            Console.WriteLine($"MyFunc01 => TypeA : A = {A}");
        }

        #endregion
    }

    class TypeB : TypeA
    {

        #region Properties

        public int B { get; set; }

        #endregion

        #region Constructors

        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }

        #endregion

        #region Methods

        //You can't override the "MyFunc01()" method to add new behavior to it, because the parent "TypeA" not mark it as virtual method, but if you need to add new behavior to it,
        //you can make new method with same name and hide the inherited method => using "new" keyword.
        public new void MyFunc01() // Static Binded Method [Because new Keyword]
        {
            Console.WriteLine("MyFunc01 => TypeB: Iam Derived [Child]");
        }

        //Apply Overriding using "override" Keyword => But Method "MyFunc02()" must be non-private and virtual inside parent class to make override on it.
        public override void MyFunc02() // // Dynamic Binded Method [Because override Keyword]
        {
            Console.WriteLine($"MyFunc02 => TypeB: A = {A}, B = {B}"); ;
        }

        #endregion

    }

    class TypeC : TypeB
    {

        #region Properties

        public int C { get; set; }

        #endregion

        #region Constructors

        public TypeC(int a, int b , int c) : base(a,b)
        {
            C = c;
        }

        #endregion

        #region Methods

        public new void MyFunc01()
        {
            Console.WriteLine("MyFunc01 => TypeC: Iam Derived [GrandChild]");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"MyFunc02 => TypeC: A = {A},B = {B}, C = {C}") ;
        }

        #endregion

    }

    class TypeD : TypeC
    {

        #region Properties

        public int D { get; set; }

        #endregion

        #region Constructors

        public TypeD(int a, int b, int c,int d) : base(a, b,c)
        {
            D = d;
        }

        #endregion

        #region Methods

        public new void MyFunc01()
        {
            Console.WriteLine("MyFunc01 => TypeD: Iam Derived [GrandChild]");
        }

        public virtual new void MyFunc02() // Not override the "MyFunc02()" of parent "TypeC" - Make new version specific to class "TypeD" - Break The Chain of overriding that starts inside "TypeA" with virtual method "virtual MyFunc02()" - and start new chain of overriding starts with "TypeD" virtual new method.
        {
            Console.WriteLine($"MyFunc02 => TypeD: A = {A},B = {B}, C = {C}, D = {D}"); ;
        }

        #endregion

    }

    class TypeE : TypeD
    {

        #region Properties

        public int E { get; set; }

        #endregion

        #region Constructors

        public TypeE(int a, int b, int c,int d, int e) : base(a, b,c,d)
        {
            E = e;
        }

        #endregion

        #region Methods

        public new void MyFunc01()
        {
            Console.WriteLine("MyFunc01 => TypeE: Iam Derived [GrandChild]");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"MyFunc02 => TypeE: A = {A},B = {B}, C = {C}, D = {D}, E = {E}"); ;
        }

        #endregion

    }


    #endregion

    #region  Part 11 Binding is a Behaviour

    abstract class Employee
    {

        #region Properties

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        #endregion

        #region methods

        public void MyFunc01()
        {
            Console.WriteLine("Iam Employee!");
        }

        public virtual void MyFunc02()
        {
            Console.WriteLine($"Employee =>Id = {Id}, Name = {Name}, Age = {Age}");
        }

        #endregion

    }

    class FullTimeEmployee : Employee
    {

        #region Properties

        public decimal Salary { get; set; }

        #endregion

        #region Methods

        public new void MyFunc01()
        {
            Console.WriteLine("Iam Full Time Employee!");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"FullTimeEmployee => Id = {Id}, Name = {Name}, Age = {Age}, Salary = {Salary:c}");
        }

        #endregion

    }

    class PartTimeEmployee : Employee
    {

        #region Properties

        public decimal HourRate { get; set; }

        #endregion

        #region Methods

        public new void MyFunc01()
        {
            Console.WriteLine("Iam Part Time Employee!");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"PartTimeEmployee => Id = {Id}, Name = {Name}, Age = {Age}, HourRate = {HourRate}");
        }

        #endregion

    }

    #endregion

}
