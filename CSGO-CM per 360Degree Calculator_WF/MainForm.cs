using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGO_CM_per_360Degree_Calculator_WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateValue()
        {
            double DPIValue = 0.0;
            int WinSensiValueInt = 0;
            double WinSensiValue = 0.0;
            double InGameSensiValue = 0.0;
            double YawValue = 0.0;
            double PitchValue = 0.0;

            double EffectiveDPIValue = 0.0;

            if(!double.TryParse(DPITextBox.Text, out DPIValue))
            {
                MessageBox.Show("잘못된 DPI 값입니다!", "Wrong DPI Value!", MessageBoxButtons.OK);
                return;
            }

            if(!int.TryParse((string)WinSensiCombobox.SelectedItem, out WinSensiValueInt))
            {
                MessageBox.Show("Windows Sensitivity 값을 먼저 선택해주세요!", "Please Select Windows Sensitivity First!", MessageBoxButtons.OK);
                return;
            }
            else
            {
                WinSensiValue = (WinSensiValueInt / 11.0);
            }

            if (!double.TryParse(InGameSensiTextbox.Text, out InGameSensiValue))
            {
                MessageBox.Show("잘못된 In-Game Sensitivity 값입니다!", "Wrong In-Game Sensitivity Value!", MessageBoxButtons.OK);
                return;
            }

            if (!double.TryParse(YawTextbox.Text, out YawValue))
            {
                MessageBox.Show("잘못된 m_yaw 값입니다!", "Wrong m_yaw Value!", MessageBoxButtons.OK);
                return;
            }

            if (!double.TryParse(PitchTextbox.Text, out PitchValue))
            {
                MessageBox.Show("잘못된 m_pitch 값입니다!", "Wrong m_pitch Value!", MessageBoxButtons.OK);
                return;
            }

            if(RawInputCheckBox.Checked)
            {
                EffectiveDPIValue = (DPIValue * InGameSensiValue);
            }
            else
            {
                EffectiveDPIValue = (DPIValue * InGameSensiValue * WinSensiValue);
            }

            double CmPer360DegX = (360.0 / (EffectiveDPIValue * PitchValue)) * 2.54;
            double CmPer360DegY = (360.0 / (EffectiveDPIValue * YawValue)) * 2.54;

            EffectiveDPITextbox.Text = EffectiveDPIValue.ToString();
            ResultTextbox.Text = "(" + CmPer360DegX.ToString("0.0") + "," + CmPer360DegY.ToString("0.0") + ") cm/360°";
        }

        private void ValueChangedEvent(object Sender, EventArgs Event)
        {
            CalculateValue();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
