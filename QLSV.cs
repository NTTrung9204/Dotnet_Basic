namespace _NH14
{
    public class QLSV
    {
        private SV[] _sv;
        private int _count;

        private static QLSV _Instance;
        public static QLSV Instance
        {
            get { if (_Instance == null) { _Instance = new QLSV(); } return _Instance; }
            private set { }
        }

        private QLSV()
        {

        }

        public void Add(SV s){
            
        }

        public void addRange(SV[] arr){

        }

        public int IndexOf(SV s){
            int index = -1;
            return index;
        }

        public void RemoveAt(int index){
            if(index >=0 && index < _count){

            }
        }

        public void Remove(SV s){

        }

        public override string ToString()
        {
            string s = " ";
            foreach(SV i in _sv){
                s += i.ToString() + '\n';
            }
            return s;
        }

        public void Update(SV s){
            for(int i = 0; i < _count; i++){
                if(s.MSSV == _sv[i].MSSV){

                }
            }
        }

    }
}