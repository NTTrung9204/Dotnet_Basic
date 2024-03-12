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

        public static bool CompareDTB(object o1, object o2){
            return ((SV)o1).DTB > ((SV)o2).DTB;
        }
        public static bool CompareName(object o1, object o2){
            if(String.Compare(((SV)o1).Name, ((SV)o2).Name) > 0){
                return true;
            }
            return false;
        }
    }
}