using System;
using System.Collections.Generic;
using System.Linq;
using PetrolProjectMvp.Views;
using System.Text;
using System.Threading.Tasks;

namespace PetrolProjectMvp.Presenters
{
    public class MainPresenter
    {

        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.SelectedItem += ViewSelectedItem;
            _view.PayEvent += ViewPayEvent;
        }

        private void ViewPayEvent(object sender, EventArgs e)
        {
            if(_view.combobox.SelectedIndex == 0)
            {
                var total = 1.5 * double.Parse(_view.maskedtextbox.Text);
                _view.totalpaymentmainview.Text = $"Total is {total.ToString()} AZN";
                _view.totalpaymentmainview.Visible = true;
            }
            else if (_view.combobox.SelectedIndex == 1)
            {
                var total = 2.2 * double.Parse(_view.maskedtextbox.Text);
                _view.totalpaymentmainview.Text = $"Total is {total.ToString()} AZN";
                _view.totalpaymentmainview.Visible = true;

            }
            if (_view.combobox.SelectedIndex == 2)
            {
                var total = 0.8 * double.Parse(_view.maskedtextbox.Text);
                _view.totalpaymentmainview.Text = $"Total is {total.ToString()} AZN";
                _view.totalpaymentmainview.Visible = true;

            }
        }

        private void ViewSelectedItem(object sender, EventArgs e)
        {
            if (_view.combobox.SelectedIndex == 0)
            {
                _view.price.Text = "AI-92 is 1.50 AZN";
                _view.price.Visible = true;
            }
            else if(_view.combobox.SelectedIndex == 1)
            {
                _view.price.Text = "AI-95 is 2.20 AZN";
                _view.price.Visible = true;
            }
            else if(_view.combobox.SelectedIndex == 2)
            {
                _view.price.Text = "Diesel is 0.80 AZN";
                _view.price.Visible = true;
            }
        }
    }
}
