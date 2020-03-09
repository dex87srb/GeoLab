using System;
using System.Windows.Forms;


namespace GeoLab
{
    public partial class Coordinates : Form
    {
        public Coordinates()
        {
            InitializeComponent();
        }

        private void Xb_Yb_Click(object sender, EventArgs e)
        {
            try
            {
                double Xa = double.Parse(textBox3.Text);
                double Ya = double.Parse(textBox4.Text);
                double dk = double.Parse(textBox1.Text);
                double νab = double.Parse(textBox2.Text);
                double Z = double.Parse(textBox17.Text);

                /*  else if (Regex.IsMatch(textBox2.Text, @"^\d{1,3}\.\d{1,6}$") || Regex.IsMatch(textBox17.Text, @"^\d{1,3}\.\d{1,6}$"))
                  {
                      MessageBox.Show("You must enter a three digits number before the decimal point, and maximum five after the decimal point, please try again");
                  }*/
                if (νab > 360 || Z > 360)
                {
                    MessageBox.Show("Z and νab must be a number between 0-360");
                }
                else if (Xa > 7999999 || Ya > 4999999)
                {
                    MessageBox.Show("Xa must not exceed 9999999 and Ya Xa must not exceed 4999999, please try again");
                }
                else
                {
                    textBox6.Text = Math.Round(Xa + dk * Math.Sin(Z) * Math.Cos(νab), 3).ToString();
                    textBox7.Text = Math.Round(Ya + dk * Math.Sin(Z) * Math.Sin(νab), 3).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}");
            }
        }

        private void HB_Click(object sender, EventArgs e)
        {
            try
            {
                double Ha = double.Parse(textBox9.Text);
                double i = double.Parse(textBox8.Text);
                double dk = double.Parse(textBox1.Text);
                double l = double.Parse(textBox10.Text);
                double Z = double.Parse(textBox17.Text);

            
                if (Z > 360)
                {
                    MessageBox.Show("Z and νab must be a number between 0-360");
                }
                else
                {
                    textBox11.Text = Math.Round(Ha + dk * Math.Cos(Z) + (i - l), 3).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}");
            }
        }

        private void Zdec_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox5.Text, out int deg) || !int.TryParse(textBox12.Text, out int min) ||
                    !int.TryParse(textBox13.Text, out int sec))
                {
                    MessageBox.Show("You must enter a hole number, please try again");
                }
                /* else if (!Regex.IsMatch(textBox5.Text, @"^\d{1,3}$") || !Regex.IsMatch(textBox12.Text, @"^\d{1,2}$") ||
                           !Regex.IsMatch(textBox13.Text, @"^\d{1,2}$"))
                  {
                      MessageBox.Show("You must enter a maximum three digits number in a deg field, a maximum two digits number in a ' and '' fields, please try again");
                  }*/
                else if (deg > 360 || min > 60 || sec > 60)
                {
                    MessageBox.Show("You must enter a number between 0-360 in a deg field, a number between 0-60 in a min and sec field, please try again");
                }
                else if (deg == 360 && min > 0 || deg == 360 && sec > 0)
                {
                    MessageBox.Show("When deg is 360, min and sec must not be over 0, please try again");
                }
                else
                {
                    double result = Math.Round(deg + (double)min / 60 + sec / 360, 6);
                    textBox17.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}");
            }
        }

        private void NiDec_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBox16.Text, out int deg) || !int.TryParse(textBox15.Text, out int min) ||
                    !int.TryParse(textBox14.Text, out int sec))
                {
                    MessageBox.Show("You must enter a hole number, please try again");
                }
                else if (deg > 360 || min > 60 || sec > 60)
                {
                    MessageBox.Show("You must enter a number between 0-360 in a deg field, a number between 0-60 in a min and sec field, please try again");
                }
                else if (deg == 360 && min > 0 || deg == 360 && sec > 0)
                {
                    MessageBox.Show("When deg is 360, min and sec must not be over 0, please try again");
                }
                else
                {
                    double result = Math.Round(deg + (double)min / 60 + sec / 360, 6);
                    textBox2.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong: {ex.Message}");
            }
        }

        private void Xa_KeyPress(object sender, KeyPressEventArgs e)//limits Xa input on three decimals
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            string strkey = e.KeyChar.ToString().Substring(e.KeyChar.ToString().Length - 1,
            e.KeyChar.ToString().Length - (e.KeyChar.ToString().Length - 1)); //sets all input characters

            TextBox tb = sender as TextBox;
            int cursorPosLeft = tb.SelectionStart;
            int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
            string result1 = tb.Text.Substring(0, cursorPosLeft) +
                  strkey + tb.Text.Substring(cursorPosRight);
            string[] parts = result1.Split('.');
            if (parts.Length > 1)
            {
                if (parts[1].Length > 3 || parts.Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void Ya_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            string strkey = e.KeyChar.ToString().Substring(e.KeyChar.ToString().Length - 1,
            e.KeyChar.ToString().Length - (e.KeyChar.ToString().Length - 1)); 

            TextBox tb = sender as TextBox;
            int cursorPosLeft = tb.SelectionStart;
            int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
            string result1 = tb.Text.Substring(0, cursorPosLeft) +
                  strkey + tb.Text.Substring(cursorPosRight);
            string[] parts = result1.Split('.');
            if (parts.Length > 1)
            {
                if (parts[1].Length > 3 || parts.Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void Dk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            string strkey = e.KeyChar.ToString().Substring(e.KeyChar.ToString().Length - 1,
            e.KeyChar.ToString().Length - (e.KeyChar.ToString().Length - 1)); 

            TextBox tb = sender as TextBox;
            int cursorPosLeft = tb.SelectionStart;
            int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
            string result1 = tb.Text.Substring(0, cursorPosLeft) +
                  strkey + tb.Text.Substring(cursorPosRight);
            string[] parts = result1.Split('.');
            if (parts.Length > 1)
            {
                if (parts[1].Length > 3 || parts.Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void Niab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            string strkey = e.KeyChar.ToString().Substring(e.KeyChar.ToString().Length - 1,
            e.KeyChar.ToString().Length - (e.KeyChar.ToString().Length - 1)); 

            TextBox tb = sender as TextBox;
            int cursorPosLeft = tb.SelectionStart;
            int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
            string result1 = tb.Text.Substring(0, cursorPosLeft) +
                  strkey + tb.Text.Substring(cursorPosRight);
            string[] parts = result1.Split('.');
            if (parts.Length > 1)
            {
                if (parts[1].Length > 6 || parts.Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void Z_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            string strkey = e.KeyChar.ToString().Substring(e.KeyChar.ToString().Length - 1,
            e.KeyChar.ToString().Length - (e.KeyChar.ToString().Length - 1)); 

            TextBox tb = sender as TextBox;
            int cursorPosLeft = tb.SelectionStart;
            int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
            string result1 = tb.Text.Substring(0, cursorPosLeft) +
                  strkey + tb.Text.Substring(cursorPosRight);
            string[] parts = result1.Split('.');
            if (parts.Length > 1)
            {
                if (parts[1].Length > 6 || parts.Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void i_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            string strkey = e.KeyChar.ToString().Substring(e.KeyChar.ToString().Length - 1,
            e.KeyChar.ToString().Length - (e.KeyChar.ToString().Length - 1)); //sets all input characters

            TextBox tb = sender as TextBox;
            int cursorPosLeft = tb.SelectionStart;
            int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
            string result1 = tb.Text.Substring(0, cursorPosLeft) +
                  strkey + tb.Text.Substring(cursorPosRight);
            string[] parts = result1.Split('.');
            if (parts.Length > 1)
            {
                if (parts[1].Length > 2 || parts.Length > 2)
                {
                    e.Handled = true;
                }
            }
            /*  else if (e.Handled = (e.KeyChar == (char)Keys.Space)) MessageBox.Show("No space allowed, please try again");

              else if (e.Handled = e.KeyChar == ',') MessageBox.Show("No comma allowed");*/
        }

        private void Ha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            string strkey = e.KeyChar.ToString().Substring(e.KeyChar.ToString().Length - 1,
            e.KeyChar.ToString().Length - (e.KeyChar.ToString().Length - 1)); //sets all input characters

            TextBox tb = sender as TextBox;
            int cursorPosLeft = tb.SelectionStart;
            int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
            string result1 = tb.Text.Substring(0, cursorPosLeft) +
                  strkey + tb.Text.Substring(cursorPosRight);
            string[] parts = result1.Split('.');
            if (parts.Length > 1)
            {
                if (parts[1].Length > 3 || parts.Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void l_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            string strkey = e.KeyChar.ToString().Substring(e.KeyChar.ToString().Length - 1,
            e.KeyChar.ToString().Length - (e.KeyChar.ToString().Length - 1)); //sets all input characters

            TextBox tb = sender as TextBox;
            int cursorPosLeft = tb.SelectionStart;
            int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
            string result1 = tb.Text.Substring(0, cursorPosLeft) +
                  strkey + tb.Text.Substring(cursorPosRight);
            string[] parts = result1.Split('.');
            if (parts.Length > 1)
            {
                if (parts[1].Length > 2 || parts.Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

    }
}


