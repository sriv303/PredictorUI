using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredictorUI
{
    public partial class SimulationForm : Form
    {
        private string[] team1;
        private string[] team2;
        public SimulationForm()
        {
            InitializeComponent();
        }

        private void comboBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("clicked");
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            // MessageBox.Show("enterd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += comboBox1.SelectedItem;
            listView1.Items.Add(new ListViewItem(comboBox1.SelectedItem.ToString()));
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }



        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Delete == e.KeyCode)
            {
                foreach (ListViewItem listViewItem in ((ListView)sender).SelectedItems)
                {
                    comboBox1.Items.Add(listViewItem.Text);
                    listViewItem.Remove();
                }
            }
        }
    }
}
