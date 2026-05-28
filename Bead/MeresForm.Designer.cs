namespace Bead.Forms
{
    partial class MeresForm
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
            datepicker = new DateTimePicker();
            nud_Homerseklet = new NumericUpDown();
            nud_Legnyomas = new NumericUpDown();
            nud_Csapadek = new NumericUpDown();
            nud_HarmatPont = new NumericUpDown();
            label1 = new Label();
            btn_cancel = new Button();
            btn_SaveData = new Button();
            label2 = new Label();
            lbl_legnyomas = new Label();
            lbl_csapadek = new Label();
            lbl_harmatpont = new Label();
            lbl_bent = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_Homerseklet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Legnyomas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Csapadek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_HarmatPont).BeginInit();
            SuspendLayout();
            // 
            // datepicker
            // 
            datepicker.Location = new Point(242, 58);
            datepicker.Name = "datepicker";
            datepicker.Size = new Size(271, 27);
            datepicker.TabIndex = 12;
            // 
            // nud_Homerseklet
            // 
            nud_Homerseklet.Location = new Point(70, 146);
            nud_Homerseklet.Name = "nud_Homerseklet";
            nud_Homerseklet.Size = new Size(150, 27);
            nud_Homerseklet.TabIndex = 13;
            // 
            // nud_Legnyomas
            // 
            nud_Legnyomas.Location = new Point(276, 146);
            nud_Legnyomas.Name = "nud_Legnyomas";
            nud_Legnyomas.Size = new Size(150, 27);
            nud_Legnyomas.TabIndex = 14;
            // 
            // nud_Csapadek
            // 
            nud_Csapadek.Location = new Point(477, 146);
            nud_Csapadek.Name = "nud_Csapadek";
            nud_Csapadek.Size = new Size(150, 27);
            nud_Csapadek.TabIndex = 15;
            // 
            // nud_HarmatPont
            // 
            nud_HarmatPont.Location = new Point(70, 220);
            nud_HarmatPont.Name = "nud_HarmatPont";
            nud_HarmatPont.Size = new Size(150, 27);
            nud_HarmatPont.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 13);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 17;
            label1.Text = "Új Mérés";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(103, 270);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 18;
            btn_cancel.Text = "Vissza";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_SaveData
            // 
            btn_SaveData.Location = new Point(441, 265);
            btn_SaveData.Name = "btn_SaveData";
            btn_SaveData.Size = new Size(94, 29);
            btn_SaveData.TabIndex = 19;
            btn_SaveData.Text = "Mentés";
            btn_SaveData.UseVisualStyleBackColor = true;
            btn_SaveData.Click += btn_SaveData_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 114);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 20;
            label2.Text = "Hőmérséklet";
            // 
            // lbl_legnyomas
            // 
            lbl_legnyomas.AutoSize = true;
            lbl_legnyomas.Location = new Point(303, 114);
            lbl_legnyomas.Name = "lbl_legnyomas";
            lbl_legnyomas.Size = new Size(84, 20);
            lbl_legnyomas.TabIndex = 21;
            lbl_legnyomas.Text = "Légnyomás";
            // 
            // lbl_csapadek
            // 
            lbl_csapadek.AutoSize = true;
            lbl_csapadek.Location = new Point(513, 114);
            lbl_csapadek.Name = "lbl_csapadek";
            lbl_csapadek.Size = new Size(73, 20);
            lbl_csapadek.TabIndex = 22;
            lbl_csapadek.Text = "Csapadék";
            // 
            // lbl_harmatpont
            // 
            lbl_harmatpont.AutoSize = true;
            lbl_harmatpont.Location = new Point(103, 186);
            lbl_harmatpont.Name = "lbl_harmatpont";
            lbl_harmatpont.Size = new Size(88, 20);
            lbl_harmatpont.TabIndex = 23;
            lbl_harmatpont.Text = "HarmatPont";
            // 
            // lbl_bent
            // 
            lbl_bent.AutoSize = true;
            lbl_bent.Location = new Point(55, 25);
            lbl_bent.Name = "lbl_bent";
            lbl_bent.Size = new Size(33, 20);
            lbl_bent.TabIndex = 24;
            lbl_bent.Text = "aha";
            // 
            // MeresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 338);
            Controls.Add(lbl_bent);
            Controls.Add(lbl_harmatpont);
            Controls.Add(lbl_csapadek);
            Controls.Add(lbl_legnyomas);
            Controls.Add(label2);
            Controls.Add(btn_SaveData);
            Controls.Add(btn_cancel);
            Controls.Add(label1);
            Controls.Add(nud_HarmatPont);
            Controls.Add(nud_Csapadek);
            Controls.Add(nud_Legnyomas);
            Controls.Add(nud_Homerseklet);
            Controls.Add(datepicker);
            Name = "MeresForm";
            Text = "MeresForm";
            ((System.ComponentModel.ISupportInitialize)nud_Homerseklet).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Legnyomas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Csapadek).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_HarmatPont).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datepicker;
        private NumericUpDown nud_Homerseklet;
        private NumericUpDown nud_Legnyomas;
        private NumericUpDown nud_Csapadek;
        private NumericUpDown nud_HarmatPont;
        private Label label1;
        private Button btn_cancel;
        private Button btn_SaveData;
        private Label label2;
        private Label lbl_legnyomas;
        private Label lbl_csapadek;
        private Label lbl_harmatpont;
        private Label lbl_bent;
    }
}