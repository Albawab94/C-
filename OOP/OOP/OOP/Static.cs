using System;

namespace OOP
{
    class Static
    {
        public string name { get; set; }
        private int number { get; set; }
        private static int fixedValue {get;set;}

        public static int staticMethod(Static t)
        {
            fixedValue = 0;
            t.name = "Ryan";
           int num =  t.number = 123;
            return num;
        }
         public static int staticMethod()
        {
            fixedValue = 0;
            Static st = new Static();
            int num = st.number = 123;
            st.name = "Sam";
            return num;
        }

        public static void staticEnDataMethod()
        {
            fixedValue = 4;

            Static st = new Static();
            st.name = "Sam";
            st.number = 9;

            Static st1 = new Static();
            st1.name = "Abdul";
            st1.number = 9;

            st.sum();
            st1.sum();
        }

        public void sum()
        {
            Console.WriteLine("This is the static method and data value field => name " + name + " number " + number + " fixedValue " + fixedValue);
        }
    }
}
