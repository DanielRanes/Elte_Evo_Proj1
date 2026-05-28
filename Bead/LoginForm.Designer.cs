namespace Bead.Forms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_GoToRegist = new Button();
            btn_Login = new Button();
            tb_UserName = new TextBox();
            tb_PassW = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl_error = new Label();
            cb_PS = new CheckBox();
            SuspendLayout();
            // 
            // btn_GoToRegist
            // 
            btn_GoToRegist.Location = new Point(32, 373);
            btn_GoToRegist.Name = "btn_GoToRegist";
            btn_GoToRegist.Size = new Size(114, 29);
            btn_GoToRegist.TabIndex = 0;
            btn_GoToRegist.Text = "Regisztráció";
            btn_GoToRegist.UseVisualStyleBackColor = true;
            btn_GoToRegist.Click += btn_GoToRegist_Click;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(263, 373);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(107, 29);
            btn_Login.TabIndex = 1;
            btn_Login.Text = "Bejelntkezés";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // tb_UserName
            // 
            tb_UserName.Location = new Point(74, 68);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(125, 27);
            tb_UserName.TabIndex = 2;
            // 
            // tb_PassW
            // 
            tb_PassW.Location = new Point(74, 154);
            tb_PassW.Name = "tb_PassW";
            tb_PassW.Size = new Size(125, 27);
            tb_PassW.TabIndex = 3;
            tb_PassW.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 29);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 4;
            label1.Text = "Fehasználónév";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 120);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "Jelszó";
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(32, 287);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(67, 20);
            lbl_error.TabIndex = 6;
            lbl_error.Text = "alaphiba";
            // 
            // cb_PS
            // 
            cb_PS.AutoSize = true;
            cb_PS.Location = new Point(74, 225);
            cb_PS.Name = "cb_PS";
            cb_PS.Size = new Size(123, 24);
            cb_PS.TabIndex = 7;
            cb_PS.Text = "Látható jelszó";
            cb_PS.UseVisualStyleBackColor = true;
            cb_PS.CheckedChanged += cb_PS_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(cb_PS);
            Controls.Add(lbl_error);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_PassW);
            Controls.Add(tb_UserName);
            Controls.Add(btn_Login);
            Controls.Add(btn_GoToRegist);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_GoToRegist;
        private Button btn_Login;
        private TextBox tb_UserName;
        private TextBox tb_PassW;
        private Label label1;
        private Label label2;
        private Label lbl_error;
        private CheckBox cb_PS;
    }
}
