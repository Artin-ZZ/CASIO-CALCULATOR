using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AT_Calculator
{
    public partial class CASIO_Calc : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nRight,
            int nTop,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllise
        );
        public CASIO_Calc()
        {
            InitializeComponent();
        }

        private void CASIO_Calc_Load(object sender, EventArgs e)
        {
            AC_Btn.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,AC_Btn.Width,AC_Btn.Height,10,10));
            CE_Btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, CE_Btn.Width, CE_Btn.Height, 10, 10));
            RadiOp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, RadiOp.Width, RadiOp.Height, 10, 10));
            ModOp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ModOp.Width, ModOp.Height, 10, 10));
            TPowerOp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TPowerOp.Width, TPowerOp.Height, 10, 10));
            PowerOp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PowerOp.Width, PowerOp.Height, 10, 10));
            DivOp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, DivOp.Width, DivOp.Height, 10, 10));
            MultipOp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, MultipOp.Width, MultipOp.Height, 10, 10));
            SubtractOp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SubtractOp.Width, SubtractOp.Height, 10, 10));
            AddOp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AddOp.Width, AddOp.Height, 10, 10));
            EqOp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, EqOp.Width, EqOp.Height, 10, 10));
            DotOp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, DotOp.Width, DotOp.Height, 10, 10));
            ZeroBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ZeroBtn.Width, ZeroBtn.Height, 10, 10));
            TwoZeroBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TwoZeroBtn.Width, TwoZeroBtn.Height, 10, 10));
            TripleZeroBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TripleZeroBtn.Width, TripleZeroBtn.Height, 10, 10));
            NumThreeBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NumThreeBtn.Width, NumThreeBtn.Height, 10, 10));
            NumTwoBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NumTwoBtn.Width, NumTwoBtn.Height, 10, 10));
            NumOneBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NumOneBtn.Width, NumOneBtn.Height, 10, 10));
            NumFourBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NumFourBtn.Width, NumFourBtn.Height, 10, 10));
            NumFiveBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NumFiveBtn.Width, NumFiveBtn.Height, 10, 10));
            NumSixBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NumSixBtn.Width, NumSixBtn.Height, 10, 10));
            NumSevenBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NumSevenBtn.Width, NumSevenBtn.Height, 10, 10));
            NumEightBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NumEightBtn.Width, NumEightBtn.Height, 10, 10));
            NumNineBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, NumNineBtn.Width, NumNineBtn.Height, 10, 10));
        }

        private void AC_Btn_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = "0";
            OpContainer.Text = "";
            OpCache.Text = "0";
        }

        private void CE_Btn_Click(object sender, EventArgs e)
        {
            CalcLCD.Text = "0";
        }

        private void TripleZeroBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28)
            {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "0";
                }
                else
                {
                    CalcLCD.Text += "000";
                }
            }
        }

        private void TwoZeroBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28){
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "0";
                }
                else
                {
                    CalcLCD.Text += "00";
                }
            }
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28)
            {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "0";
                }
                else
                {
                    CalcLCD.Text += "0";
                }
            }
        }

        private void NumOneBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28)
            {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "1";
                }
                else
                {
                    CalcLCD.Text += "1";
                }
            }
        }

        private void NumTwoBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28)
            {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "2";
                }
                else
                {
                    CalcLCD.Text += "2";
                }
            }
        }

        private void NumThreeBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28)
            {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "3";
                }
                else
                {
                    CalcLCD.Text += "3";
                }
            }
        }

        private void NumFourBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28)
            {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "4";
                }
                else
                {
                    CalcLCD.Text += "4";
                }
            }
        }

        private void NumFiveBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28)
            {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "5";
                }
                else
                {
                    CalcLCD.Text += "5";
                }
            }
        }

        private void NumSixBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28)
            {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "6";
                }
                else
                {
                    CalcLCD.Text += "6";
                }
            }
        }

        private void NumSevenBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28)
            {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "7";
                }
                else
                {
                    CalcLCD.Text += "7";
                }
            }
        }

        private void NumEightBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28) {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "8";
                }
                else
                {
                    CalcLCD.Text += "8";
                }
            }
        }

        private void NumNineBtn_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text.Length <= 28)
            {
                if (CalcLCD.Text == "0")
                {
                    CalcLCD.Text = "9";
                }
                else
                {
                    CalcLCD.Text += "9";
                }
            }
        }

        private void DotOp_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text == "0")
            {
                CalcLCD.Text = "0.";
            }
            else
            {
                CalcLCD.Text += ".";
            }
        }

        private void AddOp_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text == "0")
            {
                CalcLCD.Text = "0";
            }
            else
            {
                OpCache.Text = CalcLCD.Text;
                OpContainer.Text = "+";
                CalcLCD.Text = "0";
            }
        }

        private void SubtractOp_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text == "0")
            {
                CalcLCD.Text = "0";
            }
            else
            {
                OpCache.Text = CalcLCD.Text;
                OpContainer.Text = "-";
                CalcLCD.Text = "0";
            }
        }

        private void MultipOp_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text == "0")
            {
                CalcLCD.Text = "0";
            }
            else
            {
                OpCache.Text = CalcLCD.Text;
                OpContainer.Text = "*";
                CalcLCD.Text = "0";
            }
        }


        private void DivOp_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text == "0")
            {
                CalcLCD.Text = "0";
            }
            else
            {
                OpCache.Text = CalcLCD.Text;
                OpContainer.Text = "/";
                CalcLCD.Text = "0";
            }
        }

        private void RadiOp_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text == "0")
            {
                CalcLCD.Text = "0";
            }
            else
            {
                OpCache.Text = CalcLCD.Text;
                OpContainer.Text = "sqrt";
            }
        }

        private void ModOp_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text == "0")
            {
                CalcLCD.Text = "0";
            }
            else
            {
                OpCache.Text = CalcLCD.Text;
                OpContainer.Text = "%";
                CalcLCD.Text = "0";
            }
        }


        private void TPowerOp_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text == "0")
            {
                CalcLCD.Text = "0";
            }
            else
            {
                OpCache.Text = CalcLCD.Text;
                OpContainer.Text = "^2";

                double P2_Res = Math.Pow(Convert.ToDouble(CalcLCD.Text), 2);
                CalcLCD.Text = Convert.ToString(P2_Res);
                OpCache.Text = Convert.ToString(P2_Res);
            }
        }
        private void PowerOp_Click(object sender, EventArgs e)
        {
            if (CalcLCD.Text == "0")
            {
                CalcLCD.Text = "0";
            }
            else
            {
                OpCache.Text = CalcLCD.Text;
                OpContainer.Text = "^";
                CalcLCD.Text = "0";
            }
        }

        private void EqOp_Click(object sender, EventArgs e)
        {
            if (OpContainer.Text == "+")
            {
                // Addition Operation:
                double Add_Res = Convert.ToDouble(OpCache.Text) + Convert.ToDouble(CalcLCD.Text);
                CalcLCD.Text = Convert.ToString(Add_Res);
                OpCache.Text = Convert.ToString(Add_Res);
            }
            else if (OpContainer.Text == "-")
            {
                // Subtraction Operation:
                double Subt_Res = Convert.ToDouble(OpCache.Text) - Convert.ToDouble(CalcLCD.Text);
                CalcLCD.Text = Convert.ToString(Subt_Res);
                OpCache.Text = Convert.ToString(Subt_Res);
            }

            else if (OpContainer.Text == "*")
            {
                // Multiply Operation:
                double Mult_Res = Convert.ToDouble(OpCache.Text) * Convert.ToDouble(CalcLCD.Text);
                CalcLCD.Text = Convert.ToString(Mult_Res);
                OpCache.Text = Convert.ToString(Mult_Res);
            }

            else if (OpContainer.Text == "/")
            {
                // Division Operation:
                double Div_Res = Convert.ToDouble(OpCache.Text) / Convert.ToDouble(CalcLCD.Text);
                CalcLCD.Text = Convert.ToString(Div_Res);
                OpCache.Text = Convert.ToString(Div_Res);
            }

            else if (OpContainer.Text == "sqrt") {
                // Sqrt Operation:
                double sqrt_Res = Math.Sqrt(Convert.ToDouble(CalcLCD.Text));
                CalcLCD.Text = Convert.ToString(sqrt_Res);
                OpCache.Text = Convert.ToString(sqrt_Res);
            }

            else if (OpContainer.Text == "%")
            {
                // Modulous Operation:
                double Mod_Res = Convert.ToDouble(OpCache.Text) % Convert.ToDouble(CalcLCD.Text);
                CalcLCD.Text = Convert.ToString(Mod_Res);
                OpCache.Text = Convert.ToString(Mod_Res);
            }

            else if (OpContainer.Text == "^")
            {
                // Power Of X Operation:
                double P2_Res = Math.Pow(Convert.ToDouble(OpCache.Text), Convert.ToDouble(CalcLCD.Text));
                CalcLCD.Text = Convert.ToString(P2_Res);
                OpCache.Text = Convert.ToString(P2_Res);
            }
        }
    }
}