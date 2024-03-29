using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication3
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePicker1.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            // Check if the birthday for this year has not occurred yet
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            labelControl3.Text = $"Your age is : {age}";

        }
    }
}
