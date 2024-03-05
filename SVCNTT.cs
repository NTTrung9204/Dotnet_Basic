namespace _NH14{
    class SVCNTT: SV{
        
        public bool LT{get; set;}

        public override void show()
        {
            base.show();
            Console.WriteLine("LT = " + LT);
        }

        public override string ToString()
        {
            return base.ToString() + ", LT = " + LT;
        }
    }
}