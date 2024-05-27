using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReGonSt1
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        bool settingsCollapsed;

        public Form1()
        {
            InitializeComponent();
        }

        private void sidebarTimer_tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
            
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void SettingsTimer_Tick(object sender, EventArgs e)
        {
            if(settingsCollapsed)
            {
                panel_SettingsContainer.Height += 10;
                if(panel_SettingsContainer.Height ==  panel_SettingsContainer.MaximumSize.Height)
                {
                    settingsCollapsed = false;
                    SettingsTimer.Stop();
                }
            }
            else
            {
                panel_SettingsContainer.Height -= 10;
                if(panel_SettingsContainer.Height == panel_SettingsContainer.MinimumSize.Height)
                {
                    settingsCollapsed = true;
                    SettingsTimer.Stop();
                }
            }
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            SettingsTimer.Start();
        }
    }
}
