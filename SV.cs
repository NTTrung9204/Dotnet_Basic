using System;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Bai2
{
    public class SV{
        private int _MSSV;
        private string _Name;
        private double _DTB;

        // public int MSSV
        // {
        //     get { return _MSSV; }
        //     set { _MSSV = value; }
        // }

        // public string Name
        // {
        //     get { return _Name; }
        //     set { _Name = value; }
        // }   

        // public double DTB
        // {
        //     get { return _DTB; }
        //     set { _DTB = value; }
        // }

        // public string getName()
        // {
        //     return _Name;
        // }

        // public void setName(string name)
        // {
        //     _Name = name;
        // }

        // public SV()
        // {
        //     _MSSV = 0;
        //     _Name = "NVA";
        //     _DTB = 0.1;
        // }

        // public SV(int mssv, string name, double dtb)
        // {
        //     _MSSV = mssv;
        //     _Name = name;
        //     _DTB = dtb;
        // }

        // public SV(SV sv)
        // {
        //     _MSSV = sv._MSSV;
        //     _Name = sv._Name;
        //     _DTB = sv._DTB;
        // }

        // public void Show(){
        //     Console.WriteLine("MSSV: {0}", _MSSV);
        //     Console.WriteLine("Name: {0}", _Name);
        //     Console.WriteLine("DTB: {0}", _DTB);
        // }

        public int MSSV {get; set;}
        public string Name {get; set;}
        public double DTB {get; set;}

        public override string ToString()
        {
            return "MSSV = " + MSSV + ", Name = " + Name + ", DTB = " + DTB;
        }
    }
}