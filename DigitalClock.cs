namespace _NH14{
    class DigitalClock{
        public void ShowDC(object  o, EventArgs e){
            DateTime d = DateTime.Now;
            Console.WriteLine(d.Hour + ":" + d.Minute + ":" + d.Second + ":" + d.Millisecond);
        }
    }
}