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
    /// <summary>
    /// Специальный класс, реализованный в формах, для задания значений переменных 
    /// </summary>
    public partial class InputBox : Form
    {
        protected int number = 0;
        public InputBox(string info)
        {
            InitializeComponent();
            labelInputBox.Text = "Значение переменной " + info;
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInputBox_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToInt32(textBoxInputBox.Text);
                Close();
            }
            catch
            {
                MessageBox.Show("Error: please, enter a number!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxInputBox.Clear();
                textBoxInputBox.Focus();
            }
        }
        public int GetLetter()
        {
            return number;
        }
    }
}
