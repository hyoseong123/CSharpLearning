using NewCalculator_HHS.ViewModel;
using NewCalculator_MainProgram.Model.Base;
using System;
using System.Collections.Generic;

namespace NewCalculator_HHS.Model
{
    class MainModel : BaseModel
    {
        private static MainModel mainModel;
        private static MainViewModel mainViewModel;

        private static string _subLabelContentBase;
        private static decimal _mainLabelContentBase;

        public static MainModel GetInstance(MainViewModel ViewModel)
        {
            if (mainModel == null)
            {
                mainModel = new MainModel();
                mainViewModel = ViewModel;
            }

            return mainModel;
        }

        public decimal MainLabelContentBase
        {
            get { return _mainLabelContentBase; }
            set
            {
                _mainLabelContentBase = value;

                mainViewModel.MainLabelContent = MainLabelContentBase.ToString();

                OnPropertyChanged(nameof(MainLabelContentBase));
            }
        }

        public string SubLabelContentBase
        {
            get { return _subLabelContentBase; }
            set
            {
                _subLabelContentBase += value;

                mainViewModel.SubLabelContent = SubLabelContentBase;

                OnPropertyChanged(nameof(SubLabelContentBase));
            }
        }

        public void SubClear()
        {
            _subLabelContentBase = null;
        }
    }
}
