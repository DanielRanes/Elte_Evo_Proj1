namespace Bead.Forms
{
    partial class UserSite
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
            lbl_welcome = new Label();
            btn_Back = new Button();
            dg_meresek = new DataGridView();
            MeroId = new DataGridViewTextBoxColumn();
            MeroDatum = new DataGridViewTextBoxColumn();
            MeroType = new DataGridViewTextBoxColumn();
            MeroHomerseklet = new DataGridViewTextBoxColumn();
            MeroHarmatPont = new DataGridViewTextBoxColumn();
            MeroParatartalom = new DataGridViewTextBoxColumn();
            MeroLegnyomas = new DataGridViewTextBoxColumn();
            MeroCsapadek = new DataGridViewTextBoxColumn();
            datepicker1 = new DateTimePicker();
            cb_InOrOut = new ComboBox();
            cb_Types = new ComboBox();
            btn_NewMeres = new Button();
            btn_GotoOwnMeres = new Button();
            btn_USaveXML = new Button();
            tb_Average = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            datepicker2 = new DateTimePicker();
            btn_Filter = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_meresek).BeginInit();
            SuspendLayout();
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Location = new Point(40, 20);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(33, 20);
            lbl_welcome.TabIndex = 0;
            lbl_welcome.Text = "aha";
            // 
            // btn_Back
            // 
            btn_Back.Location = new Point(54, 650);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(110, 29);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "Kijelentkezés";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // dg_meresek
            // 
            dg_meresek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_meresek.Columns.AddRange(new DataGridViewColumn[] { MeroId, MeroDatum, MeroType, MeroHomerseklet, MeroHarmatPont, MeroParatartalom, MeroLegnyomas, MeroCsapadek });
            dg_meresek.Location = new Point(40, 152);
            dg_meresek.Name = "dg_meresek";
            dg_meresek.RowHeadersWidth = 51;
            dg_meresek.Size = new Size(1052, 475);
            dg_meresek.TabIndex = 2;
            // 
            // MeroId
            // 
            MeroId.HeaderText = "MérőId";
            MeroId.MinimumWidth = 6;
            MeroId.Name = "MeroId";
            MeroId.Width = 125;
            // 
            // MeroDatum
            // 
            MeroDatum.HeaderText = "Dátum";
            MeroDatum.MinimumWidth = 6;
            MeroDatum.Name = "MeroDatum";
            MeroDatum.Width = 125;
            // 
            // MeroType
            // 
            MeroType.HeaderText = "Külső/Belső";
            MeroType.MinimumWidth = 6;
            MeroType.Name = "MeroType";
            MeroType.Width = 125;
            // 
            // MeroHomerseklet
            // 
            MeroHomerseklet.HeaderText = "Hőmérséklet";
            MeroHomerseklet.MinimumWidth = 6;
            MeroHomerseklet.Name = "MeroHomerseklet";
            MeroHomerseklet.Width = 125;
            // 
            // MeroHarmatPont
            // 
            MeroHarmatPont.HeaderText = "Harmatpont";
            MeroHarmatPont.MinimumWidth = 6;
            MeroHarmatPont.Name = "MeroHarmatPont";
            MeroHarmatPont.Width = 125;
            // 
            // MeroParatartalom
            // 
            MeroParatartalom.HeaderText = "Páratartalom";
            MeroParatartalom.MinimumWidth = 6;
            MeroParatartalom.Name = "MeroParatartalom";
            MeroParatartalom.Width = 125;
            // 
            // MeroLegnyomas
            // 
            MeroLegnyomas.HeaderText = "Légnyomás";
            MeroLegnyomas.MinimumWidth = 6;
            MeroLegnyomas.Name = "MeroLegnyomas";
            MeroLegnyomas.Width = 125;
            // 
            // MeroCsapadek
            // 
            MeroCsapadek.HeaderText = "Csapadék";
            MeroCsapadek.MinimumWidth = 6;
            MeroCsapadek.Name = "MeroCsapadek";
            MeroCsapadek.Width = 125;
            // 
            // datepicker1
            // 
            datepicker1.Location = new Point(430, 38);
            datepicker1.Name = "datepicker1";
            datepicker1.Size = new Size(271, 27);
            datepicker1.TabIndex = 3;
            datepicker1.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // cb_InOrOut
            // 
            cb_InOrOut.FormattingEnabled = true;
            cb_InOrOut.Location = new Point(258, 91);
            cb_InOrOut.Name = "cb_InOrOut";
            cb_InOrOut.Size = new Size(113, 28);
            cb_InOrOut.TabIndex = 4;
            // 
            // cb_Types
            // 
            cb_Types.FormattingEnabled = true;
            cb_Types.Location = new Point(95, 94);
            cb_Types.Name = "cb_Types";
            cb_Types.Size = new Size(113, 28);
            cb_Types.TabIndex = 5;
            // 
            // btn_NewMeres
            // 
            btn_NewMeres.Location = new Point(267, 650);
            btn_NewMeres.Name = "btn_NewMeres";
            btn_NewMeres.Size = new Size(121, 59);
            btn_NewMeres.TabIndex = 6;
            btn_NewMeres.Text = "Új mérés hozzáadása";
            btn_NewMeres.UseVisualStyleBackColor = true;
            btn_NewMeres.Click += btn_NewMeres_Click;
            // 
            // btn_GotoOwnMeres
            // 
            btn_GotoOwnMeres.Location = new Point(593, 650);
            btn_GotoOwnMeres.Name = "btn_GotoOwnMeres";
            btn_GotoOwnMeres.Size = new Size(121, 59);
            btn_GotoOwnMeres.TabIndex = 7;
            btn_GotoOwnMeres.Text = "Saját mérések szerkesztése";
            btn_GotoOwnMeres.UseVisualStyleBackColor = true;
            btn_GotoOwnMeres.Click += btn_GotoOwnMeres_Click;
            // 
            // btn_USaveXML
            // 
            btn_USaveXML.Location = new Point(783, 650);
            btn_USaveXML.Name = "btn_USaveXML";
            btn_USaveXML.Size = new Size(121, 59);
            btn_USaveXML.TabIndex = 8;
            btn_USaveXML.Text = "Mérés lementése";
            btn_USaveXML.UseVisualStyleBackColor = true;
            btn_USaveXML.Click += btn_USaveXML_Click;
            // 
            // tb_Average
            // 
            tb_Average.Location = new Point(843, 95);
            tb_Average.Name = "tb_Average";
            tb_Average.Size = new Size(125, 27);
            tb_Average.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 59);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 10;
            label1.Text = "Típus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 56);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 11;
            label2.Text = "Külső/Belső";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(843, 59);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 12;
            label3.Text = "Átlaghőmérséklet";
            // 
            // datepicker2
            // 
            datepicker2.Location = new Point(430, 91);
            datepicker2.Name = "datepicker2";
            datepicker2.Size = new Size(271, 27);
            datepicker2.TabIndex = 13;
            // 
            // btn_Filter
            // 
            btn_Filter.Location = new Point(722, 90);
            btn_Filter.Name = "btn_Filter";
            btn_Filter.Size = new Size(94, 29);
            btn_Filter.TabIndex = 14;
            btn_Filter.Text = "Szűrés";
            btn_Filter.UseVisualStyleBackColor = true;
            btn_Filter.Click += btn_Filter_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 9);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 15;
            label4.Text = "Kezdet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 68);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 16;
            label5.Text = "Vége:";
            // 
            // UserSite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 722);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_Filter);
            Controls.Add(datepicker2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_Average);
            Controls.Add(btn_USaveXML);
            Controls.Add(btn_GotoOwnMeres);
            Controls.Add(btn_NewMeres);
            Controls.Add(cb_Types);
            Controls.Add(cb_InOrOut);
            Controls.Add(datepicker1);
            Controls.Add(dg_meresek);
            Controls.Add(btn_Back);
            Controls.Add(lbl_welcome);
            Name = "UserSite";
            Text = "UserSite";
            ((System.ComponentModel.ISupportInitialize)dg_meresek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_welcome;
        private Button btn_Back;
        private DataGridView dg_meresek;
        private DateTimePicker datepicker1;
        private ComboBox cb_InOrOut;
        private ComboBox cb_Types;
        private Button btn_NewMeres;
        private Button btn_GotoOwnMeres;
        private Button btn_USaveXML;
        private TextBox tb_Average;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker datepicker2;
        private Button btn_Filter;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn MeroId;
        private DataGridViewTextBoxColumn MeroDatum;
        private DataGridViewTextBoxColumn MeroType;
        private DataGridViewTextBoxColumn MeroHomerseklet;
        private DataGridViewTextBoxColumn MeroHarmatPont;
        private DataGridViewTextBoxColumn MeroParatartalom;
        private DataGridViewTextBoxColumn MeroLegnyomas;
        private DataGridViewTextBoxColumn MeroCsapadek;
    }
}