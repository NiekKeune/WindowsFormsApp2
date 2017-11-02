using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Invert_Click(object sender, EventArgs e)
        {

        }

        private void Comma_Click(object sender, EventArgs e)
        {
            input += ",";
        }

        private void Equals_Click(object sender, EventArgs e)
        {

        }
        // Save
        private void Zero_Click(object sender, EventArgs e)
        {
            input += "0";
        }

        private void One_Click(object sender, EventArgs e)
        {
            input += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            input += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            input += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            input += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            input += "5";
        }
        
        private void Six_Click(object sender, EventArgs e)
        {
            input += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            input += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            input += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            input += "9";
        }

        private void Fraction_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void Percentage_Click(object sender, EventArgs e)
        {

        }

        private void MarkUp_Click(object sender, EventArgs e)
        {

        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {

        }

        private void Root_Click(object sender, EventArgs e)
        {

        }

        private void Backspace_Click(object sender, EventArgs e)
        {

        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {

        }

        private void MemoryRecall_Click(object sender, EventArgs e)
        {

        }

        private void MemoryAdd_Click(object sender, EventArgs e)
        {

        }

        private void MemorySubtract_Click(object sender, EventArgs e)
        {

        }

        private void MemoryStore_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Testing_Click(object sender, EventArgs e)
        {

        }
    }
}
