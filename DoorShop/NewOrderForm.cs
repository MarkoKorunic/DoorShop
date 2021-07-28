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
        public Door door { get; set; }
        public Customer customer { get; set; }
        

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
            door.doorColor = (DoorColor)Enum.Parse(typeof(DoorColor), DoorColorListBox.Text);
            door.frameColor = (FrameColor)Enum.Parse(typeof(FrameColor), FrameColorListBox.Text);
            door.accesoriesColor = (AccesoriesColor)Enum.Parse(typeof(AccesoriesColor), AccesoriesColorListBox.Text);
            door.fireproofLevel = (FireproofLevel)Enum.Parse(typeof(FireproofLevel), FireproofLevelListbox.Text);
            door.antismoke = (Antismoke)Enum.Parse(typeof(Antismoke), AntiSmokeListBox.Text);

            customer.customerName = customerTextbox.Text;
            customer.doors.Add(door);
            

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
            AddToCart(door, customer);
        }

        public void PopulateCartListView()
        {
            CartListView.View = View.Details;
            CartListView.Columns.Add("Door Type");
            CartListView.Columns.Add("Door Color");
            CartListView.Columns.Add("Height");
            CartListView.Columns.Add("Width");
            CartListView.Columns.Add("Quantity");
            CartListView.Columns.Add("Price");

        }
    }

   
}
