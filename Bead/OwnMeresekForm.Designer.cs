namespace Bead.Forms
{
    partial class OwnMeresekForm
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
            dg_OwnMeresek = new DataGridView();
            btn_SzerkM = new Button();
            MeresId = new DataGridViewTextBoxColumn();
            MeresType = new DataGridViewTextBoxColumn();
            MeresDate = new DataGridViewTextBoxColumn();
            MeresHomerseklet = new DataGridViewTextBoxColumn();
            MeresHarmatpont = new DataGridViewTextBoxColumn();
            MeresLegnyomas = new DataGridViewTextBoxColumn();
            MeresCsapadek = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dg_OwnMeresek).BeginInit();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(95, 446);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Vissza";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // dg_OwnMeresek
            // 
            dg_OwnMeresek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_OwnMeresek.Columns.AddRange(new DataGridViewColumn[] { MeresId, MeresType, MeresDate, MeresHomerseklet, MeresHarmatpont, MeresLegnyomas, MeresCsapadek });
            dg_OwnMeresek.Location = new Point(21, 42);
            dg_OwnMeresek.Name = "dg_OwnMeresek";
            dg_OwnMeresek.RowHeadersWidth = 51;
            dg_OwnMeresek.Size = new Size(930, 349);
            dg_OwnMeresek.TabIndex = 1;
            // 
            // btn_SzerkM
            // 
            btn_SzerkM.Location = new Point(418, 442);
            btn_SzerkM.Name = "btn_SzerkM";
            btn_SzerkM.Size = new Size(94, 29);
            btn_SzerkM.TabIndex = 2;
            btn_SzerkM.Text = "Szerkeszt";
            btn_SzerkM.UseVisualStyleBackColor = true;
            btn_SzerkM.Click += btn_SzerkM_Click;
            // 
            // MeresId
            // 
            MeresId.HeaderText = "Mérés ID";
            MeresId.MinimumWidth = 6;
            MeresId.Name = "MeresId";
            MeresId.Width = 125;
            // 
            // MeresType
            // 
            MeresType.HeaderText = "Típus";
            MeresType.MinimumWidth = 6;
            MeresType.Name = "MeresType";
            MeresType.Width = 125;
            // 
            // MeresDate
            // 
            MeresDate.HeaderText = "Dátum";
            MeresDate.MinimumWidth = 6;
            MeresDate.Name = "MeresDate";
            MeresDate.Width = 125;
            // 
            // MeresHomerseklet
            // 
            MeresHomerseklet.HeaderText = "Hőmérséklet";
            MeresHomerseklet.MinimumWidth = 6;
            MeresHomerseklet.Name = "MeresHomerseklet";
            MeresHomerseklet.Width = 125;
            // 
            // MeresHarmatpont
            // 
            MeresHarmatpont.HeaderText = "Harmatpont";
            MeresHarmatpont.MinimumWidth = 6;
            MeresHarmatpont.Name = "MeresHarmatpont";
            MeresHarmatpont.Width = 125;
            // 
            // MeresLegnyomas
            // 
            MeresLegnyomas.HeaderText = "Légnyomás";
            MeresLegnyomas.MinimumWidth = 6;
            MeresLegnyomas.Name = "MeresLegnyomas";
            MeresLegnyomas.Width = 125;
            // 
            // MeresCsapadek
            // 
            MeresCsapadek.HeaderText = "Csapadék";
            MeresCsapadek.MinimumWidth = 6;
            MeresCsapadek.Name = "MeresCsapadek";
            MeresCsapadek.Width = 125;
            // 
            // OwnMeresekForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 496);
            Controls.Add(btn_SzerkM);
            Controls.Add(dg_OwnMeresek);
            Controls.Add(btn_Cancel);
            Name = "OwnMeresekForm";
            Text = "Saját Mérések";
            ((System.ComponentModel.ISupportInitialize)dg_OwnMeresek).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Cancel;
        private DataGridView dg_OwnMeresek;
        private Button btn_SzerkM;
        private DataGridViewTextBoxColumn MeresId;
        private DataGridViewTextBoxColumn MeresType;
        private DataGridViewTextBoxColumn MeresDate;
        private DataGridViewTextBoxColumn MeresHomerseklet;
        private DataGridViewTextBoxColumn MeresHarmatpont;
        private DataGridViewTextBoxColumn MeresLegnyomas;
        private DataGridViewTextBoxColumn MeresCsapadek;
    }
}