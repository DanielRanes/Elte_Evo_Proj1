namespace Bead.Forms
{
    partial class RegistForm
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
            btn_Regist = new Button();
            tb_RegPassW = new TextBox();
            tb_RegUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_RegPassW2 = new TextBox();
            lbl_error = new Label();
            btn_AdminM = new Button();
            cb_PS = new CheckBox();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(31, 398);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(94, 29);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Vissza";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Regist
            // 
            btn_Regist.Location = new Point(213, 398);
            btn_Regist.Name = "btn_Regist";
            btn_Regist.Size = new Size(106, 29);
            btn_Regist.TabIndex = 1;
            btn_Regist.Text = "Regisztráció";
            btn_Regist.UseVisualStyleBackColor = true;
            btn_Regist.Click += btn_Regist_Click;
            // 
            // tb_RegPassW
            // 
            tb_RegPassW.Location = new Point(31, 145);
            tb_RegPassW.Name = "tb_RegPassW";
            tb_RegPassW.Size = new Size(125, 27);
            tb_RegPassW.TabIndex = 2;
            tb_RegPassW.UseSystemPasswordChar = true;
            // 
            // tb_RegUsername
            // 
            tb_RegUsername.Location = new Point(31, 59);
            tb_RegUsername.Name = "tb_RegUsername";
            tb_RegUsername.Size = new Size(125, 27);
            tb_RegUsername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 15);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 4;
            label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 105);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "Jelszó";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 205);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 7;
            label3.Text = "Jelszó MEGERŐSÍTÉSE";
            // 
            // tb_RegPassW2
            // 
            tb_RegPassW2.Location = new Point(31, 245);
            tb_RegPassW2.Name = "tb_RegPassW2";
            tb_RegPassW2.Size = new Size(125, 27);
            tb_RegPassW2.TabIndex = 6;
            tb_RegPassW2.UseSystemPasswordChar = true;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(31, 335);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(69, 20);
            lbl_error.TabIndex = 8;
            lbl_error.Text = "Alaphiba";
            // 
            // btn_AdminM
            // 
            btn_AdminM.Location = new Point(251, 47);
            btn_AdminM.Name = "btn_AdminM";
            btn_AdminM.Size = new Size(94, 54);
            btn_AdminM.TabIndex = 9;
            btn_AdminM.Text = "Admin Maker";
            btn_AdminM.UseVisualStyleBackColor = true;
            btn_AdminM.Visible = false;
            btn_AdminM.Click += btn_AdminM_Click;
            // 
            // cb_PS
            // 
            cb_PS.AutoSize = true;
            cb_PS.Location = new Point(31, 293);
            cb_PS.Name = "cb_PS";
            cb_PS.Size = new Size(123, 24);
            cb_PS.TabIndex = 10;
            cb_PS.Text = "Látható jelszó";
            cb_PS.UseVisualStyleBackColor = true;
            cb_PS.CheckedChanged += cb_PS_CheckedChanged;
            // 
            // RegistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 450);
            Controls.Add(cb_PS);
            Controls.Add(btn_AdminM);
            Controls.Add(lbl_error);
            Controls.Add(label3);
            Controls.Add(tb_RegPassW2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_RegUsername);
            Controls.Add(tb_RegPassW);
            Controls.Add(btn_Regist);
            Controls.Add(btn_Cancel);
            Name = "RegistForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Button btn_Regist;
        private TextBox tb_RegPassW;
        private TextBox tb_RegUsername;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_RegPassW2;
        private Label lbl_error;
        private Button btn_AdminM;
        private CheckBox cb_PS;
    }
}