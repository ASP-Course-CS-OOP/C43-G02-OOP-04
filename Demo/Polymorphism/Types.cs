using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
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

        #region onstructors
        
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
}
