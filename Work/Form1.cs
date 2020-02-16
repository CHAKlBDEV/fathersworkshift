using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Work
{
    public partial class Form1 : Form
    {
        private string[] Rotations = new string[] { "Jour", "Nuit", "Repos 1", "Repos 2" };

        public Form1()
        {
            InitializeComponent();

            startDatePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            endDatePicker.Value = startDatePicker.Value.AddDays(1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            int difference = (endDate - startDate).Days;

            int offset = (difference + currentRotationCB.SelectedIndex) % 4;

            rotationTB.Text = Rotations[offset];
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (currentRotationCB.SelectedIndex > -1) Calculate();
        }
    }
}
