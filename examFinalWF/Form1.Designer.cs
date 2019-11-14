namespace examFinalWF
{
    partial class Form1
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
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.carGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.makeCar = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.yearMenu = new System.Windows.Forms.ComboBox();
            this.ownerRb = new System.Windows.Forms.RadioButton();
            this.ownerGrp = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.carGroup.SuspendLayout();
            this.ownerGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCar
            // 
            this.rbCar.AutoSize = true;
            this.rbCar.Location = new System.Drawing.Point(162, 65);
            this.rbCar.Name = "rbCar";
            this.rbCar.Size = new System.Drawing.Size(41, 17);
            this.rbCar.TabIndex = 0;
            this.rbCar.TabStop = true;
            this.rbCar.Text = "Car";
            this.rbCar.UseVisualStyleBackColor = true;
            this.rbCar.CheckedChanged += new System.EventHandler(this.rbCar_CheckedChanged);
            // 
            // carGroup
            // 
            this.carGroup.Controls.Add(this.yearMenu);
            this.carGroup.Controls.Add(this.comboBox2);
            this.carGroup.Controls.Add(this.makeCar);
            this.carGroup.Controls.Add(this.label3);
            this.carGroup.Controls.Add(this.label2);
            this.carGroup.Controls.Add(this.label1);
            this.carGroup.Location = new System.Drawing.Point(121, 136);
            this.carGroup.Name = "carGroup";
            this.carGroup.Size = new System.Drawing.Size(213, 197);
            this.carGroup.TabIndex = 1;
            this.carGroup.TabStop = false;
            this.carGroup.Text = "Car Registration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "year";
            // 
            // makeCar
            // 
            this.makeCar.FormattingEnabled = true;
            this.makeCar.Items.AddRange(new object[] {
            "MAZDA",
            "MERCEDEZ",
            "AUDI"});
            this.makeCar.Location = new System.Drawing.Point(76, 44);
            this.makeCar.Name = "makeCar";
            this.makeCar.Size = new System.Drawing.Size(121, 21);
            this.makeCar.TabIndex = 3;
            this.makeCar.SelectedIndexChanged += new System.EventHandler(this.makeCar_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(76, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // yearMenu
            // 
            this.yearMenu.FormattingEnabled = true;
            this.yearMenu.Items.AddRange(new object[] {
            "2008",
            "2010",
            "2012",
            "2014",
            "2018"});
            this.yearMenu.Location = new System.Drawing.Point(76, 112);
            this.yearMenu.Name = "yearMenu";
            this.yearMenu.Size = new System.Drawing.Size(121, 21);
            this.yearMenu.TabIndex = 5;
            // 
            // ownerRb
            // 
            this.ownerRb.AutoSize = true;
            this.ownerRb.Location = new System.Drawing.Point(527, 65);
            this.ownerRb.Name = "ownerRb";
            this.ownerRb.Size = new System.Drawing.Size(56, 17);
            this.ownerRb.TabIndex = 2;
            this.ownerRb.TabStop = true;
            this.ownerRb.Text = "Owner";
            this.ownerRb.UseVisualStyleBackColor = true;
            this.ownerRb.CheckedChanged += new System.EventHandler(this.ownerRb_CheckedChanged);
            // 
            // ownerGrp
            // 
            this.ownerGrp.Controls.Add(this.txtTelephone);
            this.ownerGrp.Controls.Add(this.lName);
            this.ownerGrp.Controls.Add(this.fName);
            this.ownerGrp.Controls.Add(this.label6);
            this.ownerGrp.Controls.Add(this.label5);
            this.ownerGrp.Controls.Add(this.label4);
            this.ownerGrp.Location = new System.Drawing.Point(473, 137);
            this.ownerGrp.Name = "ownerGrp";
            this.ownerGrp.Size = new System.Drawing.Size(208, 196);
            this.ownerGrp.TabIndex = 3;
            this.ownerGrp.TabStop = false;
            this.ownerGrp.Text = "Owner";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(206, 366);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(537, 366);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "First name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telephone";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(88, 40);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(100, 20);
            this.fName.TabIndex = 3;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(88, 80);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(100, 20);
            this.lName.TabIndex = 4;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(88, 111);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.ownerGrp);
            this.Controls.Add(this.ownerRb);
            this.Controls.Add(this.carGroup);
            this.Controls.Add(this.rbCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.carGroup.ResumeLayout(false);
            this.carGroup.PerformLayout();
            this.ownerGrp.ResumeLayout(false);
            this.ownerGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.GroupBox carGroup;
        private System.Windows.Forms.ComboBox yearMenu;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox makeCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ownerRb;
        private System.Windows.Forms.GroupBox ownerGrp;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

