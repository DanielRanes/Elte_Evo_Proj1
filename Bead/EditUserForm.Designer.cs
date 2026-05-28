namespace Bead.Forms
{
    partial class EditUserForm
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
            tb_UserName = new TextBox();
            label1 = new Label();
            cb_UserRank = new ComboBox();
            btn_Cancel = new Button();
            btn_Delete = new Button();
            btn_ModifyUser = new Button();
            label2 = new Label();
            lbl_UserId = new Label();
            lbl_error = new Label();
            SuspendLayout();
            // 
            // tb_UserName
            // 
            tb_UserName.Location = new Point(36, 59);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(269, 27);
            tb_UserName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Név";
            // 
            // cb_UserRank
            // 
            cb_UserRank.FormattingEnabled = true;
            cb_UserRank.Location = new Point(474, 58);
            cb_UserRank.Name = "cb_UserRank";
            cb_UserRank.Size = new Size(151, 28);
            cb_UserRank.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(36, 161);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 3;
            btn_Cancel.Text = "Vissza";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(241, 161);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 4;
            btn_Delete.Text = "Törlés";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_ModifyUser
            // 
            btn_ModifyUser.Location = new Point(483, 161);
            btn_ModifyUser.Name = "btn_ModifyUser";
            btn_ModifyUser.Size = new Size(94, 29);
            btn_ModifyUser.TabIndex = 5;
            btn_ModifyUser.Text = "Szerkesztés";
            btn_ModifyUser.UseVisualStyleBackColor = true;
            btn_ModifyUser.Click += btn_ModifyUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 33);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 6;
            label2.Text = "Rank";
            // 
            // lbl_UserId
            // 
            lbl_UserId.AutoSize = true;
            lbl_UserId.Location = new Point(325, 62);
            lbl_UserId.Name = "lbl_UserId";
            lbl_UserId.Size = new Size(33, 20);
            lbl_UserId.TabIndex = 7;
            lbl_UserId.Text = "aha";
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(48, 112);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 20);
            lbl_error.TabIndex = 8;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 240);
            Controls.Add(lbl_error);
            Controls.Add(lbl_UserId);
            Controls.Add(label2);
            Controls.Add(btn_ModifyUser);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Cancel);
            Controls.Add(cb_UserRank);
            Controls.Add(label1);
            Controls.Add(tb_UserName);
            Name = "EditUserForm";
            Text = "EditUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_UserName;
        private Label label1;
        private ComboBox cb_UserRank;
        private Button btn_Cancel;
        private Button btn_Delete;
        private Button btn_ModifyUser;
        private Label label2;
        private Label lbl_UserId;
        private Label lbl_error;
    }
}