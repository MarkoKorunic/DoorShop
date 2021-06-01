using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace DoorShop
{
    public partial class NewOrderForm : Form
    {
       
        public NewOrderForm()
        {
            InitializeComponent();
            Customer customer = new Customer();
            Door door = new Door();
            PopulateLists();


        }

        private void BackToStartButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        
        private void PopulateLists()
        {
            DoorTypeListBox.DataSource = Enum.GetValues(typeof(DoorType)).Cast<DoorType>().ToList();
            DoorColorListBox.DataSource = Enum.GetValues(typeof(DoorColor)).Cast<DoorColor>().ToList();
            FrameColorListBox.DataSource = Enum.GetValues(typeof(FrameColor)).Cast<FrameColor>().ToList();
            AccesoriesColorListBox.DataSource = Enum.GetValues(typeof(AccesoriesColor)).Cast<AccesoriesColor>().ToList();
            FireproofLevelListbox.DataSource = Enum.GetValues(typeof(FireproofLevel)).Cast<FireproofLevel>().ToList();



        }
    }
}
