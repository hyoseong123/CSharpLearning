using NewCalculator_HHS.Model;
using NewCalculator_MainProgram.Model.Base;
using System;
using System.Collections.Generic;

namespace NewCalculator_HHS.ViewModel
{
    class MainViewModel : BaseModel
    {
        private static MainModel mainModel;
        private static MainViewModel mainViewModel;

        private string _mainLabelContent;
        private string _subLabelContent;

        private static List<string> _expressionsList = new();

        private bool _isChanged = false;
        private bool _isOverflow = false;

        public bool isDotNumber = false;
        public bool isEqualPressed = false;
        public decimal dotcount = 1;

        public static MainViewModel GetInstance()
        {
            if (mainViewModel == null)
            {
                mainViewModel = new MainViewModel();
                mainModel = MainModel.GetInstance(mainViewModel);
            }

            return mainViewModel;
        }

        public string MainLabelContent
        {
            get { return _mainLabelContent; }
            set
            {
                _mainLabelContent = value;

                OnPropertyChanged(nameof(MainLabelContent));
            }
        }

        public string SubLabelContent
        {
            get { return _subLabelContent; }
            set
            {
                _subLabelContent = value;

                OnPropertyChanged(nameof(SubLabelContent));
            }
        }

        public bool IsChanged
        {
            get { return _isChanged; }
            set
            {
                _isChanged = value;
            }
        }
        public List<string> ExpressionsList
        {
            get { return _expressionsList; }
            set
            {
                _expressionsList = value;
            }
        }

        public bool IsOverflow
        {
            get { return _isOverflow; }
            set
            {
                _isOverflow = value;
            }
        }

        public void InsertNumber(decimal num)
        {
            if (isEqualPressed)
            {
                Clear();
                isEqualPressed = false;
            }

            if (mainModel.MainLabelContentBase.ToString().Contains("."))
            {
                isDotNumber = true;
            }

            if (mainModel.MainLabelContentBase.ToString().Length > 27)
            {
                return;
            }

            decimal insertNumber = 1;

            if (isDotNumber)
            {
                if (dotcount.ToString().Length > 27)
                {
                    return;
                }

                dotcount *= 10;

                if (mainModel.MainLabelContentBase.ToString().Contains("-"))
                {
                    insertNumber = mainModel.MainLabelContentBase - num / dotcount;
                }
                else
                {
                    insertNumber = mainModel.MainLabelContentBase + num / dotcount;
                }

                if (IsChanged)
                {
                    insertNumber *= -1;
                }

                mainModel.MainLabelContentBase = Math.Round(insertNumber, dotcount.ToString().Length);
                return;
            }

            if (mainModel.MainLabelContentBase.ToString().Contains("-"))
            {
                insertNumber = mainModel.MainLabelContentBase * 10 - num;
            }
            else
            {
                insertNumber = mainModel.MainLabelContentBase * 10 + num;
            }

            if (IsChanged)
            {
                insertNumber *= -1;
            }

            mainModel.MainLabelContentBase = insertNumber;
        }

        int openBracketCount = 0;

        public void AddList(string icon)
        {
            if (isEqualPressed)
            {
                ExpressionsList.Clear();
                mainModel.SubClear();
                mainModel.SubLabelContentBase = null;
                _subLabelContent = null;
                isEqualPressed = false;
            }

            isDotNumber = false;

            if (icon == "√")
            {
                if (mainModel.MainLabelContentBase == 0)
                {
                    return;
                }

                if (ExpressionsList.Count > 1)
                {
                    if (ExpressionsList[ExpressionsList.Count - 1] == ")" || ExpressionsList[ExpressionsList.Count - 1] == "!")
                    {
                        ExpressionsList.Add("*");
                        mainModel.SubLabelContentBase = "*";
                    }
                }

                ExpressionsList.Add(icon);
                mainModel.SubLabelContentBase = icon;

                ExpressionsList.Add(mainModel.MainLabelContentBase.ToString());
                mainModel.SubLabelContentBase = mainModel.MainLabelContentBase.ToString();

                NumberClear();

                return;
            }

            if (icon == "!")
            {
                if (mainModel.MainLabelContentBase == 0)
                {
                    return;
                }

                if (ExpressionsList.Count > 1)
                {
                    if (ExpressionsList[ExpressionsList.Count - 1] == ")" || ExpressionsList[ExpressionsList.Count - 2] == "√")
                    {
                        ExpressionsList.Add("*");
                        mainModel.SubLabelContentBase = "*";
                    }
                }

                ExpressionsList.Add(mainModel.MainLabelContentBase.ToString());
                mainModel.SubLabelContentBase = mainModel.MainLabelContentBase.ToString();

                ExpressionsList.Add(icon);
                mainModel.SubLabelContentBase = icon;

                NumberClear();

                return;
            }

            if (icon == "(")
            {
                if (ExpressionsList.Count > 1)
                {
                    if (ExpressionsList[ExpressionsList.Count - 1] == ")" || ExpressionsList[ExpressionsList.Count - 1] == "!" || ExpressionsList[ExpressionsList.Count - 2] == "√")
                    {
                        ExpressionsList.Add("*");
                        mainModel.SubLabelContentBase = "*";
                    }
                }

                ExpressionsList.Add(icon);
                mainModel.SubLabelContentBase = icon;

                openBracketCount++;

                return;
            }

            if (icon == ")")
            {
                if (openBracketCount > 0 && mainModel.MainLabelContentBase == 0)
                {
                    if (ExpressionsList.Count > 1)
                    {
                        if (ExpressionsList[ExpressionsList.Count - 1] == "!" || ExpressionsList[ExpressionsList.Count - 2] == "√")
                        {
                            openBracketCount--;

                            ExpressionsList.Add(icon);
                            mainModel.SubLabelContentBase = icon;
                            return;
                        }
                    }
                    return;
                }

                if (openBracketCount > 0 && mainModel.MainLabelContentBase != 0)
                {
                    openBracketCount--;

                    ExpressionsList.Add(mainModel.MainLabelContentBase.ToString());
                    mainModel.SubLabelContentBase = mainModel.MainLabelContentBase.ToString();

                    ExpressionsList.Add(icon);
                    mainModel.SubLabelContentBase = icon;

                    NumberClear();

                    return;
                }
                else
                {
                    return;
                }
            }

            if (mainModel.MainLabelContentBase == 0)
            {
                if (ExpressionsList.Count > 1)
                {
                    if (ExpressionsList[ExpressionsList.Count - 1] == ")" || ExpressionsList[ExpressionsList.Count - 1] == "!" || ExpressionsList[ExpressionsList.Count - 2] == "√")
                    {
                        ExpressionsList.Add(icon);
                        mainModel.SubLabelContentBase = icon;

                        return;
                    }
                }
                return;
            }

            if (true)
            {
                if (ExpressionsList.Count > 1)
                {
                    if (ExpressionsList[ExpressionsList.Count - 1] == ")" || ExpressionsList[ExpressionsList.Count - 1] == "!" || ExpressionsList[ExpressionsList.Count - 2] == "√")
                    {
                        ExpressionsList.Add("*");
                        mainModel.SubLabelContentBase = "*";
                    }
                }
            }

            ExpressionsList.Add(mainModel.MainLabelContentBase.ToString());
            mainModel.SubLabelContentBase = mainModel.MainLabelContentBase.ToString();

            ExpressionsList.Add(icon);
            mainModel.SubLabelContentBase = icon;

            NumberClear();
        }

        public void Backspace()
        {
            if (mainModel.MainLabelContentBase == 0)
            {
                IsChanged = false;
                isDotNumber = false;
                return;
            }

            if (isDotNumber)
            {
                if (!mainModel.MainLabelContentBase.ToString().Contains("."))
                {
                    isDotNumber = false;
                    return;
                }

                decimal numtmp = mainModel.MainLabelContentBase;

                string[] stringList = numtmp.ToString().Split(".");

                decimal ten = 1;

                for (int i = 0; i < stringList[1].Length; i++)
                {
                    ten *= 10;
                }

                if (mainModel.MainLabelContentBase > 0)
                {
                    numtmp -= decimal.Parse(stringList[1].Substring(stringList[1].Length - 1)) / ten;
                }
                else if (mainModel.MainLabelContentBase < 0)
                {
                    numtmp += decimal.Parse(stringList[1].Substring(stringList[1].Length - 1)) / ten;
                }

                NumberClear();

                dotcount = ten / 10;

                mainModel.MainLabelContentBase = Math.Round(numtmp, ten.ToString().Length - 1);

                return;
            }

            if (mainModel.MainLabelContentBase < 0)
            {
                decimal temp = Math.Floor(mainModel.MainLabelContentBase * -1 / 10);

                NumberClear();

                mainModel.MainLabelContentBase = temp * -1;

                return;
            }

            decimal tmp = Math.Floor(mainModel.MainLabelContentBase / 10);
            NumberClear();
            mainModel.MainLabelContentBase = tmp;
        }

        public void Clear()
        {
            mainModel.MainLabelContentBase = 0;
            MainLabelContent = "";
            _mainLabelContent = "";

            mainModel.SubLabelContentBase = "";
            SubLabelContent = "";
            _subLabelContent = "";

            mainModel.SubClear();
            ExpressionsList.Clear();

            dotcount = 1;

            isDotNumber = false;
            isEqualPressed = false;
            isSpecialIconPressed = false;
            IsChanged = false;
            IsOverflow = false;

            InsertNumber(0);
        }

        public void NumberClear()
        {
            mainModel.MainLabelContentBase = 0;
            dotcount = 1;
        }

        bool isSpecialIconPressed = false;

        public void dot()
        {
            if (!isDotNumber)
            {
                isDotNumber = true;
            }
        }

        public void Change()
        {
            mainModel.MainLabelContentBase *= -1;
        }

        public void Equal()
        {
            if (mainModel.SubLabelContentBase == null || mainModel.SubLabelContentBase == "(")
            {
                return;
            }

            if (isEqualPressed)
            {
                if (ExpressionsList[ExpressionsList.Count - 1] != "!" || ExpressionsList[ExpressionsList.Count - 2] != "√")
                {
                    Clear();
                    isEqualPressed = false;
                    return;
                }
            }

            if (ExpressionsList[ExpressionsList.Count - 1] == "!" || ExpressionsList[ExpressionsList.Count - 2] == "√" || ExpressionsList[ExpressionsList.Count - 1] == ")")
            {
                isSpecialIconPressed = true;
            }

            int openBracketNumber = 0;
            int closeBracketNumber = 0;
            bool isOneBracket = false;

            if (ExpressionsList.Contains("(") && ExpressionsList.Contains(")"))
            {
                foreach (var item in ExpressionsList)
                {
                    if (item == "(")
                    {
                        openBracketNumber++;
                    }
                    if (item == ")")
                    {
                        closeBracketNumber++;
                    }
                }

                if (openBracketNumber > closeBracketNumber)
                {
                    isOneBracket = true;

                    openBracketNumber -= closeBracketNumber;
                }
            }
            else if (ExpressionsList.Contains("("))
            {
                isOneBracket = true;

                foreach (var item in ExpressionsList)
                {
                    if (item == "(")
                    {
                        openBracketNumber++;
                    }
                }
            }

            if (mainModel.MainLabelContentBase != 0)
            {
                if (isSpecialIconPressed)
                {
                    ExpressionsList.Add("*");
                    mainModel.SubLabelContentBase = "*";

                    ExpressionsList.Add(mainModel.MainLabelContentBase.ToString());
                    mainModel.SubLabelContentBase = "" + mainModel.MainLabelContentBase;

                    if (isOneBracket)
                    {
                        for (int i = 0; i < openBracketNumber; i++)
                        {
                            ExpressionsList.Add(")");
                            mainModel.SubLabelContentBase = ")";
                        }
                    }

                    mainModel.SubLabelContentBase = "=";
                }
                else
                {
                    ExpressionsList.Add(mainModel.MainLabelContentBase.ToString());
                    mainModel.SubLabelContentBase = "" + mainModel.MainLabelContentBase;

                    if (isOneBracket)
                    {
                        for (int i = 0; i < openBracketNumber; i++)
                        {
                            ExpressionsList.Add(")");
                            mainModel.SubLabelContentBase = ")";
                        }
                    }

                    mainModel.SubLabelContentBase = "=";
                }
            }
            else if (mainModel.MainLabelContentBase == 0)
            {
                if (!isSpecialIconPressed)
                {
                    return;
                }
                else if (isSpecialIconPressed)
                {
                    if (isOneBracket)
                    {
                        for (int i = 0; i < openBracketNumber; i++)
                        {
                            ExpressionsList.Add(")");
                            mainModel.SubLabelContentBase = ")";
                        }
                    }

                    mainModel.SubLabelContentBase = "=";
                }
            }

            decimal result = 0;

            int openBracketIndex = 0;
            int closeBracketIndex = 0;

            bool isOpenFind = false;
            bool isCloseFind = false;

            bool isHaveBracket = false;

            if (ExpressionsList.Contains("(") && ExpressionsList.Contains(")"))
            {
                isHaveBracket = true;

                while (isHaveBracket)
                {
                    for (int i = 0; i < ExpressionsList.Count; i++)
                    {
                        if (ExpressionsList[i] == "(")
                        {
                            openBracketIndex = i;
                            isOpenFind = true;
                        }
                        if (ExpressionsList[i] == ")")
                        {
                            closeBracketIndex = i;
                            isCloseFind = true;
                        }

                        if (isOpenFind && isCloseFind)
                        {
                            isOpenFind = false;
                            isCloseFind = false;
                            break;
                        }
                    }

                    for (int i = openBracketIndex; i < closeBracketIndex; i++)
                    {
                        if (ExpressionsList[i] == "√")
                        {
                            result = decimal.Parse(Math.Sqrt(double.Parse(ExpressionsList[i + 1])).ToString());

                            ExpressionsList.RemoveAt(i + 1);
                            ExpressionsList.RemoveAt(i);

                            ExpressionsList.Insert(i, result.ToString());
                            closeBracketIndex -= 2;
                            continue;
                        }
                    }

                    for (int i = openBracketIndex; i < closeBracketIndex; i++)
                    {

                        if (ExpressionsList[i] == "^")
                        {
                            result = decimal.Parse(Math.Pow(double.Parse(ExpressionsList[i - 1]), double.Parse(ExpressionsList[i + 1])).ToString());

                            ExpressionsList.RemoveAt(i + 1);
                            ExpressionsList.RemoveAt(i);
                            ExpressionsList.RemoveAt(i - 1);

                            ExpressionsList.Insert(i - 1, result.ToString());
                            closeBracketIndex -= 2;
                            i--;

                            continue;
                        }

                        if (ExpressionsList[i] == "!")
                        {
                            result = decimal.Parse(ExpressionsList[i - 1]);

                            Factorial(result);
                            result = factorialResult;

                            ExpressionsList.RemoveAt(i);
                            ExpressionsList.RemoveAt(i - 1);

                            ExpressionsList.Insert(i - 1, result.ToString());
                            closeBracketIndex -= 2;
                            i--;
                            factorialResult = 1;


                            continue;
                        }

                        if (ExpressionsList[i] == "*")
                        {
                            result = decimal.Parse(ExpressionsList[i - 1]) * decimal.Parse(ExpressionsList[i + 1]);

                            ExpressionsList.RemoveAt(i + 1);
                            ExpressionsList.RemoveAt(i);
                            ExpressionsList.RemoveAt(i - 1);

                            ExpressionsList.Insert(i - 1, result.ToString());

                            closeBracketIndex -= 2;
                            i--;

                            continue;
                        }

                        if (ExpressionsList[i] == "/")
                        {
                            result = decimal.Parse(ExpressionsList[i - 1]) / decimal.Parse(ExpressionsList[i + 1]);

                            ExpressionsList.RemoveAt(i + 1);
                            ExpressionsList.RemoveAt(i);
                            ExpressionsList.RemoveAt(i - 1);

                            ExpressionsList.Insert(i - 1, result.ToString());
                            closeBracketIndex -= 2;
                            i--;

                            continue;
                        }

                        if (ExpressionsList[i] == "%")
                        {
                            result = decimal.Parse(ExpressionsList[i - 1]) * decimal.Parse(ExpressionsList[i + 1]) / 100;

                            ExpressionsList.RemoveAt(i + 1);
                            ExpressionsList.RemoveAt(i);
                            ExpressionsList.RemoveAt(i - 1);

                            ExpressionsList.Insert(i - 1, result.ToString());
                            closeBracketIndex -= 2;
                            i--;

                            continue;
                        }
                    }

                    for (int i = openBracketIndex; i < closeBracketIndex; i++)
                    {
                        if (ExpressionsList[i] == "+")
                        {
                            result = decimal.Parse(ExpressionsList[i - 1]) + decimal.Parse(ExpressionsList[i + 1]);

                            ExpressionsList.RemoveAt(i + 1);
                            ExpressionsList.RemoveAt(i);
                            ExpressionsList.RemoveAt(i - 1);

                            ExpressionsList.Insert(i - 1, result.ToString());
                            closeBracketIndex -= 2;
                            i--;

                            continue;
                        }

                        if (ExpressionsList[i] == "-")
                        {
                            result = decimal.Parse(ExpressionsList[i - 1]) - decimal.Parse(ExpressionsList[i + 1]);

                            ExpressionsList.RemoveAt(i + 1);
                            ExpressionsList.RemoveAt(i);
                            ExpressionsList.RemoveAt(i - 1);

                            ExpressionsList.Insert(i - 1, result.ToString());
                            closeBracketIndex -= 2;
                            i--;

                            continue;
                        }
                    }

                    for (int i = 0; i < ExpressionsList.Count; i++)
                    {
                        if (ExpressionsList[i] == "(")
                        {
                            openBracketIndex = i;
                            isOpenFind = true;
                        }
                        if (ExpressionsList[i] == ")")
                        {
                            closeBracketIndex = i;
                            isCloseFind = true;
                        }

                        if (isOpenFind && isCloseFind)
                        {
                            isOpenFind = false;
                            isCloseFind = false;
                            break;
                        }
                    }

                    ExpressionsList.RemoveAt(openBracketIndex);
                    ExpressionsList.RemoveAt(closeBracketIndex - 1);

                    if (!ExpressionsList.Contains("(") && !ExpressionsList.Contains(")"))
                    {
                        isHaveBracket = false;
                    }
                }
            }

            for (int i = 0; i < ExpressionsList.Count; i++)
            {
                if (ExpressionsList[i] == "√")
                {
                    result = decimal.Parse(Math.Sqrt(double.Parse(ExpressionsList[i + 1])).ToString());

                    ExpressionsList.RemoveAt(i + 1);
                    ExpressionsList.RemoveAt(i);

                    ExpressionsList.Insert(i, result.ToString());

                    continue;
                }
            }

            for (int i = 0; i < ExpressionsList.Count; i++)
            {
                if (ExpressionsList[i] == "!")
                {
                    result = decimal.Parse(ExpressionsList[i - 1]);

                    Factorial(result);
                    result = factorialResult;

                    ExpressionsList.RemoveAt(i);
                    ExpressionsList.RemoveAt(i - 1);

                    ExpressionsList.Insert(i - 1, result.ToString());

                    i--;
                    factorialResult = 1;


                    continue;
                }

                if (ExpressionsList[i] == "%")
                {
                    result = decimal.Parse(ExpressionsList[i - 1]) * decimal.Parse(ExpressionsList[i + 1]) / 100;

                    ExpressionsList.RemoveAt(i + 1);
                    ExpressionsList.RemoveAt(i);
                    ExpressionsList.RemoveAt(i - 1);

                    ExpressionsList.Insert(i - 1, result.ToString());

                    i--;

                    continue;
                }

                if (ExpressionsList[i] == "^")
                {
                    result = decimal.Parse(Math.Pow(double.Parse(ExpressionsList[i - 1]), double.Parse(ExpressionsList[i + 1])).ToString());

                    ExpressionsList.RemoveAt(i + 1);
                    ExpressionsList.RemoveAt(i);
                    ExpressionsList.RemoveAt(i - 1);

                    ExpressionsList.Insert(i - 1, result.ToString());

                    i--;

                    continue;
                }

                if (ExpressionsList[i] == "*")
                {
                    result = decimal.Parse(ExpressionsList[i - 1]) * decimal.Parse(ExpressionsList[i + 1]);

                    ExpressionsList.RemoveAt(i + 1);
                    ExpressionsList.RemoveAt(i);
                    ExpressionsList.RemoveAt(i - 1);

                    ExpressionsList.Insert(i - 1, result.ToString());

                    i--;

                    continue;
                }

                if (ExpressionsList[i] == "/")
                {
                    result = decimal.Parse(ExpressionsList[i - 1]) / decimal.Parse(ExpressionsList[i + 1]);

                    ExpressionsList.RemoveAt(i + 1);
                    ExpressionsList.RemoveAt(i);
                    ExpressionsList.RemoveAt(i - 1);

                    ExpressionsList.Insert(i - 1, result.ToString());

                    i--;

                    continue;
                }
            }

            for (int i = 0; i < ExpressionsList.Count; i++)
            {
                if (ExpressionsList[i] == "+")
                {
                    result = decimal.Parse(ExpressionsList[i - 1]) + decimal.Parse(ExpressionsList[i + 1]);

                    ExpressionsList.RemoveAt(i + 1);
                    ExpressionsList.RemoveAt(i);
                    ExpressionsList.RemoveAt(i - 1);

                    ExpressionsList.Insert(i - 1, result.ToString());

                    i--;

                    continue;
                }

                if (ExpressionsList[i] == "-")
                {
                    result = decimal.Parse(ExpressionsList[i - 1]) - decimal.Parse(ExpressionsList[i + 1]);

                    ExpressionsList.RemoveAt(i + 1);
                    ExpressionsList.RemoveAt(i);
                    ExpressionsList.RemoveAt(i - 1);

                    ExpressionsList.Insert(i - 1, result.ToString());

                    i--;

                    continue;
                }
            }

            NumberClear();

            mainModel.MainLabelContentBase = result;

            isEqualPressed = true;
            isSpecialIconPressed = false;

            if (IsOverflow || double.IsInfinity(double.Parse(mainModel.MainLabelContentBase.ToString())))
            {
                Clear();
                MainLabelContent = "오버플로";
                return;
            }

        }

        static decimal factorialResult = 1;

        private void Factorial(decimal factorialNumber)
        {
            if (factorialNumber == 1)
            {
                return;
            }

            try
            {
                factorialResult *= factorialNumber;
            }
            catch (System.OverflowException)
            {
                IsOverflow = true;
                return;
            }


            Factorial(factorialNumber - 1);
        }
    }
}
