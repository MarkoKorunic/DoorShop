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
        string errorMsgNmbr = "Please enter a number.";
        

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
            AntiSmokeListBox.DataSource = Enum.GetValues(typeof(Antismoke)).Cast<Antismoke>().ToList();


        }
        public void AddToCart (Door door,Customer customer)
        {
            door.doorType = (DoorType)Enum.Parse(typeof(DoorType), DoorTypeListBox.Text);
            
        }
        

        private void HeightTextbox_Validating(object sender, CancelEventArgs e)
        {
            var height = Convert.ToInt32(HeightTextbox.Text);
            if (string.IsNullOrEmpty(HeightTextbox.Text))
            {
                e.Cancel = true;
                HeightTextbox.Focus();
                errorProvider1.SetError(HeightTextbox, errorMsgNmbr );
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
