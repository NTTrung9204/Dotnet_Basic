namespace _NH14{
    public class TClass: IFile1, IFile3
    {
        void IFile1.A1(){
            Console.WriteLine("A1-I1");
        }
        void IFile3.A1(){
            Console.WriteLine("A1-I3");
        }
        public void B1(){
            Console.WriteLine("B1");
        }
        public void B3(){
            Console.WriteLine("B3");
        }
    }
}