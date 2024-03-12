namespace _NH14
{
    class Program
    {
        // public delegate bool compare(object x, object y);

        // public static void Sort(object[] sv, compare cmp){
        //     for(int i = 0; i < sv.Length - 1; i++){
        //         for(int j = 0; j < sv.Length - 1; j++){
        //             if(cmp(sv[j], sv[j+1])){
        //                 object temp = sv[j];
        //                 sv[j] = sv[j+1];
        //                 sv[j+1] = temp;
        //             }
        //         }
        //     }
        // }
        static void Main(string[] args)
        {
            // SV[] sv = new SV[]{
            //     new SV {MSSV = 1, Name = "NVA", DTB = 3.2} ,
            //     new SV {MSSV = 3, Name = "NVB", DTB = 3.1} ,
            //     new SV {MSSV = 2, Name = "NVC", DTB = 3.4} ,
            // };

            // Sort(sv, SV.CompareName);

            // foreach(SV i in sv){
            //     Console.WriteLine(i);
            // }

            Clock c = new Clock();
            AnalogClock ac = new AnalogClock();
            DigitalClock dc = new DigitalClock();
            c.OnSecondChange += ac.ShowAC;
            c.OnSecondChange += dc.ShowDC;
            c.run();
        }
    }
}