using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esari_app
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int itemsOrdered;
        const int numberOfProducts = 5;
        partialProduct[] products = new partialProduct[numberOfProducts];


        private void Form1_Load(object sender, EventArgs e)
        {
            products[0] = new partialProduct("Computer", 1000);
            products[1] = new partialProduct("Laptop", 2000);
            products[2] = new partialProduct("Mouse", 300);
            products[3] = new partialProduct("Keyboard", 400);
            products[4] = new partialProduct("Mousepad", 100);

            for (int i = 0; i < numberOfProducts; i++)
            {
                dudProducts.Items.Add(products[i].Description);
            }
            dudProducts.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            itemsOrdered = 0;
            lblItemsOrdered.Text = "Items Ordered: 0";
            for (int i = 0; i < numberOfProducts; i++)
            {
                products[i].numberOrdered = 0;
            }
            dudProducts.SelectedIndex = 0;
            lstProducts.Items.Clear();
            lblTotalCost.Text = "Total Cost";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            products[dudProducts.SelectedIndex].numberOrdered++;
            itemsOrdered++;
            lblItemsOrdered.Text = "Items Ordered: " + itemsOrdered.ToString();

        }
        /* public void tabShoppingCart_SelectedIndexChanged(object sender, EventArgs e) 

         {
             switch (tabOrderForm.SelectedIndex)
             {
                 case 1:
                     if (itemsOrdered == 0)
                     {

                         MessageBox.Show("No items were ordered", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                     else
                     {
                         double totalCost = 0;
                         lstProducts.Items.Clear();
                         for (int i = 0; i < numberOfProducts; i++)
                         {
                             if (products[i].numberOrdered != 0)
                             {
                                 lstProducts.Items.Add(products[i].numberOrdered.ToString() + " " + products[i].Description);
                                 totalCost += products[i].Cost * products[i].numberOrdered;
                             }
                         }

                         lblTotalCost.Text = "Total Cost: $" + String.Format("{0;f2}", totalCost);
                     }
                     break;

             }
         }
        */

       /* private void tabShoppingCart(object sender, EventArgs e)
        {

        }*/

        private void shoppingCart(object sender, EventArgs e)
        {
            switch (tabOrderForm.SelectedIndex)
            {
                case 1:
                    if (itemsOrdered == 0)
                    {

                        MessageBox.Show("No items were ordered", "Invalid Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabOrderForm.SelectedIndex = 0;
                    }
                    else
                    {
                        double totalCost = 0;
                        lstProducts.Items.Clear();
                        for (int i = 0; i < numberOfProducts; i++)
                        {
                            if (products[i].numberOrdered != 0)
                            {
                                lstProducts.Items.Add(products[i].numberOrdered.ToString() + " " + products[i].Description);
                                totalCost += products[i].Cost * products[i].numberOrdered;
                            }
                        }

                        lblTotalCost.Text = "Total Cost: $" + String.Format("{0;f2}", totalCost);
                    }
                    break;

            }
        }
    }
}
