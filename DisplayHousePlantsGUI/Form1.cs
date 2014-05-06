using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayHousePlantsGUI
{
    public partial class Form1 : Form
    {
        // global variables & constants
        const int SIZE = 3;
        int[] days = new int[SIZE];
        HousePlant[] plants = new HousePlant[SIZE];
        int count = 0;
        double price;

        public Form1()
        {
            InitializeComponent();
            refresh();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(priceTextBox.Text) ||
                String.IsNullOrEmpty(daysTextBox.Text))
            {
                MessageBox.Show("You must fill out all fields.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end if
            else
            {
                if (count == 3)
                {
                    MessageBox.Show("You can only have 3 plants.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } // end if
                else
                {
                    bool fed;
                    if (int.TryParse(daysTextBox.Text, out days[count]))
                    { }

                    if (days[count] > 30)
                    {
                        fed = false;
                    } // end if
                    else
                    {
                        fed = true;
                    } // end else
                    if (Double.TryParse(priceTextBox.Text, out price))
                    { }
                    plants[count] = new HousePlant(nameTextBox.Text, price, fed);
                    count++;
                    refresh();
                } // end else
            } // end else
        }

        // refreshHousePlantTextBox method refreshes data in housePlantTextBox
        private void refreshHousePlantTextBox()
        {
            if (plants[0] == null && plants[1] == null && plants[2] == null)
            {
                housePlantTextBox.Text = "No Current House Plants";
            } // end if
            else
            {
                string output = "Plant 1: ";
                for (int x = 0; x < SIZE; x++)
                {
                    if (plants[x] != null)
                    {
                        output += plants[x].Name + "\r\n";
                        output += "Price: $" + plants[x].Price + "\r\n";
                        output += "Days since last fed: " + days[x] + "\r\n";
                        if (days[x] >= 30)
                        {
                            output += "This plant needs to be fed!!\r\n";
                        } // end if
                        output += "\r\n";
                    } // end if
                    else
                    {
                        output += "Empty\r\n\r\n";
                    } // end else
                    if (x != 2)
                    {
                        output += "Plant " + (x + 1) + ": ";
                    } // end if
                } // end for
                housePlantTextBox.Text = output;
            } // end else
        } // refreshHousePlantTextBox method end

        // refresh method checks status of when buttons should be enabled/disabled
        private void refresh() // refresh method start
        {
            if (count == 0)
            {
                feedButton.Enabled = false;
                removeButton.Enabled = false;
                nextDayButton.Enabled = false;
            } // end if
            else
            {
                feedButton.Enabled = true;
                removeButton.Enabled = true;
                nextDayButton.Enabled = true;
            } // end else
            if (count == SIZE)
            {
                addButton.Enabled = false;
            } // end if
            else
            {
                addButton.Enabled = true;
            } // end else
            refreshHousePlantTextBox();
        } // refresh method end

        private void feedButton_Click(object sender, EventArgs e)
        {
            int index = comboBox.SelectedIndex;
            if (plants[index] != null)
            {
                days[index] = 0;
                plants[index].Fed = true;
                refresh();
            } // end if
            else
            {
                MessageBox.Show("There is no plant in that spot.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end else
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = comboBox.SelectedIndex;
            if (plants[index] != null)
            {
                if (index == 0)
                {
                    plants[index] = plants[index + 1];
                    days[index] = days[index + 1];
                    plants[index + 1] = plants[index + 2];
                    days[index + 1] = days[index + 2];
                    plants[index + 2] = null;
                } // end if
                else if (index == 1)
                {
                    plants[index] = plants[index + 1];
                    days[index] = days[index + 1];
                    plants[index + 1] = null;
                } // end else if
                else
                {
                    plants[index] = null;
                } // end else
                count--;
                if (count < SIZE)
                {
                    addButton.Enabled = true;
                } // end if
                refresh();
            } // end if
            else
            {
                MessageBox.Show("There is no plant in that spot.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end else
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < SIZE; x++)
            {
                days[x]++;
            } // end for
            refresh();
        } // refreshHousePlantTextBox method end
    }
}
