namespace comission
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Button();
            this.attbutton = new System.Windows.Forms.Button();
            this.dataButton = new System.Windows.Forms.Button();
            this.allStudents = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.attestatInfo1 = new comission.UserControls.attestatInfo();
            this.studentInfo1 = new comission.UserControls.studentInfo();
            this.helpForm1 = new comission.UserControls.helpForm();
            this.allStudents1 = new comission.UserControls.allStudents();
            this.addNewUser1 = new comission.UserControls.addNewUser();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(184)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.menuButton);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 34);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.exitButton, BunifuAnimatorNS.DecorationType.None);
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(953, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 29);
            this.exitButton.TabIndex = 4;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(909, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(33, 29);
            this.minimizeButton.TabIndex = 4;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuButton.BackgroundImage")));
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Location = new System.Drawing.Point(3, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(33, 29);
            this.menuButton.TabIndex = 4;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuPanel);
            this.panel2.Controls.Add(this.attestatInfo1);
            this.panel2.Controls.Add(this.studentInfo1);
            this.panel2.Controls.Add(this.helpForm1);
            this.panel2.Controls.Add(this.allStudents1);
            this.panel2.Controls.Add(this.addNewUser1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 532);
            this.panel2.TabIndex = 2;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(184)))), ((int)(((byte)(78)))));
            this.menuPanel.Controls.Add(this.sidePanel);
            this.menuPanel.Controls.Add(this.helpButton);
            this.menuPanel.Controls.Add(this.attbutton);
            this.menuPanel.Controls.Add(this.dataButton);
            this.menuPanel.Controls.Add(this.allStudents);
            this.menuPanel.Controls.Add(this.addButton);
            this.bunifuTransition1.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 532);
            this.menuPanel.TabIndex = 2;
            this.menuPanel.Visible = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuTransition1.SetDecoration(this.sidePanel, BunifuAnimatorNS.DecorationType.None);
            this.sidePanel.Location = new System.Drawing.Point(0, 47);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 44);
            this.sidePanel.TabIndex = 1;
            // 
            // helpButton
            // 
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.helpButton, BunifuAnimatorNS.DecorationType.None);
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpButton.Location = new System.Drawing.Point(10, 476);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(188, 44);
            this.helpButton.TabIndex = 0;
            this.helpButton.Text = "Помощь";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // attbutton
            // 
            this.attbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.attbutton, BunifuAnimatorNS.DecorationType.None);
            this.attbutton.FlatAppearance.BorderSize = 0;
            this.attbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attbutton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attbutton.ForeColor = System.Drawing.Color.White;
            this.attbutton.Image = ((System.Drawing.Image)(resources.GetObject("attbutton.Image")));
            this.attbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attbutton.Location = new System.Drawing.Point(9, 147);
            this.attbutton.Name = "attbutton";
            this.attbutton.Size = new System.Drawing.Size(188, 44);
            this.attbutton.TabIndex = 0;
            this.attbutton.Text = "   Аттестат";
            this.attbutton.UseVisualStyleBackColor = true;
            this.attbutton.Click += new System.EventHandler(this.attbutton_Click);
            // 
            // dataButton
            // 
            this.dataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.dataButton, BunifuAnimatorNS.DecorationType.None);
            this.dataButton.FlatAppearance.BorderSize = 0;
            this.dataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataButton.ForeColor = System.Drawing.Color.White;
            this.dataButton.Image = ((System.Drawing.Image)(resources.GetObject("dataButton.Image")));
            this.dataButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataButton.Location = new System.Drawing.Point(9, 97);
            this.dataButton.Name = "dataButton";
            this.dataButton.Size = new System.Drawing.Size(188, 44);
            this.dataButton.TabIndex = 0;
            this.dataButton.Text = "Данные";
            this.dataButton.UseVisualStyleBackColor = true;
            this.dataButton.Click += new System.EventHandler(this.dataButton_Click);
            // 
            // allStudents
            // 
            this.allStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.allStudents, BunifuAnimatorNS.DecorationType.None);
            this.allStudents.FlatAppearance.BorderSize = 0;
            this.allStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allStudents.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allStudents.ForeColor = System.Drawing.Color.White;
            this.allStudents.Image = ((System.Drawing.Image)(resources.GetObject("allStudents.Image")));
            this.allStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allStudents.Location = new System.Drawing.Point(10, 197);
            this.allStudents.Name = "allStudents";
            this.allStudents.Size = new System.Drawing.Size(188, 44);
            this.allStudents.TabIndex = 0;
            this.allStudents.Text = "           Абитуриенты";
            this.allStudents.UseVisualStyleBackColor = true;
            this.allStudents.Click += new System.EventHandler(this.allStudents_Click);
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.addButton, BunifuAnimatorNS.DecorationType.None);
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(10, 47);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(188, 44);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "       Добавление";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // attestatInfo1
            // 
            this.attestatInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTransition1.SetDecoration(this.attestatInfo1, BunifuAnimatorNS.DecorationType.None);
            this.attestatInfo1.Location = new System.Drawing.Point(0, 0);
            this.attestatInfo1.Name = "attestatInfo1";
            this.attestatInfo1.Size = new System.Drawing.Size(998, 532);
            this.attestatInfo1.TabIndex = 7;
            this.attestatInfo1.Visible = false;
            // 
            // studentInfo1
            // 
            this.studentInfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTransition1.SetDecoration(this.studentInfo1, BunifuAnimatorNS.DecorationType.None);
            this.studentInfo1.Location = new System.Drawing.Point(0, 0);
            this.studentInfo1.Name = "studentInfo1";
            this.studentInfo1.Size = new System.Drawing.Size(998, 532);
            this.studentInfo1.TabIndex = 6;
            this.studentInfo1.Visible = false;
            // 
            // helpForm1
            // 
            this.helpForm1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTransition1.SetDecoration(this.helpForm1, BunifuAnimatorNS.DecorationType.None);
            this.helpForm1.Location = new System.Drawing.Point(0, 0);
            this.helpForm1.Name = "helpForm1";
            this.helpForm1.Size = new System.Drawing.Size(998, 532);
            this.helpForm1.TabIndex = 5;
            this.helpForm1.Visible = false;
            // 
            // allStudents1
            // 
            this.allStudents1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTransition1.SetDecoration(this.allStudents1, BunifuAnimatorNS.DecorationType.None);
            this.allStudents1.Location = new System.Drawing.Point(0, 0);
            this.allStudents1.Name = "allStudents1";
            this.allStudents1.Size = new System.Drawing.Size(998, 532);
            this.allStudents1.TabIndex = 4;
            this.allStudents1.Visible = false;
            // 
            // addNewUser1
            // 
            this.addNewUser1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuTransition1.SetDecoration(this.addNewUser1, BunifuAnimatorNS.DecorationType.None);
            this.addNewUser1.Location = new System.Drawing.Point(0, 0);
            this.addNewUser1.Name = "addNewUser1";
            this.addNewUser1.Size = new System.Drawing.Size(998, 532);
            this.addNewUser1.TabIndex = 3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menuButton;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel menuPanel;
        private UserControls.addNewUser addNewUser1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button addButton;
        private UserControls.allStudents allStudents1;
        private System.Windows.Forms.Button allStudents;
        private UserControls.helpForm helpForm1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button dataButton;
        private UserControls.studentInfo studentInfo1;
        private UserControls.attestatInfo attestatInfo1;
        private System.Windows.Forms.Button attbutton;
    }
}