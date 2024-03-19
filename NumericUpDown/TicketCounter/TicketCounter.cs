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
    public partial class TicketCounter : Form
    {
        private const decimal ZooPrice = 20.00M;
        private const decimal RollerCoasterPrice = 15.00M;
        private const decimal WaterSlidePrice = 12.50M;

        public TicketCounter()
        {
            InitializeComponent();
            totalLabel.Text = $"Total Cost: $0.00";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int zooTickets = (int)zooNumericUpDown.Value;
            int rollerCoasterTickets = (int)rollerCoasterNumericUpDown.Value;
            int waterSlideTickets = (int)waterSlideNumericUpDown.Value;

            decimal totalCost = (zooTickets * ZooPrice) + (rollerCoasterTickets * RollerCoasterPrice) + (waterSlideTickets * WaterSlidePrice);

            totalLabel.Text = $"Total Cost: ${totalCost:N2}";
        }
    }
}
