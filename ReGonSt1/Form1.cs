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
        bool listCollapsed;
        bool sub1Collapsed;

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
            ListSub1Timer.Start();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var Info = new InformationForm();
            Info.Show();
        }

        private void ListTimer_Tick(object sender, EventArgs e)
        {
            if (listCollapsed)
            {
                panel_List1Container.Height += 10;
                if (panel_List1Container.Height == panel_List1Container.MaximumSize.Height)
                {
                    listCollapsed = false;
                    ListTimer.Stop();
                }
            }
            else
            {
                panel_List1Container.Height -= 10;
                if (panel_List1Container.Height == panel_List1Container.MinimumSize.Height)
                {
                    listCollapsed = true;
                    ListTimer.Stop();
                }
            }
        }

        private void button_List1_Click(object sender, EventArgs e)
        {
            ListTimer.Start();
        }

        private void button_Help_Click(object sender, EventArgs e)
        {

        }

        private void button_List1_sub1_Click(object sender, EventArgs e)
        {
            form_GTNH GTNH_forms = new form_GTNH();
            GTNH_forms.TopLevel = false;
            panel_SubForm.Controls.Add(GTNH_forms);
            GTNH_forms.BringToFront();
            GTNH_forms.Show();
        }

        private void ListSub1Timer_Tick(object sender, EventArgs e)
        {
            if (sub1Collapsed)
            {
                panel_SubForm.Width -= 10;
                if (panel_SubForm.Width == panel_SubForm.MinimumSize.Width)
                {
                    sub1Collapsed = false;
                    ListSub1Timer.Stop();
                }
            }
            else
            {
                panel_SubForm.Height += 10;
                if (panel_SubForm.Width == panel_SubForm.MaximumSize.Width)
                {
                    sub1Collapsed = true;
                    ListSub1Timer.Stop();
                }
            }
        }
    }
}
