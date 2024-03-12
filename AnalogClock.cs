namespace _NH14{
    class AnalogClock{
        public void ShowAC(object  o, EventArgs e){
            DateTime d = DateTime.Now;
            Console.WriteLine(d.Hour + ":" + d.Minute + ":" + d.Second + ":" + d.Millisecond);
        }
        
    }
}