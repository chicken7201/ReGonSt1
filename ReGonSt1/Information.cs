using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReGonSt1
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel5_BulletPointIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/bullet-point");
        }

        private void linkLabel_MenuBarIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/menu-bar");
        }

        private void linkLabel_HomeButtonIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/home-button");
        }

        private void linkLabel_SettingIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/settings");
        }

        private void linkLabel_HelpIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/help");
        }

        private void linkLabel_AboutIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/about");
        }

        private void linkLabel_DotIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/dot");
        }

        private void linkLabel_LanguageIcons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icons/languages");
        }
    }
}
