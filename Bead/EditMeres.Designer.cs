namespace Bead.Forms
{
    partial class EditMeres
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
            lbl_MeresId = new Label();
            nud_Homerseklet = new NumericUpDown();
            nud_Harmatpont = new NumericUpDown();
            cb_MeresType = new ComboBox();
            dtp_Meres = new DateTimePicker();
            nud_Csapadek = new NumericUpDown();
            nud_Legnyomas = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_Modify = new Button();
            btn_Delete = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_Homerseklet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Harmatpont).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Csapadek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Legnyomas).BeginInit();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(88, 313);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Vissza";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // lbl_MeresId
            // 
            lbl_MeresId.AutoSize = true;
            lbl_MeresId.Location = new Point(49, 29);
            lbl_MeresId.Name = "lbl_MeresId";
            lbl_MeresId.Size = new Size(33, 20);
            lbl_MeresId.TabIndex = 1;
            lbl_MeresId.Text = "aha";
            // 
            // nud_Homerseklet
            // 
            nud_Homerseklet.Location = new Point(78, 154);
            nud_Homerseklet.Name = "nud_Homerseklet";
            nud_Homerseklet.Size = new Size(150, 27);
            nud_Homerseklet.TabIndex = 2;
            // 
            // nud_Harmatpont
            // 
            nud_Harmatpont.Location = new Point(78, 228);
            nud_Harmatpont.Name = "nud_Harmatpont";
            nud_Harmatpont.Size = new Size(150, 27);
            nud_Harmatpont.TabIndex = 3;
            // 
            // cb_MeresType
            // 
            cb_MeresType.FormattingEnabled = true;
            cb_MeresType.Location = new Point(198, 26);
            cb_MeresType.Name = "cb_MeresType";
            cb_MeresType.Size = new Size(151, 28);
            cb_MeresType.TabIndex = 4;
            cb_MeresType.SelectedIndexChanged += cb_MeresType_SelectedIndexChanged;
            // 
            // dtp_Meres
            // 
            dtp_Meres.Location = new Point(462, 26);
            dtp_Meres.Name = "dtp_Meres";
            dtp_Meres.Size = new Size(250, 27);
            dtp_Meres.TabIndex = 5;
            // 
            // nud_Csapadek
            // 
            nud_Csapadek.Location = new Point(482, 154);
            nud_Csapadek.Name = "nud_Csapadek";
            nud_Csapadek.Size = new Size(150, 27);
            nud_Csapadek.TabIndex = 7;
            // 
            // nud_Legnyomas
            // 
            nud_Legnyomas.Location = new Point(282, 154);
            nud_Legnyomas.Name = "nud_Legnyomas";
            nud_Legnyomas.Size = new Size(150, 27);
            nud_Legnyomas.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 122);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 8;
            label1.Text = "Hőmérséklet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 194);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 9;
            label2.Text = "Harmatpont";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 119);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 10;
            label3.Text = "Légnyomás";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(482, 116);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 11;
            label4.Text = "Csapadék";
            // 
            // btn_Modify
            // 
            btn_Modify.Location = new Point(321, 313);
            btn_Modify.Name = "btn_Modify";
            btn_Modify.Size = new Size(94, 29);
            btn_Modify.TabIndex = 12;
            btn_Modify.Text = "Módosítás";
            btn_Modify.UseVisualStyleBackColor = true;
            btn_Modify.Click += btn_Modify_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(538, 313);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 13;
            btn_Delete.Text = "Törlés";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 394);
            label5.Name = "label5";
            label5.Size = new Size(395, 20);
            label5.TabIndex = 14;
            label5.Text = "A NEM interaktálható dolgok NULL-ként lesznek elmentve.";
            // 
            // EditMeres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Modify);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nud_Csapadek);
            Controls.Add(nud_Legnyomas);
            Controls.Add(dtp_Meres);
            Controls.Add(cb_MeresType);
            Controls.Add(nud_Harmatpont);
            Controls.Add(nud_Homerseklet);
            Controls.Add(lbl_MeresId);
            Controls.Add(btn_Cancel);
            Name = "EditMeres";
            Text = "EditMeres";
            ((System.ComponentModel.ISupportInitialize)nud_Homerseklet).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Harmatpont).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Csapadek).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Legnyomas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Label lbl_MeresId;
        private NumericUpDown nud_Homerseklet;
        private NumericUpDown nud_Harmatpont;
        private ComboBox cb_MeresType;
        private DateTimePicker dtp_Meres;
        private NumericUpDown nud_Csapadek;
        private NumericUpDown nud_Legnyomas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_Modify;
        private Button btn_Delete;
        private Label label5;
    }
}