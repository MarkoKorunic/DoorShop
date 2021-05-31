using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorShop
{
    public partial class StartScreenForm : Form
    {
        public StartScreenForm()
        {
            InitializeComponent();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Form newOrder = new NewOrderForm();
            newOrder.Owner = this;
            newOrder.Show();
            this.Hide();

        } 
    }
}
