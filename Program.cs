namespace _NH14
{
    class Program
    {
        static void HV(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void A(out int x)
        {
            x = 5;
        }
        static void Main(string[] args)
        {
            // MyClass f1 = new MyClass();
            // f1.A1(); 
            // f1.B1();

            // KClass kc = new KClass();
            // IFile1 f1 = kc;
            // IFile2 f2 = kc;
            // f1.A1(); f1.B1();
            // f2.A2(); f2.B2();

            // UClass u = new UClass();
            // IFile1 f1 = u;
            // IFile3 f3 = u;
            // f1.A1(); f3.A1();

            // TClass t = new TClass();
            // IFile1 f1t = t;
            // IFile3 f3t = t;
            // f1t.A1(); f3t.A1();

            // try{
            //     int a = 5;
            //     int b = 0;
            //     Console.WriteLine(a/b);
            // }
            // catch(DivideByZeroException e){
            //     Console.WriteLine("\nDivide by zero " + e.Message);
            // }
            // catch(Exception e){
            //     Console.WriteLine("\nException " + e.Message);
            // }
            // finally{
            //     Console.WriteLine("Finally");
            // }
        }
    }
}