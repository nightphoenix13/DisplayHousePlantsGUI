namespace DisplayHousePlantsGUI
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.daysLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.GroupBox();
            this.optionBox = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.feedButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.housePlantBox = new System.Windows.Forms.GroupBox();
            this.housePlantTextBox = new System.Windows.Forms.TextBox();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.addBox.SuspendLayout();
            this.optionBox.SuspendLayout();
            this.housePlantBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(22, 18);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(119, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Add a new house plant:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(63, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(108, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(21, 60);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(63, 57);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(108, 20);
            this.priceTextBox.TabIndex = 4;
            this.priceTextBox.Text = "0.00";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(22, 83);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(80, 13);
            this.daysLabel.TabIndex = 5;
            this.daysLabel.Text = "Days since fed:";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(108, 80);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(63, 20);
            this.daysTextBox.TabIndex = 6;
            this.daysTextBox.Text = "0";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(91, 106);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add Plant -->";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addBox
            // 
            this.addBox.Controls.Add(this.priceTextBox);
            this.addBox.Controls.Add(this.addButton);
            this.addBox.Controls.Add(this.infoLabel);
            this.addBox.Controls.Add(this.daysTextBox);
            this.addBox.Controls.Add(this.nameTextBox);
            this.addBox.Controls.Add(this.daysLabel);
            this.addBox.Controls.Add(this.nameLabel);
            this.addBox.Controls.Add(this.priceLabel);
            this.addBox.Location = new System.Drawing.Point(12, 12);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(200, 136);
            this.addBox.TabIndex = 8;
            this.addBox.TabStop = false;
            this.addBox.Text = "New House Plant";
            // 
            // optionBox
            // 
            this.optionBox.Controls.Add(this.removeButton);
            this.optionBox.Controls.Add(this.feedButton);
            this.optionBox.Controls.Add(this.comboBox);
            this.optionBox.Location = new System.Drawing.Point(13, 155);
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(200, 100);
            this.optionBox.TabIndex = 9;
            this.optionBox.TabStop = false;
            this.optionBox.Text = "Options";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(107, 60);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(16, 60);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(75, 23);
            this.feedButton.TabIndex = 1;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Plant 1",
            "Plant 2",
            "Plant 3"});
            this.comboBox.Location = new System.Drawing.Point(23, 20);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(147, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.Text = "Select a plant:";
            // 
            // housePlantBox
            // 
            this.housePlantBox.Controls.Add(this.housePlantTextBox);
            this.housePlantBox.Location = new System.Drawing.Point(219, 13);
            this.housePlantBox.Name = "housePlantBox";
            this.housePlantBox.Size = new System.Drawing.Size(200, 242);
            this.housePlantBox.TabIndex = 10;
            this.housePlantBox.TabStop = false;
            this.housePlantBox.Text = "House Plants";
            // 
            // housePlantTextBox
            // 
            this.housePlantTextBox.Location = new System.Drawing.Point(7, 17);
            this.housePlantTextBox.Multiline = true;
            this.housePlantTextBox.Name = "housePlantTextBox";
            this.housePlantTextBox.Size = new System.Drawing.Size(187, 219);
            this.housePlantTextBox.TabIndex = 0;
            this.housePlantTextBox.Text = "No Current House Plants";
            // 
            // nextDayButton
            // 
            this.nextDayButton.Location = new System.Drawing.Point(179, 261);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(75, 23);
            this.nextDayButton.TabIndex = 11;
            this.nextDayButton.Text = "Next Day";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 293);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.housePlantBox);
            this.Controls.Add(this.optionBox);
            this.Controls.Add(this.addBox);
            this.Name = "Form1";
            this.Text = "Display House Plants";
            this.addBox.ResumeLayout(false);
            this.addBox.PerformLayout();
            this.optionBox.ResumeLayout(false);
            this.housePlantBox.ResumeLayout(false);
            this.housePlantBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.GroupBox optionBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox housePlantBox;
        private System.Windows.Forms.TextBox housePlantTextBox;
        private System.Windows.Forms.Button nextDayButton;
    }
}

