using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form

    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbxCountries.Items.Add(textUserdata.Text);
           

            textUserdata.Text = "";        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbxCountries.SelectedIndex;
            lbxCountries.Items.Remove(lbxCountries.SelectedItem);
            if (selectedIndex < lbxCountries.Items.Count)
            {
                lbxCountries.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lbxCountries.Sorted = true;
           
        }

        private void btnUnsort_Click(object sender, EventArgs e)
        {
            List<string> items = new List<string>(lbxCountries.Items.Cast<string>());

            // Sort the items in descending order
            items.Sort((a, b) => b.CompareTo(a));

            // Clear the ListBox
            lbxCountries.Items.Clear();

            // Add the sorted items back to the ListBox
            lbxCountries.Items.AddRange(items.ToArray());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
