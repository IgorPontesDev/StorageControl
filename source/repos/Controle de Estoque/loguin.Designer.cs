namespace Controle_de_Estoque
{
    partial class loguin
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
            this.pnLoguin = new System.Windows.Forms.Panel();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLoguin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCad = new System.Windows.Forms.Panel();
            this.txtCadConfirmPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCadEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCadPass = new System.Windows.Forms.TextBox();
            this.txtCadUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoguin = new System.Windows.Forms.Button();
            this.btnCadVoltar = new System.Windows.Forms.Button();
            this.btnCadCadastrar = new System.Windows.Forms.Button();
            this.pnLoguin.SuspendLayout();
            this.pnCad.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLoguin
            // 
            this.pnLoguin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.pnLoguin.Controls.Add(this.btnCad);
            this.pnLoguin.Controls.Add(this.btnLoguin);
            this.pnLoguin.Controls.Add(this.txtPass);
            this.pnLoguin.Controls.Add(this.txtLoguin);
            this.pnLoguin.Controls.Add(this.label3);
            this.pnLoguin.Controls.Add(this.label2);
            this.pnLoguin.Controls.Add(this.label1);
            this.pnLoguin.Location = new System.Drawing.Point(200, 35);
            this.pnLoguin.Name = "pnLoguin";
            this.pnLoguin.Size = new System.Drawing.Size(403, 370);
            this.pnLoguin.TabIndex = 0;
            // 
            // btnCad
            // 
            this.btnCad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCad.AutoSize = true;
            this.btnCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.btnCad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCad.FlatAppearance.BorderSize = 0;
            this.btnCad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCad.Location = new System.Drawing.Point(293, 305);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(107, 62);
            this.btnCad.TabIndex = 13;
            this.btnCad.Text = "Criar conta";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click_1);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(122, 172);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(263, 20);
            this.txtPass.TabIndex = 6;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtLoguin
            // 
            this.txtLoguin.Location = new System.Drawing.Point(122, 101);
            this.txtLoguin.Name = "txtLoguin";
            this.txtLoguin.Size = new System.Drawing.Size(263, 20);
            this.txtLoguin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGUIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnCad
            // 
            this.pnCad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.pnCad.Controls.Add(this.btnCadVoltar);
            this.pnCad.Controls.Add(this.btnCadCadastrar);
            this.pnCad.Controls.Add(this.txtCadConfirmPass);
            this.pnCad.Controls.Add(this.label8);
            this.pnCad.Controls.Add(this.txtCadEmail);
            this.pnCad.Controls.Add(this.label7);
            this.pnCad.Controls.Add(this.txtCadPass);
            this.pnCad.Controls.Add(this.txtCadUser);
            this.pnCad.Controls.Add(this.label4);
            this.pnCad.Controls.Add(this.label5);
            this.pnCad.Controls.Add(this.label6);
            this.pnCad.Location = new System.Drawing.Point(30, 68);
            this.pnCad.Name = "pnCad";
            this.pnCad.Size = new System.Drawing.Size(394, 361);
            this.pnCad.TabIndex = 9;
            this.pnCad.Visible = false;
            // 
            // txtCadConfirmPass
            // 
            this.txtCadConfirmPass.Location = new System.Drawing.Point(122, 209);
            this.txtCadConfirmPass.Name = "txtCadConfirmPass";
            this.txtCadConfirmPass.Size = new System.Drawing.Size(263, 20);
            this.txtCadConfirmPass.TabIndex = 10;
            this.txtCadConfirmPass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Confirmar:";
            // 
            // txtCadEmail
            // 
            this.txtCadEmail.Location = new System.Drawing.Point(122, 137);
            this.txtCadEmail.Name = "txtCadEmail";
            this.txtCadEmail.Size = new System.Drawing.Size(263, 20);
            this.txtCadEmail.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "E-mail:";
            // 
            // txtCadPass
            // 
            this.txtCadPass.Location = new System.Drawing.Point(122, 173);
            this.txtCadPass.Name = "txtCadPass";
            this.txtCadPass.Size = new System.Drawing.Size(263, 20);
            this.txtCadPass.TabIndex = 6;
            this.txtCadPass.UseSystemPasswordChar = true;
            // 
            // txtCadUser
            // 
            this.txtCadUser.Location = new System.Drawing.Point(122, 101);
            this.txtCadUser.Name = "txtCadUser";
            this.txtCadUser.Size = new System.Drawing.Size(263, 20);
            this.txtCadUser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "CADASTRO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLoguin
            // 
            this.btnLoguin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoguin.AutoSize = true;
            this.btnLoguin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.btnLoguin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoguin.FlatAppearance.BorderSize = 0;
            this.btnLoguin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLoguin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnLoguin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoguin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoguin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoguin.Image = global::Controle_de_Estoque.Properties.Resources.icons8_login_50;
            this.btnLoguin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoguin.Location = new System.Drawing.Point(122, 230);
            this.btnLoguin.Name = "btnLoguin";
            this.btnLoguin.Size = new System.Drawing.Size(107, 62);
            this.btnLoguin.TabIndex = 12;
            this.btnLoguin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoguin.UseVisualStyleBackColor = false;
            this.btnLoguin.Click += new System.EventHandler(this.btnLoguin_Click_1);
            // 
            // btnCadVoltar
            // 
            this.btnCadVoltar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadVoltar.AutoSize = true;
            this.btnCadVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.btnCadVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadVoltar.FlatAppearance.BorderSize = 0;
            this.btnCadVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCadVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadVoltar.Image = global::Controle_de_Estoque.Properties.Resources.icons8_voltar_50;
            this.btnCadVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadVoltar.Location = new System.Drawing.Point(255, 265);
            this.btnCadVoltar.Name = "btnCadVoltar";
            this.btnCadVoltar.Size = new System.Drawing.Size(107, 62);
            this.btnCadVoltar.TabIndex = 12;
            this.btnCadVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadVoltar.UseVisualStyleBackColor = false;
            this.btnCadVoltar.Click += new System.EventHandler(this.btnCadVoltar_Click);
            // 
            // btnCadCadastrar
            // 
            this.btnCadCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadCadastrar.AutoSize = true;
            this.btnCadCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.btnCadCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCadCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadCadastrar.Image = global::Controle_de_Estoque.Properties.Resources.icons8_login_50;
            this.btnCadCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadCadastrar.Location = new System.Drawing.Point(114, 265);
            this.btnCadCadastrar.Name = "btnCadCadastrar";
            this.btnCadCadastrar.Size = new System.Drawing.Size(107, 62);
            this.btnCadCadastrar.TabIndex = 11;
            this.btnCadCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadCadastrar.UseVisualStyleBackColor = false;
            this.btnCadCadastrar.Click += new System.EventHandler(this.btnCadCadastrar_Click_1);
            // 
            // loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.pnLoguin);
            this.Controls.Add(this.pnCad);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "loguin";
            this.Text = "loguin";
            this.pnLoguin.ResumeLayout(false);
            this.pnLoguin.PerformLayout();
            this.pnCad.ResumeLayout(false);
            this.pnCad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLoguin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLoguin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnCad;
        private System.Windows.Forms.TextBox txtCadConfirmPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCadEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCadPass;
        private System.Windows.Forms.TextBox txtCadUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadCadastrar;
        private System.Windows.Forms.Button btnLoguin;
        private System.Windows.Forms.Button btnCadVoltar;
        private System.Windows.Forms.Button btnCad;
    }
}