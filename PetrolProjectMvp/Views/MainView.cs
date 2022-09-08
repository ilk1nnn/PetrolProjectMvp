using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetrolProjectMvp.Views;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace PetrolProjectMvp
{
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> SelectedItem { get; set; }
        public Guna2ComboBox combobox { get => oilcombobox; set => combobox = value; }
        public Label price { get => priceandtypelbl; set => priceandtypelbl = value; }
        public Guna2Button pay_button { get => guna2Button1; set => pay_button = value; }
        public MaskedTextBox maskedtextbox { get => litr; set => maskedtextbox = value; }
        public EventHandler<EventArgs> PayEvent { get; set; }
        public Label totalpaymentmainview { get => totalpayment; set => totalpayment = value; }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void oilcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem.Invoke(sender, e);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PayEvent.Invoke(sender, e);
        }
    }
}
