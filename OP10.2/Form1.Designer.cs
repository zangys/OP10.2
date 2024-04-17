namespace InternationalCallCostCalculator
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.durationLabel = new System.Windows.Forms.Label();
            this.timeOfDayLabel = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.timeOfDayComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(50, 50);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(112, 17);
            this.durationLabel.TabIndex = 0;
            this.durationLabel.Text = "Длительность:";
            // 
            // timeOfDayLabel
            // 
            this.timeOfDayLabel.AutoSize = true;
            this.timeOfDayLabel.Location = new System.Drawing.Point(50, 100);
            this.timeOfDayLabel.Name = "timeOfDayLabel";
            this.timeOfDayLabel.Size = new System.Drawing.Size(100, 17);
            this.timeOfDayLabel.TabIndex = 1;
            this.timeOfDayLabel.Text = "Время суток:";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(170, 50);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(100, 22);
            this.durationTextBox.TabIndex = 2;
            // 
            // timeOfDayComboBox
            // 
            this.timeOfDayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeOfDayComboBox.FormattingEnabled = true;
            this.timeOfDayComboBox.Items.AddRange(new object[] {
            "День",
            "Ночь"});
            this.timeOfDayComboBox.Location = new System.Drawing.Point(170, 100);
            this.timeOfDayComboBox.Name = "timeOfDayComboBox";
            this.timeOfDayComboBox.Size = new System.Drawing.Size(100, 24);
            this.timeOfDayComboBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(170, 150);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 30);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(50, 200);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 250);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.timeOfDayComboBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.timeOfDayLabel);
            this.Controls.Add(this.durationLabel);
            this.Name = "MainForm";
            this.Text = "Стоимость междугороднего разговора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label timeOfDayLabel;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.ComboBox timeOfDayComboBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
    }
}
