using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class Hamburger : Form
    {
        public Hamburger()
        {
            InitializeComponent();
        }


        void UpdateTopping()
        {
            UpdateTotalPrice();
            string Toppings = "";

            if (chbFriedOnions.Checked) Toppings += "Fried Onions ,";
            if (chbSauces.Checked) Toppings += "Sauces ,";
            if (chbVegetables.Checked) Toppings += "Vegetables ,";
            if (chbCheese.Checked) Toppings += "Cheese";

            lblTopping.Text = Toppings;
        }
        float CalcSize()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbLarge.Checked)
            {
                return Convert.ToSingle(rbLarge.Tag);

            }
            else
            {
                return Convert.ToSingle(rbMedium.Tag);

            }
        }
        float CalcPatty()
        {
            if (rbBeefPatty.Checked)
            {
                return Convert.ToSingle(rbBeefPatty.Tag);

            }
            else if (rbHalalPatty.Checked)
            {
                return Convert.ToSingle(rbHalalPatty.Tag);


            }
            else if (rbFishPatty.Checked)
            {

                return Convert.ToSingle(rbFishPatty.Tag);

            }
            else if (rbChickenPatty.Checked)
            {

                return Convert.ToSingle(rbChickenPatty.Tag);

            }
            else
                return 0;
        }
        float CalcToping()
        {
            float ToppingPrice = 0;


            if (chbFriedOnions.Checked) ToppingPrice += Convert.ToSingle(chbFriedOnions.Tag);
            if (chbSauces.Checked)      ToppingPrice += Convert.ToSingle(chbSauces.Tag);
            if (chbVegetables.Checked)  ToppingPrice += Convert.ToSingle(chbVegetables.Tag);
            if (chbCheese.Checked)      ToppingPrice += Convert.ToSingle(chbCheese.Tag);

            return ToppingPrice;

        }
        float CalaTotalPrice()
        {
            return CalcSize() + CalcPatty() + CalcToping();
        }
        void UpdateTotalPrice()
        {
            lblPrice.Text = "$ " + CalaTotalPrice().ToString();
        }
        void UpdatePatty()
        {
            UpdateTotalPrice();
            if (rbBeefPatty.Checked)
            {
                lblPatty.Text = "Beef Patty";

            }
            else if (rbHalalPatty.Checked)
            {
                lblPatty.Text = "Halal Patty";

            }
            else if (rbFishPatty.Checked)
            {
                lblPatty.Text = "Fish Patty";

            }
            else
            {
                lblPatty.Text = "Chiken Patty";

            }



        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
                lblSize.Text = "Small";
            else if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
            }
            else
            {
                lblSize.Text = "Meduim";
            }
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbBeefPatty_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePatty();

        }

        private void rbHalalPatty_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePatty();

        }

        private void rbFishPatty_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePatty();

        }

        private void rbChickenPatty_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePatty();

        }

        private void chbFriedOnions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chbSauces_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chbVegetables_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chbCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        void ConfimeOrder()
        {
            pnlCrustTybe.Enabled = false;
            pnlSize.Enabled = false;  
            pnlToppings.Enabled= false;
            groupBox1.Enabled = false;
            btnOrder.Enabled = false;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
          DialogResult Answer=  MessageBox.Show("Are You Sure ? ", "Confiem", MessageBoxButtons.OKCancel);
            if(Answer== DialogResult.OK)
            {
                ConfimeOrder();
                MessageBox.Show("Your Ruquest Is Done. ", "Done", MessageBoxButtons.OK);
               
            }
        }
        void RestartOrder()
        {
            pnlCrustTybe.Enabled = true;
            pnlSize.Enabled = true;
            pnlToppings.Enabled = true;
            groupBox1.Enabled = true;
            btnOrder.Enabled = true;
            lblPrice.Text = "00:00";
            rbSmall.Checked = true;
            chbCheese.Checked = false;
            chbFriedOnions.Checked = false;
            chbSauces.Checked = false;
            chbVegetables.Checked = false;
            lblTopping.Text = "No,Thing";
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartOrder();
        }

        private void Hamburger_Load(object sender, EventArgs e)
        {

        }
    }
}
