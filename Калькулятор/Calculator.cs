using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Calculator : Form
    {
        protected string expressionStr; // выражение
        protected BinTreeNode Root = new BinTreeNode();
        protected string poland; // выражение в ОПЗ
        public void SetPoland(string poland)
        {
            this.poland = poland;
        }
        public string ExpressionStr // конструктор для строки - выражения
        {
            set { expressionStr = value; }
            get { return expressionStr; }
        }
        public Calculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Интерфейс программы заключенный в регион Interface
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Interface
        private void buttonX_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, "x");
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, "y");
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, 1.ToString());
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, 2.ToString());
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, 3.ToString());
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, 4.ToString());
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, 5.ToString());
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, 6.ToString());
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, 7.ToString());
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, 8.ToString());
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, 9.ToString());
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, 0.ToString());
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, ",");
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, "/");
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, "*");
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, "+");
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, "-");
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void buttonSkobkaLeft_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, "(");
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void buttonSkobkaRight_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, ")");
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBoxCalculationWindow.Clear();
            textBoxCalculationWindow.Focus();
            textBoxCalculationWindow.SelectionStart = textBoxCalculationWindow.Text.Length;
            labelPolandForm.Text = "";
            labelAnswer.Text = "";
        }
        private void buttonE_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length < textBoxCalculationWindow.MaxLength)
            {
                int posTemp = textBoxCalculationWindow.SelectionStart;
                textBoxCalculationWindow.Text = textBoxCalculationWindow.Text.Insert(posTemp, "E");
                textBoxCalculationWindow.Select(posTemp, 0);
                textBoxCalculationWindow.SelectionStart = posTemp + 1;
                textBoxCalculationWindow.Focus();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            textBoxCalculationWindow.Focus();
        }
        #endregion
        /// <summary>
        /// инициализация вычислений варажения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textBoxCalculationWindow.Text.Length != 0)
            {
                ExpressionStr = textBoxCalculationWindow.Text;
                for (int i = 0; i < ExpressionStr.Length; i++) //удаление лишних пробелов в записи выражения
                    if (ExpressionStr[i] == ' ')
                    {
                        ExpressionStr = ExpressionStr.Remove(i, 1);
                        i--;
                    }
                if (ExpressionStr[0] == '-') //обработка минусов в начале выражения и после скобки, внутреннее пребразование (-2+3) в (0-2+3) для обеспечения правильного выражения
                    ExpressionStr = expressionStr.Insert(0, "0");
                for (int i = 0; i < ExpressionStr.Length - 1; i++)
                {
                    if ((ExpressionStr[i] == '(') && (ExpressionStr[i + 1] == '-'))
                        ExpressionStr = expressionStr.Insert(i + 1, "0");
                }
                InitiateCalculation Calc = new InitiateCalculation(ref expressionStr, ref poland);
                labelAnswer.Text = "= " + expressionStr;
                labelPolandForm.Text = "ОПЗ: " + poland;
                poland = "";
            }
            else
            {
                Message("Error: Please, enter an expression!");
                textBoxCalculationWindow.Focus();
            }
        }
        protected void Message(string info) //универсальная функция для вывода системного сообщения для ошибки
        {
            MessageBox.Show(info, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
