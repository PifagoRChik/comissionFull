namespace comission.UserControls
{
    partial class addNewUser
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.familyInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.nameInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.fatherNameInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passportInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.addPhoto = new System.Windows.Forms.Button();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.documentBox = new System.Windows.Forms.PictureBox();
            this.addDocument = new System.Windows.Forms.Button();
            this.specializationBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.attestInput = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBox)).BeginInit();
            this.SuspendLayout();
            // 
            // familyInput
            // 
            this.familyInput.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.familyInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.familyInput.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.familyInput.BorderThickness = 3;
            this.familyInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.familyInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.familyInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.familyInput.isPassword = false;
            this.familyInput.Location = new System.Drawing.Point(163, 140);
            this.familyInput.Margin = new System.Windows.Forms.Padding(4);
            this.familyInput.Name = "familyInput";
            this.familyInput.Size = new System.Drawing.Size(268, 44);
            this.familyInput.TabIndex = 0;
            this.familyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.familyInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.familyInput_KeyPress);
            // 
            // nameInput
            // 
            this.nameInput.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameInput.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameInput.BorderThickness = 3;
            this.nameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameInput.isPassword = false;
            this.nameInput.Location = new System.Drawing.Point(163, 201);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(268, 44);
            this.nameInput.TabIndex = 1;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameInput_KeyPress);
            // 
            // fatherNameInput
            // 
            this.fatherNameInput.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fatherNameInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fatherNameInput.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fatherNameInput.BorderThickness = 3;
            this.fatherNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fatherNameInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fatherNameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fatherNameInput.isPassword = false;
            this.fatherNameInput.Location = new System.Drawing.Point(163, 262);
            this.fatherNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.fatherNameInput.Name = "fatherNameInput";
            this.fatherNameInput.Size = new System.Drawing.Size(268, 44);
            this.fatherNameInput.TabIndex = 2;
            this.fatherNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fatherNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fatherNameInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Паспорт";
            // 
            // passportInput
            // 
            this.passportInput.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passportInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passportInput.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passportInput.BorderThickness = 3;
            this.passportInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passportInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passportInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passportInput.isPassword = false;
            this.passportInput.Location = new System.Drawing.Point(163, 323);
            this.passportInput.Margin = new System.Windows.Forms.Padding(4);
            this.passportInput.Name = "passportInput";
            this.passportInput.Size = new System.Drawing.Size(206, 44);
            this.passportInput.TabIndex = 4;
            this.passportInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passportInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passportInput_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(347, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Добавление абитуриента";
            // 
            // addPhoto
            // 
            this.addPhoto.BackColor = System.Drawing.Color.Coral;
            this.addPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPhoto.FlatAppearance.BorderSize = 0;
            this.addPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPhoto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPhoto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addPhoto.Location = new System.Drawing.Point(521, 329);
            this.addPhoto.Name = "addPhoto";
            this.addPhoto.Size = new System.Drawing.Size(116, 23);
            this.addPhoto.TabIndex = 5;
            this.addPhoto.TabStop = false;
            this.addPhoto.Text = "Добавить фото";
            this.addPhoto.UseVisualStyleBackColor = false;
            this.addPhoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // photoBox
            // 
            this.photoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoBox.Location = new System.Drawing.Point(505, 140);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(149, 159);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoBox.TabIndex = 6;
            this.photoBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(870, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Добавить абитуриента";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // documentBox
            // 
            this.documentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.documentBox.Location = new System.Drawing.Point(769, 140);
            this.documentBox.Name = "documentBox";
            this.documentBox.Size = new System.Drawing.Size(149, 159);
            this.documentBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.documentBox.TabIndex = 7;
            this.documentBox.TabStop = false;
            // 
            // addDocument
            // 
            this.addDocument.BackColor = System.Drawing.Color.Coral;
            this.addDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDocument.FlatAppearance.BorderSize = 0;
            this.addDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDocument.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDocument.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addDocument.Location = new System.Drawing.Point(785, 329);
            this.addDocument.Name = "addDocument";
            this.addDocument.Size = new System.Drawing.Size(116, 23);
            this.addDocument.TabIndex = 5;
            this.addDocument.TabStop = false;
            this.addDocument.Text = "Добавить аттестат";
            this.addDocument.UseVisualStyleBackColor = false;
            this.addDocument.Click += new System.EventHandler(this.addDocument_Click);
            // 
            // specializationBox
            // 
            this.specializationBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specializationBox.FormattingEnabled = true;
            this.specializationBox.Items.AddRange(new object[] {
            "09.02.02 КС",
            "09.02.03 ПКС",
            "11.02.08 СП",
            "11.02.09 МТС",
            "11.02.11 С"});
            this.specializationBox.Location = new System.Drawing.Point(163, 458);
            this.specializationBox.Name = "specializationBox";
            this.specializationBox.Size = new System.Drawing.Size(206, 25);
            this.specializationBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(31, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Специальность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Аттестат";
            // 
            // attestInput
            // 
            this.attestInput.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.attestInput.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.attestInput.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.attestInput.BorderThickness = 3;
            this.attestInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.attestInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.attestInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.attestInput.isPassword = false;
            this.attestInput.Location = new System.Drawing.Point(163, 383);
            this.attestInput.Margin = new System.Windows.Forms.Padding(4);
            this.attestInput.Name = "attestInput";
            this.attestInput.Size = new System.Drawing.Size(206, 44);
            this.attestInput.TabIndex = 4;
            this.attestInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.attestInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passportInput_KeyPress);
            // 
            // addNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.specializationBox);
            this.Controls.Add(this.documentBox);
            this.Controls.Add(this.photoBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addDocument);
            this.Controls.Add(this.addPhoto);
            this.Controls.Add(this.attestInput);
            this.Controls.Add(this.passportInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fatherNameInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.familyInput);
            this.Name = "addNewUser";
            this.Size = new System.Drawing.Size(998, 532);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox familyInput;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameInput;
        private Bunifu.Framework.UI.BunifuMetroTextbox fatherNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox passportInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addPhoto;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox documentBox;
        private System.Windows.Forms.Button addDocument;
        private System.Windows.Forms.ComboBox specializationBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox attestInput;
    }
}
