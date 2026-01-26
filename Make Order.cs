using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza____Poject
{
    public partial class FrmMakeOrder: Form
    {
        public FrmMakeOrder()
        {
            InitializeComponent();
        }

        float CalculateSelectedSizePrice()
        {
            if(rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }

            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

        }

        float CalculateSelectedCrustTypePrice()
        {
            if(rbThickCrust.Checked)
            {
                return Convert.ToSingle(rbThickCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
        }

        float CalculateSelectedToppingsPrice()
        {
            float TotalToppingsPrice = 0;
            if(chkExtraChees.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chkExtraChees.Tag);
            }
            if (chkGreenPepper.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chkGreenPepper.Tag);
            }
            if (chkMushrooms.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkOlives.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkOnion.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkTomatoes.Checked)
            {
                TotalToppingsPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            return TotalToppingsPrice;
        }

        float CalculateTotalPrince()
        {
            return (CalculateSelectedSizePrice() + CalculateSelectedCrustTypePrice()
                + CalculateSelectedToppingsPrice()) * ((float)numericUpDown1.Value);
        }

        void UpdateTotalPrice()
        {
            lbTotalPrice.Text = "$" + CalculateTotalPrince().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();
            if(rbSmall.Checked)
            {
                lbSizeValue.Text = "Small";
                return;
            }
            if(rbMedium.Checked)
            {
                lbSizeValue.Text = "Medium";
                return;
            }
            else
            {
                lbSizeValue.Text = "Large";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string STopping = "";
            if (chkExtraChees.Checked)
            {
                STopping = "ExtraChees";
            }
            if (chkGreenPepper.Checked)
            {
                STopping += ", GreenPepper";
            }
            if (chkMushrooms.Checked)
            {
                STopping += ", Mushrooms";
            }
            if (chkOlives.Checked)
            {
                STopping += ", lives";
            }
            if (chkOnion.Checked)
            {
                STopping += ", Onion";
            }
            if (chkTomatoes.Checked)
            {
                STopping += ", Tomatoes";
            }
            if (STopping.StartsWith(","))
            {
                STopping = STopping.Substring(1, STopping.Length - 1).Trim();
            }
            if (STopping == "")
            {
                STopping = "No Toppings";
            }
            lbToppingsValue.Text = STopping;
        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked)
            {
                lbCrustType.Text = "Thin Crust";
                return;
            }
            else
            {
                lbCrustType.Text = "Thick Crust";
                return;
            }
        }

        void UpdateWhereToEat()
        {
            if(rbEatin.Checked)
            {
                lbWhereToEat.Text = "Eat In";
                return;
            }
            else
            {
                lbWhereToEat.Text = "Take Out";
                return;
            }
        }

        void UpdateSummaryOrder()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrustType();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        void ResetForm()
        {
            //Groub Boxes
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbToppings.Enabled = true;

            //Toppings
            chkExtraChees.Checked = false;
            chkGreenPepper.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;


            rbMedium.Checked = true;
            rbThinCrust.Checked = true;
            rbEatin.Checked = true;

            btnOrderPizza.Enabled = true;

            numericUpDown1.Enabled = true;
            numericUpDown1.Value = 1;

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

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbEatin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeout_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                numericUpDown1.Enabled = false;
            }
            
        }

        private void ResetOrder_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void FrmMakeOrder_Load(object sender, EventArgs e)
        {
            UpdateSummaryOrder();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
