using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    class InitiateCalculation : Calculator
    {
        protected int currentSymbNum = 0; // номер текущего элемента в строке
        protected char scanSymbol; // текущий обрабатываемый символ
        protected string origin; //строка с выражением
        protected bool RightVersion = true; 
        protected Hashtable letters = new Hashtable(); // коллекция, хранящая переменные и их значения
        /// <summary>
        /// Функция инициализации вычисления выражения
        /// </summary>
        public InitiateCalculation(ref string origin, ref string poland)
        {
            scanSymbol = origin[currentSymbNum];
            this.origin = origin;
            Expression(ref Root); //разбор выражения
            if ( (Root != null) && (RightVersion))
            {
                if (currentSymbNum == -1)
                {
                    origin = Calculate(Root).ToString();
                    Poland(Root, ref poland); // польская форма
                }
                else
                {
                    Message("Error: string does't end properly");
                    origin = "";
                }
            }
            else
            {
                origin = "";
            }
        }
        public BinTreeNode InitiationBinTreeNode(BinTreeNode root, char c)
        {
            root = new BinTreeNode();
            root.Info = c.ToString();
            return root;
        }
        public BinTreeNode AddToBinTreeNode(BinTreeNode root, char value)
        {
            root.Info += value;
            return new BinTreeNode(root.Info);
        }
        #region BuildTree
        /// <summary>
        /// разбор выражения
        /// </summary>
        /// <param name="Root"></param>
        void Expression(ref BinTreeNode Root)
        {
            BinTreeNode o1 = new BinTreeNode();
            BinTreeNode o2 = new BinTreeNode();
            Root = null;
            if ((char.IsDigit(scanSymbol)) || (scanSymbol == '(') || char.IsLetter(scanSymbol))
            {
                Addend(ref o1); // разбор 1 слагаемого
                while (((scanSymbol == '+') || (scanSymbol == '-')) && (currentSymbNum != -1))
                {
                    Root = InitiationBinTreeNode(Root, scanSymbol); // ввод значения + или - в дерево
                    Root.Left = o1;
                    NextSymbol();
                    if (currentSymbNum != -1)
                        Addend(ref o2); //разбор 2 слагаемого
                    Root.Right = o2;
                    o1 = Root;
                }
                if (Root == null)
                    Root = o1;
            }
            else
            {  // обработка ошибки
                Message("Error: wrong beggining of the expression");
                currentSymbNum = -1;
                RightVersion = false;
            }

        }
        /// <summary>
        /// разбор слагаемого
        /// </summary>
        /// <param name="Root"></param>
        void Addend(ref BinTreeNode Root)
        {
            BinTreeNode o1 = new BinTreeNode();
            BinTreeNode o2 = new BinTreeNode();
            if ((char.IsDigit(scanSymbol)) || (scanSymbol == '(') || char.IsLetter(scanSymbol))
            {
                Root = null;
                Factor(ref o1); // разбор 1 множителя
                while (((scanSymbol == '*') || (scanSymbol == '/')) && (currentSymbNum != -1))
                {
                    Root = InitiationBinTreeNode(Root, scanSymbol); // запись знака * / в дерево разбора
                    Root.Left = o1;
                    NextSymbol();
                    if (currentSymbNum != -1)
                        Factor(ref o2); // разбор 2 множителя
                    Root.Right = o2;
                    o1 = Root;
                }
                if (Root == null)
                    Root = o1;
            }
            else
            {
                Message("Error: wrong beggining of the addiction");
                currentSymbNum = -1;
                RightVersion = false;
            }
        }
        /// <summary>
        /// разбор множителя
        /// </summary>
        /// <param name="Root"></param>
        void Factor (ref BinTreeNode Root)
        {
            if (char.IsDigit(scanSymbol))
            {
                Number(ref Root); // начало разбора числа       
            }
            else
            {
                if (char.IsLetter(scanSymbol))
                {
                    Letter(ref Root); //начало разбора переменной
                }
                else
                {
                    if (scanSymbol == '(') // обработка выражения со скобками
                    {
                        NextSymbol();
                        if (currentSymbNum != -1)
                            Expression(ref Root); 
                        if ((currentSymbNum != -1) && (scanSymbol == ')'))
                            NextSymbol();
                        else
                        {
                            Message("Error: There is no closing bracket!"); currentSymbNum = -1;
                            RightVersion = false;
                        }
                    }
                    else
                    {
                        Message("Error: wrong beggining of the factor!"); currentSymbNum = -1;
                        RightVersion = false;
                    }
                }

            }
        }
        /// <summary>
        /// разбор числа
        /// </summary>
        /// <param name="Root"></param>
        void Number(ref BinTreeNode Root)
        {
            IntPart(ref Root); // целое число
            if (scanSymbol == '.' || scanSymbol == ',')
            {
                if (scanSymbol == '.')
                    scanSymbol = ',';
                Root = AddToBinTreeNode(Root, scanSymbol);
                NextSymbol();
                if (currentSymbNum != -1)
                {
                    while ((currentSymbNum != -1) && (char.IsDigit(scanSymbol))) // разбор вещественной части
                    {
                        Root = AddToBinTreeNode(Root, scanSymbol);
                        NextSymbol();
                    }
                    if ((scanSymbol == 'e') || (scanSymbol == 'E')) 
                    {
                        NextSymbol();
                        ExponentialPart(ref Root);// разбор экспоненциальной части
                    }

                 }
                else
                {
                    Message("Error: String ends ocasionally!"); currentSymbNum = -1;
                    RightVersion = false;
                }

            }
        }      
       /// <summary>
       /// разбор целой части числа
       /// </summary>
       /// <param name="Root"></param>
        void IntPart(ref BinTreeNode Root)
        {
            Root = InitiationBinTreeNode(Root, scanSymbol); //ввод числа в дерево
            NextSymbol(); 
            while ( (char.IsDigit(scanSymbol)) && (currentSymbNum != -1)) //формирование числа с более 2 знаками
            {
                Root = AddToBinTreeNode(Root, scanSymbol);
                NextSymbol();
            }
        }
        /// <summary>
        /// разбор переменной
        /// </summary>
        /// <param name="Root"></param>
        void Letter (ref BinTreeNode Root)
        {
            Root = InitiationBinTreeNode(Root, scanSymbol); // записи 1 переменной в дерево
            NextSymbol();
            while ( ( (char.IsLetter(scanSymbol)) || (char.IsDigit(scanSymbol)) ) && (currentSymbNum != -1) ) // создание переменной с более чем 1 знак
            {
                Root = AddToBinTreeNode(Root, scanSymbol);
                NextSymbol();
            }
            if (letters.Contains(Root.Info)) // сверка с коллекцией, препятствие заведения одинаковых переменных с разгными хначениями
            {
                Root.Info = letters[Root.Info].ToString();
            }
            else
            {
                int strToNum = 0;
                InputBox input = new InputBox(Root.Info);
                input.ShowDialog();
                strToNum = input.GetLetter();
                letters.Add(Root.Info, strToNum);
                Root.Info = strToNum.ToString();
            }
        }
        /// <summary>
        /// разбор экспоненциальной части числа
        /// </summary>
        /// <param name="Root"></param>
        void ExponentialPart(ref BinTreeNode Root)
        {
                try
                {
                    BinTreeNode Root1 = new BinTreeNode();
                    if (scanSymbol == '+' || scanSymbol == '-')
                    {
                        if (scanSymbol == '-')
                            Root1 = InitiationBinTreeNode(Root, scanSymbol);
                        NextSymbol();
                    }
                    while ((char.IsDigit(scanSymbol)) && (currentSymbNum != -1))
                    {
                        Root1 = AddToBinTreeNode(Root1, scanSymbol);
                        NextSymbol();
                    }
                    Root.Info = (Convert.ToDouble(Root.Info) * Math.Pow(10, Convert.ToDouble(Root1.Info))).ToString();
                }
                catch
                {
                  //  Message("Error: wrong beginning of the exponential part");
                }
        }
        void NextSymbol() //переход к новому символу в выражении, обрабатывается внешне
        {
            if (currentSymbNum < origin.Length-1)
            {
                currentSymbNum++;
                scanSymbol = origin[currentSymbNum];
            }
            else
            {
                currentSymbNum = -1; // обозначение окончания разбора
            }
        }
        #endregion
        #region CalculateTree
        /// <summary>
        /// Начало вычисления выражения по построенному дереву операций
        /// </summary>
        /// <param name="Root"></param>
        /// <returns></returns>
        private double Calculate(BinTreeNode Root)
        {
            int res=0;
            double resD = 0;
            if (Int32.TryParse(Root.Info, out res))
                return (double)res;
            else
                if (Double.TryParse(Root.Info, out resD))
                return resD;
            else
                if (Root.Info == "+")
                return Calculate(Root.Left) + Calculate(Root.Right);
            else
                    if (Root.Info == "-")
                return Calculate(Root.Left) - Calculate(Root.Right);
            else
                        if (Root.Info == "*")
                return Calculate(Root.Left) * Calculate(Root.Right);
            else
                            if (Root.Info == "/")
                return Calculate(Root.Left) / Calculate(Root.Right);
            else
            {
                Message("Error: unknown command to calculate");
                return 0;
            }
        }
        #endregion
        /// <summary>
        /// Представление выражения в виде обратной польской запись
        /// </summary>
        /// <param name="node"></param>
        /// <param name="s"></param>
        static void Poland(BinTreeNode node, ref string s)
        {
            if (node != null)
            {
                // обойти левое поддерево 
                Poland(node.Left, ref s);
                Poland(node.Right, ref s);

                s += node.Info;// обойти правое поддерево 
            }
        }

    }
}
