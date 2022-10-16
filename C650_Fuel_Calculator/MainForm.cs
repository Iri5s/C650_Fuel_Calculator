using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C650_Fuel_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async Task<int> DoCalc(int CurrentFuel, string m)
        {
            if (InvokeRequired)
                Invoke(new Action(() => DoCalc(CurrentFuel, m)));
            else
            {
                if (CurrentFuel > 2 && BlockFuelTxt.Text.Length > 2 && KGLiterTxt.Text.Length > 2)
                {
                    try
                    {
                        int BlockFuel = Convert.ToInt32(BlockFuelTxt.Text);
                        double KGtoLiter = Convert.ToDouble(KGLiterTxt.Text);

                        double diff = BlockFuel - CurrentFuel;
                        if (diff > 0)
                        {
                            if (m == "lbs") // Convert diff to KG
                                diff /= 2.205;
                            NeededFuelTxt.Text = Convert.ToString(Math.Ceiling(diff / KGtoLiter));
                        }
                        else
                            NeededFuelTxt.Text = "Error; Diff fuel is negative";
                    }
                    catch
                    {
                        NeededFuelTxt.Text = "Error!";
                    }

                }
            }
            return 0;

        }

        private async void HandleTextChange(object sender, KeyPressEventArgs e)
        {
            TextBox TB = sender as TextBox;
            if ((char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) || (e.KeyChar == '.') && !TB.Text.Contains(".")) // Check for numerics only
            {
                if (TB.Text.Contains("|"))
                    TB.Text = TB.Text.Replace("|", "");
                try
                {
                    if (sender.Equals(CurrentFuelKGTxt)) // Entering fuel in lbs..
                        CurrentFuelLBSTxt.Text = "|";
                    else if (sender.Equals(CurrentFuelLBSTxt))
                        CurrentFuelKGTxt.Text = "|";

                    if (CurrentFuelLBSTxt.Text.Length > 2)
                        await Task.Run(() => DoCalc(Convert.ToInt32(CurrentFuelLBSTxt.Text), "lbs"));
                    else if (CurrentFuelKGTxt.Text.Length > 2)
                        await Task.Run(() => DoCalc(Convert.ToInt32(CurrentFuelKGTxt.Text), "kg"));
                }
                catch
                {
                    NeededFuelTxt.Text = "Error!";
                }
            }
            else
                e.Handled = true;
        }
    }
}
