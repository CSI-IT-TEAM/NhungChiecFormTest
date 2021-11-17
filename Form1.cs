using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhungChiecFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            try
            {
                if (e.SelectedControl != labelControl1) return;

                string text = e.SelectedControl.Text;
                SettingsToolTips((DevExpress.XtraEditors.LabelControl)e.SelectedControl,text);


            }
            catch (Exception ex)
            {

            }
        }
        private void SettingsToolTips(DevExpress.XtraEditors.LabelControl ctl, string Decript)
        {
            try
            {
             

                toolTipController1.ToolTipType = ToolTipType.Default;
                toolTipController1.Appearance.Font = new System.Drawing.Font("Time New Roman", 12, FontStyle.Bold ^ FontStyle.Italic);
                toolTipController1.Appearance.ForeColor = Color.Blue;
                toolTipController1.Rounded = true;
                toolTipController1.ShowBeak = true;
                toolTipController1.ShowShadow = true;
                toolTipController1.SetToolTip(ctl,string.Concat("Text  : ", Decript));
                toolTipController1.SetTitle(ctl,"Detail Information: ");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
