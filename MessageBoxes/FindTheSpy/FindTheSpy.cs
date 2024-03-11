using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class FindTheSpy : Form
    {
        public FindTheSpy()
        {
            InitializeComponent();
        }
        public bool IsSpyNumber(int number)
        {
            int sum = 0;
            int product = 1;

            while (number != 0)
            {
                sum += number % 10;
                product *= number % 10;
                number /= 10;
            }

            return sum == product;
        }
        private void FirstButton_Click(object sender, EventArgs e)
        {
            if (IsSpyNumber(Convert.ToInt32(FirstButton.Text)))
            {
                MessageBoxWrapper.Show("Spy found!");
            }
        }

        private void SecondButton_Click(object sender, EventArgs e)
        {
            if (IsSpyNumber(Convert.ToInt32(SecondButton.Text)))
            {
                MessageBoxWrapper.Show("Spy found!");
            }
        }

        private void ThirdButton_Click(object sender, EventArgs e)
        {
            if (IsSpyNumber(Convert.ToInt32(ThirdButton.Text)))
            {
                MessageBoxWrapper.Show("Spy found!");
            }
        }

        private void FourthButton_Click(object sender, EventArgs e)
        {
            if (IsSpyNumber(Convert.ToInt32(FourthButton.Text)))
            {
                MessageBoxWrapper.Show("Spy found!");
            }
        }

        private void FifthButton_Click(object sender, EventArgs e)
        {
            if (IsSpyNumber(Convert.ToInt32(FifthButton.Text)))
            {
                MessageBoxWrapper.Show("Spy found!");

            }
        }

        private void SixthButton_Click(object sender, EventArgs e)
        {
            if (IsSpyNumber(Convert.ToInt32(SixthButton.Text)))
            {
                MessageBoxWrapper.Show("Spy found!");
            }
        }

        private void SeventhButton_Click(object sender, EventArgs e)
        {
            if (IsSpyNumber(Convert.ToInt32(SeventhButton.Text)))
            {
                MessageBoxWrapper.Show("Spy found!");
            }
        }

        private void EighthButton_Click(object sender, EventArgs e)
        {
            if (IsSpyNumber(Convert.ToInt32(EighthButton.Text)))
            {
                MessageBoxWrapper.Show("Spy found!");
            }
        }

        private void NinthButton_Click(object sender, EventArgs e)
        {
            if (IsSpyNumber(Convert.ToInt32(NinthButton.Text)))
            {
                MessageBoxWrapper.Show("Spy found!");
            }
        }

        private void TenthButton_Click(object sender, EventArgs e)
        {
            if (IsSpyNumber(Convert.ToInt32(TenthButton.Text)))
            {
                MessageBoxWrapper.Show("Spy found!");
            }
        }
    }
}
