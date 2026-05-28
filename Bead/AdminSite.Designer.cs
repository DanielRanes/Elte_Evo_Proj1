namespace Bead.Forms
{
    partial class AdminSite
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
            btn_Cancel = new Button();
            dtp1 = new DateTimePicker();
            dtp2 = new DateTimePicker();
            dtp3 = new DateTimePicker();
            lbl_userW = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            btn_userM = new Button();
            btn_CircleR = new Button();
            btn_LineR = new Button();
            tc_Grafs = new TabControl();
            tp_Vonal = new TabPage();
            tp_Kor = new TabPage();
            btn_AXML = new Button();
            label1 = new Label();
            tc_Grafs.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(87, 744);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(109, 29);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Kijelentkezés";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(87, 72);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(250, 27);
            dtp1.TabIndex = 1;
            // 
            // dtp2
            // 
            dtp2.Location = new Point(87, 151);
            dtp2.Name = "dtp2";
            dtp2.Size = new Size(250, 27);
            dtp2.TabIndex = 2;
            // 
            // dtp3
            // 
            dtp3.Location = new Point(728, 138);
            dtp3.Name = "dtp3";
            dtp3.Size = new Size(250, 27);
            dtp3.TabIndex = 3;
            // 
            // lbl_userW
            // 
            lbl_userW.AutoSize = true;
            lbl_userW.Location = new Point(23, 9);
            lbl_userW.Name = "lbl_userW";
            lbl_userW.Size = new Size(33, 20);
            lbl_userW.TabIndex = 4;
            lbl_userW.Text = "aha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(799, 103);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "(Hetet jelöl)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 115);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 18;
            label5.Text = "Vége:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 43);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 17;
            label4.Text = "Kezdet:";
            // 
            // btn_userM
            // 
            btn_userM.Location = new Point(1059, 25);
            btn_userM.Name = "btn_userM";
            btn_userM.Size = new Size(94, 29);
            btn_userM.TabIndex = 19;
            btn_userM.Text = "Userek";
            btn_userM.UseVisualStyleBackColor = true;
            btn_userM.Click += btn_userM_Click;
            // 
            // btn_CircleR
            // 
            btn_CircleR.Location = new Point(910, 48);
            btn_CircleR.Name = "btn_CircleR";
            btn_CircleR.Size = new Size(94, 60);
            btn_CircleR.TabIndex = 20;
            btn_CircleR.Text = "Kör D. frissítés";
            btn_CircleR.UseVisualStyleBackColor = true;
            btn_CircleR.Click += btn_CircleR_Click;
            // 
            // btn_LineR
            // 
            btn_LineR.Location = new Point(394, 48);
            btn_LineR.Name = "btn_LineR";
            btn_LineR.Size = new Size(94, 72);
            btn_LineR.TabIndex = 21;
            btn_LineR.Text = "Vonal D. frissítés";
            btn_LineR.UseVisualStyleBackColor = true;
            btn_LineR.Click += btn_LineR_Click;
            // 
            // tc_Grafs
            // 
            tc_Grafs.Controls.Add(tp_Vonal);
            tc_Grafs.Controls.Add(tp_Kor);
            tc_Grafs.Location = new Point(306, 218);
            tc_Grafs.Name = "tc_Grafs";
            tc_Grafs.SelectedIndex = 0;
            tc_Grafs.Size = new Size(500, 472);
            tc_Grafs.TabIndex = 22;
            // 
            // tp_Vonal
            // 
            tp_Vonal.Location = new Point(4, 29);
            tp_Vonal.Name = "tp_Vonal";
            tp_Vonal.Padding = new Padding(3);
            tp_Vonal.Size = new Size(492, 439);
            tp_Vonal.TabIndex = 0;
            tp_Vonal.Text = "Vonal";
            tp_Vonal.UseVisualStyleBackColor = true;
            // 
            // tp_Kor
            // 
            tp_Kor.Location = new Point(4, 29);
            tp_Kor.Name = "tp_Kor";
            tp_Kor.Padding = new Padding(3);
            tp_Kor.Size = new Size(492, 439);
            tp_Kor.TabIndex = 1;
            tp_Kor.Text = "Kör";
            tp_Kor.UseVisualStyleBackColor = true;
            // 
            // btn_AXML
            // 
            btn_AXML.Location = new Point(886, 724);
            btn_AXML.Name = "btn_AXML";
            btn_AXML.Size = new Size(94, 49);
            btn_AXML.TabIndex = 23;
            btn_AXML.Text = "XML mentés";
            btn_AXML.UseVisualStyleBackColor = true;
            btn_AXML.Click += btn_AXML_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(689, 180);
            label1.Name = "label1";
            label1.Size = new Size(419, 20);
            label1.TabIndex = 24;
            label1.Text = "(ez állítja az XML fájl légnyomás méréseinek heti móduszát is)";
            // 
            // AdminSite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 801);
            Controls.Add(label1);
            Controls.Add(btn_AXML);
            Controls.Add(tc_Grafs);
            Controls.Add(btn_LineR);
            Controls.Add(btn_CircleR);
            Controls.Add(btn_userM);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lbl_userW);
            Controls.Add(dtp3);
            Controls.Add(dtp2);
            Controls.Add(dtp1);
            Controls.Add(btn_Cancel);
            Name = "AdminSite";
            Text = "AdminSite";
            tc_Grafs.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private DateTimePicker dtp1;
        private DateTimePicker dtp2;
        private DateTimePicker dtp3;
        private Label lbl_userW;
        private Label label2;
        private Label label5;
        private Label label4;
        private Button btn_userM;
        private Button btn_CircleR;
        private Button btn_LineR;
        private TabControl tc_Grafs;
        private TabPage tp_Vonal;
        private TabPage tp_Kor;
        private Button btn_AXML;
        private Label label1;
    }
}