namespace Model
{
    public interface IModelClass
    {
        int[] Arr { get; set; }
        int[] Instance { get; set; }
        void GetRecordInModel(ModelClass model);

    }
    public class ModelClass : IModelClass
    {
        private int[] _arr;

        public int[] Arr { get; set; }

        public ModelClass()
        {
            this._arr = new int[25];
            this.Arr = new int[25];
        }
        public ModelClass(int length)
        {
            this._arr = new int[length];
            this.Arr = new int[length];
        }

        public int[] Instance
        {
            get
            {
                return _arr;
            }
            set
            {
                if (value.Length > 0)
                    _arr = value;
            }
        }

        public void GetRecordInModel(ModelClass model)
        {
            this._arr = model._arr;
            this.Arr = model.Arr;
        }

        public void Reset()
        {
            _arr = new int[_arr.Length];
            Arr = new int[Arr.Length];
        }
    }
}
