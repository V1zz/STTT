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
            imodel.Arr1 = RandMy.GetRandomArray(imodel.Arr1);
            imodel.Arr = RandMy.GetRandomArray(imodel.Arr);
        }

        public int[] ModelArr => imodel.Arr;
        public int[] ModelArr1 => imodel.Arr1;

        public void BubbleSortMethod()
        {
            var model = new ModelClass();
            model.Arr = BubbleSort.BSort(imodel.Arr);
            model.Arr1 = BubbleSort.BSort(imodel.Arr1);
            imodel = model.GetRecordInModel(model);
        }
    }
}
