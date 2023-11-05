using System.Windows.Input;
using Windows.Services.Maps;

namespace uwp_mvvm.viewmodels
{
    class MainViewModel : MainViewModelBase
    {
        private Calculator _calculator = null;
        private int _result = 0;
        private int _value1 = 0;
        private int _value2 = 0;
        private bool _isAddChecked = false;
        private bool _isSubChecked = false;
        private bool _isMulChecked = false;
        private bool _isDivChecked = false;
        private bool _isAnyRadioBtnCheck = false;

        public bool IsAnyRadioBtnCheck
        {
            get { return _isAnyRadioBtnCheck; }
            set
            {
                _isAnyRadioBtnCheck = value;
                OnPropertyChanged(nameof(IsAnyRadioBtnCheck));
            }
        }

        public int Value1
        {
            get { return _value1; }
            set
            {
                _value1 = value;
                OnPropertyChanged("Value1");
            }
        }

        public int Value2
        {
            get { return _value2; }
            set
            {
                _value2 = value;
                OnPropertyChanged(nameof(Value2));
            }
        }

        public int Result
        {
            get { return _result; }
            set
            {
                if (value != _result)
                {
                    _result = value;
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public bool IsAddChecked
        {
            get { return _isAddChecked; }
            set
            {
                if (_isAddChecked != value)
                {
                    _isAddChecked = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged(nameof(IsAddChecked));
                }
            }
        }

        public bool IsSubChecked
        {
            get { return _isSubChecked; }
            set
            {
                if (_isSubChecked != value)
                {
                    _isSubChecked = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged(nameof(IsSubChecked));
                }
            }
        }

        public bool IsMulChecked
        {
            get { return _isMulChecked; }
            set
            {
                if (_isMulChecked != value)
                {
                    _isMulChecked = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged(nameof(IsMulChecked));
                }
            }
        }

        public bool IsDivChecked
        {
            get { return _isDivChecked; }
            set
            {
                if (_isDivChecked != value)
                {
                    _isDivChecked = value;
                    IsAnyRadioBtnCheck = true;
                    OnPropertyChanged(nameof(IsDivChecked));
                }
            }
        }

        public ICommand OkButtonClicked
        {
            get
            {
                return new DelegateCommand(FindResult);
            }
        }

        public void FindResult()
        {
            _calculator = new Calculator(Value1, Value2);

            if (IsAddChecked)
            {
                Result = _calculator.Add();
            }

            if (IsSubChecked)
            {
                Result = _calculator.Sub();
            }

            if (IsMulChecked)
            {
                Result = _calculator.Mul();
            }

            if (IsDivChecked)
            {
                Result = _calculator.Div();
            }
        }
    }
}