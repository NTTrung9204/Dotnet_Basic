namespace _NH14{
    class Clock{
        public delegate void SecondHandler(Clock c, EventArgs e);
        public event SecondHandler OnSecondChange;
        public void run(){
            while(true){
                Thread.Sleep(1000);
                OnSecondChange(this, new EventArgs());
            }
        }
    }
}