using DXApplication3.Models;
using DXApplication3.Services;
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
        private readonly UserService _userService;
        public Form1(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            User user = new User(textEdit1.Text,dateTimePicker1.Value);
            int age = _userService.CalculateAge(user);
            labelControl3.Text = $"Your age is : {age}";
        }
    }
}
