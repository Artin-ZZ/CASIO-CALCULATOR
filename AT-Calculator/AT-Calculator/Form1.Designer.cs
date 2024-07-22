using System.Windows.Forms;

namespace AT_Calculator
{
    partial class CASIO_Calc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CASIO_Calc));
            this.AC_Btn = new System.Windows.Forms.Button();
            this.CE_Btn = new System.Windows.Forms.Button();
            this.RadiOp = new System.Windows.Forms.Button();
            this.ModOp = new System.Windows.Forms.Button();
            this.TPowerOp = new System.Windows.Forms.Button();
            this.PowerOp = new System.Windows.Forms.Button();
            this.DivOp = new System.Windows.Forms.Button();
            this.MultipOp = new System.Windows.Forms.Button();
            this.SubtractOp = new System.Windows.Forms.Button();
            this.AddOp = new System.Windows.Forms.Button();
            this.EqOp = new System.Windows.Forms.Button();
            this.NumEightBtn = new System.Windows.Forms.Button();
            this.TripleZeroBtn = new System.Windows.Forms.Button();
            this.NumOneBtn = new System.Windows.Forms.Button();
            this.NumFourBtn = new System.Windows.Forms.Button();
            this.NumSevenBtn = new System.Windows.Forms.Button();
            this.NumNineBtn = new System.Windows.Forms.Button();
            this.DotOp = new System.Windows.Forms.Button();
            this.NumSixBtn = new System.Windows.Forms.Button();
            this.NumThreeBtn = new System.Windows.Forms.Button();
            this.NumTwoBtn = new System.Windows.Forms.Button();
            this.NumFiveBtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.TwoZeroBtn = new System.Windows.Forms.Button();
            this.CasioLbl = new System.Windows.Forms.Label();
            this.CalcLCD = new System.Windows.Forms.Label();
            this.OpContainer = new System.Windows.Forms.Label();
            this.OpCache = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AC_Btn
            // 
            this.AC_Btn.BackColor = System.Drawing.Color.Red;
            this.AC_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AC_Btn.FlatAppearance.BorderSize = 0;
            this.AC_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AC_Btn.ForeColor = System.Drawing.Color.White;
            this.AC_Btn.Location = new System.Drawing.Point(468, 89);
            this.AC_Btn.Name = "AC_Btn";
            this.AC_Btn.Size = new System.Drawing.Size(134, 66);
            this.AC_Btn.TabIndex = 1;
            this.AC_Btn.Text = "AC";
            this.AC_Btn.UseVisualStyleBackColor = false;
            this.AC_Btn.Click += new System.EventHandler(this.AC_Btn_Click);
            // 
            // CE_Btn
            // 
            this.CE_Btn.BackColor = System.Drawing.Color.Red;
            this.CE_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CE_Btn.FlatAppearance.BorderSize = 0;
            this.CE_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CE_Btn.ForeColor = System.Drawing.Color.White;
            this.CE_Btn.Location = new System.Drawing.Point(324, 89);
            this.CE_Btn.Name = "CE_Btn";
            this.CE_Btn.Size = new System.Drawing.Size(138, 66);
            this.CE_Btn.TabIndex = 2;
            this.CE_Btn.Text = "CE";
            this.CE_Btn.UseVisualStyleBackColor = false;
            this.CE_Btn.Click += new System.EventHandler(this.CE_Btn_Click);
            // 
            // RadiOp
            // 
            this.RadiOp.BackColor = System.Drawing.Color.Orange;
            this.RadiOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadiOp.FlatAppearance.BorderSize = 0;
            this.RadiOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RadiOp.Location = new System.Drawing.Point(468, 174);
            this.RadiOp.Name = "RadiOp";
            this.RadiOp.Size = new System.Drawing.Size(134, 43);
            this.RadiOp.TabIndex = 8;
            this.RadiOp.Text = "√";
            this.RadiOp.UseVisualStyleBackColor = false;
            this.RadiOp.Click += new System.EventHandler(this.RadiOp_Click);
            // 
            // ModOp
            // 
            this.ModOp.BackColor = System.Drawing.Color.Orange;
            this.ModOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModOp.FlatAppearance.BorderSize = 0;
            this.ModOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModOp.Location = new System.Drawing.Point(324, 174);
            this.ModOp.Name = "ModOp";
            this.ModOp.Size = new System.Drawing.Size(138, 43);
            this.ModOp.TabIndex = 9;
            this.ModOp.Text = "%";
            this.ModOp.UseVisualStyleBackColor = false;
            this.ModOp.Click += new System.EventHandler(this.ModOp_Click);
            // 
            // TPowerOp
            // 
            this.TPowerOp.BackColor = System.Drawing.Color.Orange;
            this.TPowerOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TPowerOp.FlatAppearance.BorderSize = 0;
            this.TPowerOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TPowerOp.Location = new System.Drawing.Point(174, 174);
            this.TPowerOp.Name = "TPowerOp";
            this.TPowerOp.Size = new System.Drawing.Size(144, 43);
            this.TPowerOp.TabIndex = 10;
            this.TPowerOp.Text = "X^2";
            this.TPowerOp.UseVisualStyleBackColor = false;
            this.TPowerOp.Click += new System.EventHandler(this.TPowerOp_Click);
            // 
            // PowerOp
            // 
            this.PowerOp.BackColor = System.Drawing.Color.Orange;
            this.PowerOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerOp.FlatAppearance.BorderSize = 0;
            this.PowerOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerOp.Location = new System.Drawing.Point(12, 174);
            this.PowerOp.Name = "PowerOp";
            this.PowerOp.Size = new System.Drawing.Size(154, 43);
            this.PowerOp.TabIndex = 11;
            this.PowerOp.Text = "X^Y";
            this.PowerOp.UseVisualStyleBackColor = false;
            this.PowerOp.Click += new System.EventHandler(this.PowerOp_Click);
            // 
            // DivOp
            // 
            this.DivOp.BackColor = System.Drawing.Color.Orange;
            this.DivOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivOp.FlatAppearance.BorderSize = 0;
            this.DivOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivOp.Location = new System.Drawing.Point(468, 225);
            this.DivOp.Name = "DivOp";
            this.DivOp.Size = new System.Drawing.Size(134, 43);
            this.DivOp.TabIndex = 13;
            this.DivOp.Text = "÷";
            this.DivOp.UseVisualStyleBackColor = false;
            this.DivOp.Click += new System.EventHandler(this.DivOp_Click);
            // 
            // MultipOp
            // 
            this.MultipOp.BackColor = System.Drawing.Color.Orange;
            this.MultipOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MultipOp.FlatAppearance.BorderSize = 0;
            this.MultipOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultipOp.Location = new System.Drawing.Point(468, 274);
            this.MultipOp.Name = "MultipOp";
            this.MultipOp.Size = new System.Drawing.Size(134, 43);
            this.MultipOp.TabIndex = 14;
            this.MultipOp.Text = "x";
            this.MultipOp.UseVisualStyleBackColor = false;
            this.MultipOp.Click += new System.EventHandler(this.MultipOp_Click);
            // 
            // SubtractOp
            // 
            this.SubtractOp.BackColor = System.Drawing.Color.Orange;
            this.SubtractOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubtractOp.FlatAppearance.BorderSize = 0;
            this.SubtractOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtractOp.Location = new System.Drawing.Point(468, 323);
            this.SubtractOp.Name = "SubtractOp";
            this.SubtractOp.Size = new System.Drawing.Size(134, 43);
            this.SubtractOp.TabIndex = 15;
            this.SubtractOp.Text = "-";
            this.SubtractOp.UseVisualStyleBackColor = false;
            this.SubtractOp.Click += new System.EventHandler(this.SubtractOp_Click);
            // 
            // AddOp
            // 
            this.AddOp.BackColor = System.Drawing.Color.Orange;
            this.AddOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddOp.FlatAppearance.BorderSize = 0;
            this.AddOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOp.Location = new System.Drawing.Point(468, 372);
            this.AddOp.Name = "AddOp";
            this.AddOp.Size = new System.Drawing.Size(134, 43);
            this.AddOp.TabIndex = 16;
            this.AddOp.Text = "+";
            this.AddOp.UseVisualStyleBackColor = false;
            this.AddOp.Click += new System.EventHandler(this.AddOp_Click);
            // 
            // EqOp
            // 
            this.EqOp.BackColor = System.Drawing.Color.Lime;
            this.EqOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EqOp.FlatAppearance.BorderSize = 0;
            this.EqOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqOp.Location = new System.Drawing.Point(324, 421);
            this.EqOp.Name = "EqOp";
            this.EqOp.Size = new System.Drawing.Size(278, 68);
            this.EqOp.TabIndex = 17;
            this.EqOp.Text = "=";
            this.EqOp.UseVisualStyleBackColor = false;
            this.EqOp.Click += new System.EventHandler(this.EqOp_Click);
            // 
            // NumEightBtn
            // 
            this.NumEightBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NumEightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumEightBtn.FlatAppearance.BorderSize = 0;
            this.NumEightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumEightBtn.ForeColor = System.Drawing.Color.White;
            this.NumEightBtn.Location = new System.Drawing.Point(174, 225);
            this.NumEightBtn.Name = "NumEightBtn";
            this.NumEightBtn.Size = new System.Drawing.Size(144, 43);
            this.NumEightBtn.TabIndex = 18;
            this.NumEightBtn.Text = "8";
            this.NumEightBtn.UseVisualStyleBackColor = false;
            this.NumEightBtn.Click += new System.EventHandler(this.NumEightBtn_Click);
            // 
            // TripleZeroBtn
            // 
            this.TripleZeroBtn.BackColor = System.Drawing.Color.DarkGray;
            this.TripleZeroBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TripleZeroBtn.FlatAppearance.BorderSize = 0;
            this.TripleZeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TripleZeroBtn.ForeColor = System.Drawing.Color.White;
            this.TripleZeroBtn.Location = new System.Drawing.Point(14, 372);
            this.TripleZeroBtn.Name = "TripleZeroBtn";
            this.TripleZeroBtn.Size = new System.Drawing.Size(154, 43);
            this.TripleZeroBtn.TabIndex = 19;
            this.TripleZeroBtn.Text = "000";
            this.TripleZeroBtn.UseVisualStyleBackColor = false;
            this.TripleZeroBtn.Click += new System.EventHandler(this.TripleZeroBtn_Click);
            // 
            // NumOneBtn
            // 
            this.NumOneBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NumOneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumOneBtn.FlatAppearance.BorderSize = 0;
            this.NumOneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumOneBtn.ForeColor = System.Drawing.Color.White;
            this.NumOneBtn.Location = new System.Drawing.Point(14, 323);
            this.NumOneBtn.Name = "NumOneBtn";
            this.NumOneBtn.Size = new System.Drawing.Size(154, 43);
            this.NumOneBtn.TabIndex = 20;
            this.NumOneBtn.Text = "1";
            this.NumOneBtn.UseVisualStyleBackColor = false;
            this.NumOneBtn.Click += new System.EventHandler(this.NumOneBtn_Click);
            // 
            // NumFourBtn
            // 
            this.NumFourBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NumFourBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumFourBtn.FlatAppearance.BorderSize = 0;
            this.NumFourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumFourBtn.ForeColor = System.Drawing.Color.White;
            this.NumFourBtn.Location = new System.Drawing.Point(14, 274);
            this.NumFourBtn.Name = "NumFourBtn";
            this.NumFourBtn.Size = new System.Drawing.Size(154, 43);
            this.NumFourBtn.TabIndex = 21;
            this.NumFourBtn.Text = "4";
            this.NumFourBtn.UseVisualStyleBackColor = false;
            this.NumFourBtn.Click += new System.EventHandler(this.NumFourBtn_Click);
            // 
            // NumSevenBtn
            // 
            this.NumSevenBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NumSevenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumSevenBtn.FlatAppearance.BorderSize = 0;
            this.NumSevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumSevenBtn.ForeColor = System.Drawing.Color.White;
            this.NumSevenBtn.Location = new System.Drawing.Point(14, 225);
            this.NumSevenBtn.Name = "NumSevenBtn";
            this.NumSevenBtn.Size = new System.Drawing.Size(154, 43);
            this.NumSevenBtn.TabIndex = 22;
            this.NumSevenBtn.Text = "7";
            this.NumSevenBtn.UseVisualStyleBackColor = false;
            this.NumSevenBtn.Click += new System.EventHandler(this.NumSevenBtn_Click);
            // 
            // NumNineBtn
            // 
            this.NumNineBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NumNineBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumNineBtn.FlatAppearance.BorderSize = 0;
            this.NumNineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumNineBtn.ForeColor = System.Drawing.Color.White;
            this.NumNineBtn.Location = new System.Drawing.Point(324, 225);
            this.NumNineBtn.Name = "NumNineBtn";
            this.NumNineBtn.Size = new System.Drawing.Size(138, 43);
            this.NumNineBtn.TabIndex = 23;
            this.NumNineBtn.Text = "9";
            this.NumNineBtn.UseVisualStyleBackColor = false;
            this.NumNineBtn.Click += new System.EventHandler(this.NumNineBtn_Click);
            // 
            // DotOp
            // 
            this.DotOp.BackColor = System.Drawing.Color.Orange;
            this.DotOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DotOp.FlatAppearance.BorderSize = 0;
            this.DotOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DotOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotOp.Location = new System.Drawing.Point(14, 421);
            this.DotOp.Name = "DotOp";
            this.DotOp.Size = new System.Drawing.Size(304, 68);
            this.DotOp.TabIndex = 24;
            this.DotOp.Text = ".";
            this.DotOp.UseVisualStyleBackColor = false;
            this.DotOp.Click += new System.EventHandler(this.DotOp_Click);
            // 
            // NumSixBtn
            // 
            this.NumSixBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NumSixBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumSixBtn.FlatAppearance.BorderSize = 0;
            this.NumSixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumSixBtn.ForeColor = System.Drawing.Color.White;
            this.NumSixBtn.Location = new System.Drawing.Point(324, 274);
            this.NumSixBtn.Name = "NumSixBtn";
            this.NumSixBtn.Size = new System.Drawing.Size(138, 43);
            this.NumSixBtn.TabIndex = 25;
            this.NumSixBtn.Text = "6";
            this.NumSixBtn.UseVisualStyleBackColor = false;
            this.NumSixBtn.Click += new System.EventHandler(this.NumSixBtn_Click);
            // 
            // NumThreeBtn
            // 
            this.NumThreeBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NumThreeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumThreeBtn.FlatAppearance.BorderSize = 0;
            this.NumThreeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumThreeBtn.ForeColor = System.Drawing.Color.White;
            this.NumThreeBtn.Location = new System.Drawing.Point(324, 323);
            this.NumThreeBtn.Name = "NumThreeBtn";
            this.NumThreeBtn.Size = new System.Drawing.Size(138, 43);
            this.NumThreeBtn.TabIndex = 26;
            this.NumThreeBtn.Text = "3";
            this.NumThreeBtn.UseVisualStyleBackColor = false;
            this.NumThreeBtn.Click += new System.EventHandler(this.NumThreeBtn_Click);
            // 
            // NumTwoBtn
            // 
            this.NumTwoBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NumTwoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumTwoBtn.FlatAppearance.BorderSize = 0;
            this.NumTwoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumTwoBtn.ForeColor = System.Drawing.Color.White;
            this.NumTwoBtn.Location = new System.Drawing.Point(174, 323);
            this.NumTwoBtn.Name = "NumTwoBtn";
            this.NumTwoBtn.Size = new System.Drawing.Size(144, 43);
            this.NumTwoBtn.TabIndex = 27;
            this.NumTwoBtn.Text = "2";
            this.NumTwoBtn.UseVisualStyleBackColor = false;
            this.NumTwoBtn.Click += new System.EventHandler(this.NumTwoBtn_Click);
            // 
            // NumFiveBtn
            // 
            this.NumFiveBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NumFiveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumFiveBtn.FlatAppearance.BorderSize = 0;
            this.NumFiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumFiveBtn.ForeColor = System.Drawing.Color.White;
            this.NumFiveBtn.Location = new System.Drawing.Point(174, 274);
            this.NumFiveBtn.Name = "NumFiveBtn";
            this.NumFiveBtn.Size = new System.Drawing.Size(144, 43);
            this.NumFiveBtn.TabIndex = 28;
            this.NumFiveBtn.Text = "5";
            this.NumFiveBtn.UseVisualStyleBackColor = false;
            this.NumFiveBtn.Click += new System.EventHandler(this.NumFiveBtn_Click);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ZeroBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZeroBtn.FlatAppearance.BorderSize = 0;
            this.ZeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroBtn.ForeColor = System.Drawing.Color.White;
            this.ZeroBtn.Location = new System.Drawing.Point(324, 372);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(138, 43);
            this.ZeroBtn.TabIndex = 30;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = false;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // TwoZeroBtn
            // 
            this.TwoZeroBtn.BackColor = System.Drawing.Color.DarkGray;
            this.TwoZeroBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TwoZeroBtn.FlatAppearance.BorderSize = 0;
            this.TwoZeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoZeroBtn.ForeColor = System.Drawing.Color.White;
            this.TwoZeroBtn.Location = new System.Drawing.Point(174, 372);
            this.TwoZeroBtn.Name = "TwoZeroBtn";
            this.TwoZeroBtn.Size = new System.Drawing.Size(144, 43);
            this.TwoZeroBtn.TabIndex = 32;
            this.TwoZeroBtn.Text = "00";
            this.TwoZeroBtn.UseVisualStyleBackColor = false;
            this.TwoZeroBtn.Click += new System.EventHandler(this.TwoZeroBtn_Click);
            // 
            // CasioLbl
            // 
            this.CasioLbl.AutoSize = true;
            this.CasioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CasioLbl.ForeColor = System.Drawing.Color.White;
            this.CasioLbl.Location = new System.Drawing.Point(18, 95);
            this.CasioLbl.MaximumSize = new System.Drawing.Size(300, 60);
            this.CasioLbl.MinimumSize = new System.Drawing.Size(300, 60);
            this.CasioLbl.Name = "CasioLbl";
            this.CasioLbl.Size = new System.Drawing.Size(300, 60);
            this.CasioLbl.TabIndex = 33;
            this.CasioLbl.Text = "CASIO";
            this.CasioLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcLCD
            // 
            this.CalcLCD.AutoSize = true;
            this.CalcLCD.BackColor = System.Drawing.Color.Gray;
            this.CalcLCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalcLCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CalcLCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcLCD.Location = new System.Drawing.Point(12, 9);
            this.CalcLCD.MaximumSize = new System.Drawing.Size(590, 70);
            this.CalcLCD.MinimumSize = new System.Drawing.Size(590, 70);
            this.CalcLCD.Name = "CalcLCD";
            this.CalcLCD.Size = new System.Drawing.Size(590, 70);
            this.CalcLCD.TabIndex = 38;
            this.CalcLCD.Text = "0";
            this.CalcLCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpContainer
            // 
            this.OpContainer.AutoSize = true;
            this.OpContainer.Location = new System.Drawing.Point(12, 492);
            this.OpContainer.MaximumSize = new System.Drawing.Size(590, 0);
            this.OpContainer.MinimumSize = new System.Drawing.Size(590, 0);
            this.OpContainer.Name = "OpContainer";
            this.OpContainer.Size = new System.Drawing.Size(590, 29);
            this.OpContainer.TabIndex = 39;
            this.OpContainer.Visible = false;
            // 
            // OpCache
            // 
            this.OpCache.AutoSize = true;
            this.OpCache.Location = new System.Drawing.Point(12, 536);
            this.OpCache.MaximumSize = new System.Drawing.Size(590, 70);
            this.OpCache.MinimumSize = new System.Drawing.Size(590, 70);
            this.OpCache.Name = "OpCache";
            this.OpCache.Size = new System.Drawing.Size(590, 70);
            this.OpCache.TabIndex = 40;
            // 
            // CASIO_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(612, 503);
            this.Controls.Add(this.OpCache);
            this.Controls.Add(this.OpContainer);
            this.Controls.Add(this.CalcLCD);
            this.Controls.Add(this.CasioLbl);
            this.Controls.Add(this.TwoZeroBtn);
            this.Controls.Add(this.ZeroBtn);
            this.Controls.Add(this.NumFiveBtn);
            this.Controls.Add(this.NumTwoBtn);
            this.Controls.Add(this.NumThreeBtn);
            this.Controls.Add(this.NumSixBtn);
            this.Controls.Add(this.DotOp);
            this.Controls.Add(this.NumNineBtn);
            this.Controls.Add(this.NumSevenBtn);
            this.Controls.Add(this.NumFourBtn);
            this.Controls.Add(this.NumOneBtn);
            this.Controls.Add(this.TripleZeroBtn);
            this.Controls.Add(this.NumEightBtn);
            this.Controls.Add(this.EqOp);
            this.Controls.Add(this.AddOp);
            this.Controls.Add(this.SubtractOp);
            this.Controls.Add(this.MultipOp);
            this.Controls.Add(this.DivOp);
            this.Controls.Add(this.PowerOp);
            this.Controls.Add(this.TPowerOp);
            this.Controls.Add(this.ModOp);
            this.Controls.Add(this.RadiOp);
            this.Controls.Add(this.CE_Btn);
            this.Controls.Add(this.AC_Btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(630, 550);
            this.MinimumSize = new System.Drawing.Size(630, 550);
            this.Name = "CASIO_Calc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CASIO CALCULATOR";
            this.Load += new System.EventHandler(this.CASIO_Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AC_Btn;
        private System.Windows.Forms.Button CE_Btn;
        private System.Windows.Forms.Button RadiOp;
        private System.Windows.Forms.Button ModOp;
        private System.Windows.Forms.Button TPowerOp;
        private System.Windows.Forms.Button PowerOp;
        private System.Windows.Forms.Button DivOp;
        private System.Windows.Forms.Button MultipOp;
        private System.Windows.Forms.Button SubtractOp;
        private System.Windows.Forms.Button AddOp;
        private System.Windows.Forms.Button EqOp;
        private System.Windows.Forms.Button NumEightBtn;
        private System.Windows.Forms.Button TripleZeroBtn;
        private System.Windows.Forms.Button NumOneBtn;
        private System.Windows.Forms.Button NumFourBtn;
        private System.Windows.Forms.Button NumSevenBtn;
        private System.Windows.Forms.Button NumNineBtn;
        private System.Windows.Forms.Button DotOp;
        private System.Windows.Forms.Button NumSixBtn;
        private System.Windows.Forms.Button NumThreeBtn;
        private System.Windows.Forms.Button NumTwoBtn;
        private System.Windows.Forms.Button NumFiveBtn;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button TwoZeroBtn;
        private System.Windows.Forms.Label CasioLbl;
        private Label CalcLCD;
        private Label OpContainer;
        private Label OpCache;
    }
}

