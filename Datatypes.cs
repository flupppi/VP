using System;

namespace RectangleApplication {
    class Rectangle{
        //member variables
        public double length;
        public double width;
        int number = 1;


        public double GetArea(){
            return length * width;
        }

        public void Display(){
            Console.WriteLine("Length: {0}{1}{2}", length, length, with);
            // Writing to console this way is pretty cool and i think it's also less messy to do long texts
            // this way than in Java
            
            Console.WriteLine("Area: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }

        void Method(ref int refArgument){
            refArgument = refArgument + 44;
        }

    }

    class ExecuteRectangle{
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            Method(ref number);
            Console.WriteLine(number);
            // Output: 45
        }
    }

}
