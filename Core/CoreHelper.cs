using Model;
using Model.Rand;

namespace Core
{
    public class CoreHelper
    {
        private IModelClass imodel;
        BubbleSort bs;
        public CoreHelper()
        {
            this.imodel = new ModelClass();
            this.bs = new BubbleSort();
            imodel.Instance = RandMy.GetRandomArray(imodel.Instance);
            imodel.Arr = RandMy.GetRandomArray(imodel.Arr);
        }

        public int[] ModelArr => imodel.Arr;
        public int[] ModelInstance => imodel.Instance;

        public void BubbleSortMethod()
        {
            var model = new ModelClass();
            model.Arr = BubbleSort.BSort(imodel.Arr);
            model.Instance = BubbleSort.BSort(imodel.Instance);
            imodel.GetRecordInModel(model);
        }
    }
}
