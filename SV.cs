namespace _NH14
{
    public class SV{

        public int MSSV {get; set;}
        public string Name {get; set;}
        public double DTB {get; set;}

        public virtual void show()
        {
            Console.WriteLine("MSSV = " + MSSV + ", Name = " + Name + ", DTB = " + DTB);
        }

        public override string ToString()
        {
            return "MSSV = " + MSSV + ", Name = " + Name + ", DTB = " + DTB;
        }
    }
}