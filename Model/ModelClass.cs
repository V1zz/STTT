namespace Model
{
    public interface IModelClass
    {
        int[] Arr { get; set; }
        int[] Arr1 { get; set; }
        //int[] Instance { get; set; }
        //int[] Instance1 { get; set; }
        IModelClass GetRecordInModel(IModelClass model);

    }
    public class ModelClass : IModelClass
    {
        private int[] _arr;
        private int[] _arr1;

        public int[] Arr
        {
            get => _arr;
            set
            {
                if ( value.Length == _arr.Length)
                {
                    var t = 0;
                    for (int i = 0; i < _arr.Length; i++)
                    {
                        t = _arr[i];
                        _arr[i] = value[i];
                        value[i] = t;
                    }
                }
            }
        }
        public int[] Arr1
        {
            get => _arr1;
            set
            {
                if (value.Length == _arr1.Length)
                {
                    var t = 0;
                    for (int i = 0; i < _arr1.Length; i++)
                    {
                        t = _arr1[i];
                        _arr1[i] = value[i];
                        value[i] = t;
                    }
                }
            }
        }

        public ModelClass()
        {
            this._arr = new int[30];
            this._arr1 = new int[30];
        }
        public ModelClass(int length)
        {
            this._arr = new int[length];
            this._arr1 = new int[length];
        }

        //public int[] Instance
        //{
        //    get
        //    {
        //        return _arr;
        //    }
        //    set
        //    {
        //        if (value.Length > 0)
        //            _arr = value;
        //    }
        //}
        //public int[] Instance1
        //{
        //    get
        //    {
        //        return _arr;
        //    }
        //    set
        //    {
        //        if (value.Length > 0)
        //            _arr = value;
        //    }
        //}

        public IModelClass GetRecordInModel(IModelClass model)
        {
            //this._arr = model._arr;
            //this.Arr = model.Arr;
            return model;
        }

        public void Reset()
        {
            _arr = new int[_arr.Length];
            _arr1 = new int[_arr1.Length];
        }
    }
}
