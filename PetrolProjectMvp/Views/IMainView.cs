using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolProjectMvp.Views
{
    public interface IMainView
    {

        EventHandler<EventArgs> SelectedItem { get; set; }
        EventHandler<EventArgs> PayEvent { get; set; }
        Guna2ComboBox combobox { get; set; }
        Label price { get; set; }
        Guna2Button pay_button { get; set; }
        MaskedTextBox maskedtextbox { get; set; }
        Label totalpaymentmainview { get; set; }

    }
}
