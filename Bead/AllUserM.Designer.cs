namespace Bead.Forms
{
    partial class AllUserM
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
            dg_AllUser = new DataGridView();
            UserID = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            UserRank = new DataGridViewTextBoxColumn();
            btn_Cancel = new Button();
            btn_UserM = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_AllUser).BeginInit();
            SuspendLayout();
            // 
            // dg_AllUser
            // 
            dg_AllUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_AllUser.Columns.AddRange(new DataGridViewColumn[] { UserID, Username, UserRank });
            dg_AllUser.Location = new Point(27, 23);
            dg_AllUser.Name = "dg_AllUser";
            dg_AllUser.RowHeadersWidth = 51;
            dg_AllUser.Size = new Size(428, 393);
            dg_AllUser.TabIndex = 0;
            // 
            // UserID
            // 
            UserID.HeaderText = "ID";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.Width = 125;
            // 
            // Username
            // 
            Username.HeaderText = "User neve";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.Width = 125;
            // 
            // UserRank
            // 
            UserRank.HeaderText = "Rank";
            UserRank.MinimumWidth = 6;
            UserRank.Name = "UserRank";
            UserRank.Width = 125;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(596, 374);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Vissza";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_UserM
            // 
            btn_UserM.Location = new Point(591, 113);
            btn_UserM.Name = "btn_UserM";
            btn_UserM.Size = new Size(94, 29);
            btn_UserM.TabIndex = 2;
            btn_UserM.Text = "Szerkeszt";
            btn_UserM.UseVisualStyleBackColor = true;
            btn_UserM.Click += btn_UserM_Click_1;
            // 
            // AllUserM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_UserM);
            Controls.Add(btn_Cancel);
            Controls.Add(dg_AllUser);
            Name = "AllUserM";
            Text = "AllUserM";
            ((System.ComponentModel.ISupportInitialize)dg_AllUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_AllUser;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn UserRank;
        private Button btn_Cancel;
        private Button btn_UserM;
    }
}