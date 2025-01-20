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
            Console.WriteLine("MyFunc01 => Iam Base [Parent]");
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
            Console.WriteLine("MyFunc01 => Iam Derived [Child]");
        }

        //Apply Overriding using "override" Keyword => But Method "MyFunc02()" must be non-private and virtual inside parent class to make override on it.
        public override void MyFunc02() // // Dynamic Binded Method [Because override Keyword]
        {
            Console.WriteLine($"MyFunc02 => TypeB: A = {A}, B = {B}"); ;
        }

        #endregion

    }

    class TypeC : TypeA
    {

        #region Properties

        public int C { get; set; }

        #endregion

        #region Constructors

        public TypeC(int a, int c) : base(a)
        {
            C = c;
        }

        #endregion

        #region Methods

        public new void MyFunc01()
        {
            Console.WriteLine("MyFunc01 => Iam Derived [Child]");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"MyFunc02 => TypeC: A = {A}, C = {C}"); ;
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
