using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


// Created by Christopher Wuydts
namespace Calculator
{
    public partial class calc : Form
    {

        public static class holdValues
        {
            public static double fnum;
            public static char choice = '!';
            public static double snum; 
            public static double placeholder;
            public static bool flag = true;
        }
       


        public calc()
        {
            InitializeComponent();
            txt_INPUTBOX.Text = 0.ToString();
        }

        private void button13_Click(object sender, EventArgs e) // THIS IS BUTTON FOUR 
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = 4.ToString();
                else
                    txt_INPUTBOX.Text += 4.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = 1.ToString();
                else
                    txt_INPUTBOX.Text += 1.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = 2.ToString();
                else
                    txt_INPUTBOX.Text += 2.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = 3.ToString();
                else
                    txt_INPUTBOX.Text += 3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = 5.ToString();
                else
                    txt_INPUTBOX.Text += 5.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = 6.ToString();
                else
                    txt_INPUTBOX.Text += 6.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = 7.ToString();
                else
                    txt_INPUTBOX.Text += 7.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = 8.ToString();
                else
                    txt_INPUTBOX.Text += 8.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = 9.ToString();
                else
                    txt_INPUTBOX.Text += 9.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ADDITION_Click(object sender, EventArgs e)
        {
            try
            {
                var firstnumber = Convert.ToDouble(txt_INPUTBOX.Text);
                holdValues.fnum = firstnumber;
                holdValues.choice = '+';
                txt_INPUTBOX.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_MINUS_Click(object sender, EventArgs e)
        {
            try
            {
                var firstnumber = Convert.ToDouble(txt_INPUTBOX.Text);
                holdValues.fnum = firstnumber;
                holdValues.choice = '-';
                txt_INPUTBOX.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            try
            {
                var firstnumber = Convert.ToDouble(txt_INPUTBOX.Text);
                holdValues.fnum = firstnumber;
                holdValues.choice = '*';
                txt_INPUTBOX.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_divides_Click(object sender, EventArgs e)
        {
            try
            {
                var firstnumber = Convert.ToDouble(txt_INPUTBOX.Text);
                holdValues.fnum = firstnumber;
                holdValues.choice = '/';
                txt_INPUTBOX.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            try
            {
                holdValues.fnum = 0;
                holdValues.choice = '!';
                holdValues.snum = 0;
                holdValues.flag = true;
                holdValues.placeholder = 0;
                txt_INPUTBOX.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            try
            {
                if (holdValues.choice.Equals('!'))
                {
                    holdValues.fnum = 0;
                }
                else
                {
                    holdValues.snum = 0;
                }

               
                txt_INPUTBOX.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = '.'.ToString();
                else
                    txt_INPUTBOX.Text += '.'.ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_plusORminus_Click(object sender, EventArgs e)
        {
            try
            {
                double temp = 0, sum = 0;
                temp = Convert.ToDouble(txt_INPUTBOX.Text);
                sum = temp * -1;
                txt_INPUTBOX.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            try
            { 
                double sum = Convert.ToDouble(txt_INPUTBOX.Text);
                sum = Math.Sqrt(sum);
                txt_INPUTBOX.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                btn_C_Click(null, null);
            }

        }

        private void btn_PowerOfTwo_Click(object sender, EventArgs e)
        {
            try
            {
                double fNum = Convert.ToDouble(txt_INPUTBOX.Text);
                double sum = 0;

                sum = fNum * fNum;
                txt_INPUTBOX.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                btn_C_Click(null, null);
            }


        }

        private void btn_powerofY_Click(object sender, EventArgs e)
        {
            try
            {
                holdValues.fnum = Convert.ToDouble(txt_INPUTBOX.Text);
                holdValues.choice = '^';
                txt_INPUTBOX.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        

        private void btn_onedividedbyX_Click(object sender, EventArgs e)
        {
            try
            {
                double one = 1;
                double fnum = Convert.ToDouble(txt_INPUTBOX.Text);
                double sum = 0;
                if (fnum == 0)
                {
                    txt_INPUTBOX.Text = "You cannot divide by 0";
                }
                else
                {
                    sum = one / fnum;
                    txt_INPUTBOX.Text = sum.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_INPUTBOX.Text == "0" && txt_INPUTBOX != null)
                    txt_INPUTBOX.Text = 0.ToString();
                else
                    txt_INPUTBOX.Text += 0.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_INPUTBOX.Text.Length > 0)
                {
                    txt_INPUTBOX.Text = txt_INPUTBOX.Text.Remove(txt_INPUTBOX.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      

        private void btn_EQUALS_Click(object sender, EventArgs e)
        {
            try
            {
                double sum = 0;
                
                holdValues.snum = Convert.ToDouble(txt_INPUTBOX.Text);

                if(holdValues.flag.Equals(false))
                {
                    holdValues.snum = holdValues.placeholder;
                }

                holdValues.flag = false;
                

                if (holdValues.choice.Equals('+'))
                {
                    sum = holdValues.fnum + holdValues.snum;
                    
                    holdValues.placeholder = holdValues.snum;
                    txt_INPUTBOX.Text = sum.ToString();
                    holdValues.fnum = sum;
               
                }

                else if (holdValues.choice.Equals('-'))
                {
                    sum = holdValues.fnum - holdValues.snum;
                  
                    holdValues.placeholder = holdValues.snum;
                    txt_INPUTBOX.Text = sum.ToString();
                    holdValues.fnum = sum;
                  
                   
                 
                }

                else if (holdValues.choice.Equals('*'))
                {
                    sum = holdValues.fnum * holdValues.snum;
                 
                    holdValues.placeholder = holdValues.snum;
                    txt_INPUTBOX.Text = sum.ToString();
                    holdValues.fnum = sum;
                   
                }

                else if (holdValues.choice.Equals('/'))
                {
                    if(holdValues.snum.Equals(0))
                    {
                      
                        btn_C_Click(null, null);
                        txt_INPUTBOX.Text = "Cannot Divide By 0 ::: Please press 'C'";
                    }
                    else
                    {
                        sum = holdValues.fnum / holdValues.snum;
                       
                        holdValues.placeholder = holdValues.snum;
                        txt_INPUTBOX.Text = sum.ToString();
                        holdValues.fnum = sum;
                      
                    }
                }

                else if (holdValues.choice.Equals('^'))
                {
                    sum = Math.Pow(holdValues.fnum, holdValues.snum);

                    holdValues.placeholder = holdValues.snum;
                    txt_INPUTBOX.Text = sum.ToString();
                    holdValues.fnum = sum;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

        }

     





    }
}
