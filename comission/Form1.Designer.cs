namespace comission
{
    partial class firstForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.studentLogin_input = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.studentPassword_input = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.enterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(184)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 34);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(786, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(835, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // studentLogin_input
            // 
            this.studentLogin_input.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentLogin_input.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentLogin_input.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentLogin_input.BorderThickness = 3;
            this.studentLogin_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentLogin_input.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.studentLogin_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentLogin_input.isPassword = false;
            this.studentLogin_input.Location = new System.Drawing.Point(245, 160);
            this.studentLogin_input.Margin = new System.Windows.Forms.Padding(4);
            this.studentLogin_input.Name = "studentLogin_input";
            this.studentLogin_input.Size = new System.Drawing.Size(370, 44);
            this.studentLogin_input.TabIndex = 1;
            this.studentLogin_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.studentLogin_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentLogin_input_KeyPress);
            // 
            // studentPassword_input
            // 
            this.studentPassword_input.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentPassword_input.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentPassword_input.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentPassword_input.BorderThickness = 3;
            this.studentPassword_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.studentPassword_input.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.studentPassword_input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.studentPassword_input.isPassword = true;
            this.studentPassword_input.Location = new System.Drawing.Point(245, 228);
            this.studentPassword_input.Margin = new System.Windows.Forms.Padding(4);
            this.studentPassword_input.Name = "studentPassword_input";
            this.studentPassword_input.Size = new System.Drawing.Size(370, 44);
            this.studentPassword_input.TabIndex = 2;
            this.studentPassword_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.studentPassword_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.studentPassword_input_KeyPress);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(184)))), ((int)(((byte)(78)))));
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(381, 293);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(98, 28);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(281, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Для входа в систему введите логин и пароль";
            // 
            // firstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(877, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.studentPassword_input);
            this.Controls.Add(this.studentLogin_input);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "firstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "firstForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox studentLogin_input;
        private Bunifu.Framework.UI.BunifuMetroTextbox studentPassword_input;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label1;
    }
}

