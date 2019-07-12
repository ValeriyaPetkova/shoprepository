using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        private Inventory inventory = new Inventory();
      
        private T_Shirt shirt = new T_Shirt();
        private Pant p = new Pant();
        private Coat c = new Coat();

        public Form1()
        {
            InitializeComponent();
        }

        private void cboxTypeOfProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTypeOfProduct.SelectedItem.ToString() == "Pants")
            {
                cboxTypeOfPants.Visible = true;
                lbTypeOfPants.Visible = true;
                cboxTypeOfCoat.Visible = false;
                lbTypeOfCoat.Visible = false;
            }
            else if (cboxTypeOfProduct.SelectedItem.ToString() == "Coats")
            {
                cboxTypeOfCoat.Visible = true;
                lbTypeOfCoat.Visible = true;
                cboxTypeOfPants.Visible = false;
                lbTypeOfPants.Visible = false;
            }
            else
            {
                cboxTypeOfCoat.Visible = false;
                lbTypeOfCoat.Visible = false;
                cboxTypeOfPants.Visible = false;
                lbTypeOfPants.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cboxTypeOfProduct.Text))
                {
                    throw new ArgumentOutOfRangeException("You didn't choose type of product!");
                }
                else
                {
                    try
                    {
                        if (string.IsNullOrEmpty(tbColor.Text.Trim()) || string.IsNullOrEmpty(tbPrice.Text.Trim()) ||
                        string.IsNullOrEmpty(tbSize.Text.Trim()) || string.IsNullOrEmpty(tbMaterial.Text.Trim()))
                        {
                            throw new Exception("You didn't fill all fields!");
                        }
                        else
                        {
                            if (cboxTypeOfProduct.SelectedItem.ToString() == "T-Shirt")
                            {
                                T_Shirt _tShirt = new T_Shirt(Convert.ToDecimal(tbPrice.Text), tbColor.Text, tbSize.Text, tbMaterial.Text);
                                Inventory.products.Add(_tShirt);
                                tbProducts.Text += _tShirt.ToString();
                            }
                            else if (cboxTypeOfProduct.SelectedItem.ToString() == "Pants")
                            {
                                if (cboxTypeOfPants.SelectedIndex == -1)
                                {
                                    Pant pant = new Pant(Convert.ToDecimal(tbPrice.Text), tbColor.Text, tbSize.Text, tbMaterial.Text);
                                    Inventory.products.Add(pant);
                                    tbProducts.Text += pant.ToString();
                                }
                                else
                                {
                                    Pant pant = new Pant(Convert.ToDecimal(tbPrice.Text), tbColor.Text, tbSize.Text, tbMaterial.Text,
                                        cboxTypeOfPants.SelectedItem.ToString());
                                    Inventory.products.Add(pant);
                                    tbProducts.Text += pant.ToString();
                                }
                            }
                            else
                            {
                                if (cboxTypeOfCoat.SelectedIndex == -1)
                                {
                                    Coat coat = new Coat(Convert.ToDecimal(tbPrice.Text), tbColor.Text, tbSize.Text, tbMaterial.Text);
                                    Inventory.products.Add(coat);
                                    tbProducts.Text += coat.ToString();
                                }
                                else
                                {
                                    Coat coat = new Coat(Convert.ToDecimal(tbPrice.Text), tbColor.Text, tbSize.Text, tbMaterial.Text,
                                        cboxTypeOfCoat.SelectedItem.ToString());
                                    Inventory.products.Add(coat);
                                    tbProducts.Text += coat.ToString();
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("You didn't fill all fields!");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You didn't choose type of product!");
            }
            tbColor.Text = "";
            tbMaterial.Text = "";
            tbPrice.Text = "";
            tbSize.Text = "";
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            if (chboxPants.Checked && !chboxTShirt.Checked && !chboxCoats.Checked)
            {
                MessageBox.Show(inventory.GetAllByType(p));
            }
            else if (chboxTShirt.Checked && !chboxPants.Checked && !chboxCoats.Checked)
            {
                MessageBox.Show(inventory.GetAllByType(shirt));
            }
            else if (!chboxTShirt.Checked && !chboxPants.Checked && chboxCoats.Checked)
            {
                MessageBox.Show(inventory.GetAllByType(c));
            }
            else if (chboxTShirt.Checked && chboxPants.Checked && !chboxCoats.Checked)
            {
                MessageBox.Show(inventory.GetAllByType(shirt, p));
            }
            else if (chboxTShirt.Checked && !chboxPants.Checked && chboxCoats.Checked)
            {
                MessageBox.Show(inventory.GetAllByType(c, shirt));
            }
            else if (!chboxTShirt.Checked && chboxPants.Checked && chboxCoats.Checked)
            {
                MessageBox.Show(inventory.GetAllByType(c, p));
            }
            else
                MessageBox.Show("The number of all products is " + inventory.GetAllProducts());
            chboxPants.Checked = false;
            chboxTShirt.Checked = false;
            chboxCoats.Checked = false;
        }

        private void btnGetSumAll_Click(object sender, EventArgs e)
        {
            if (chboxPants.Checked && !chboxTShirt.Checked && !chboxCoats.Checked)
            {
                MessageBox.Show(inventory.GetSum(p));
            }
            else if (!chboxPants.Checked && chboxTShirt.Checked && !chboxCoats.Checked)
            {
                MessageBox.Show(inventory.GetSum(shirt));
            }
            else if (!chboxPants.Checked && !chboxTShirt.Checked && chboxCoats.Checked)
            {
                MessageBox.Show(inventory.GetSum(c));
            }
            else if (chboxTShirt.Checked && chboxPants.Checked && !chboxCoats.Checked)
            {
                MessageBox.Show(inventory.GetSum(shirt, p));
            }
            else if (chboxTShirt.Checked && !chboxPants.Checked && chboxCoats.Checked)
            {               
                MessageBox.Show(inventory.GetSum(c, shirt));
            }
            else if (!chboxTShirt.Checked && chboxPants.Checked && chboxCoats.Checked)
            {                
                MessageBox.Show(inventory.GetSum(c, p));
            }
            else
                MessageBox.Show("The sum of all products is " + inventory.GetAllSum());
            chboxTShirt.Checked = false;
            chboxPants.Checked = false;
            chboxCoats.Checked = false;
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;
            if ((e.KeyChar == ',') && tbPrice.Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void tbColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void tbSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void tbMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
