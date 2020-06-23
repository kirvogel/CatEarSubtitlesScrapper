namespace MissEvanSubtitlesScrapper
{
    partial class Form
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
            this.selectID = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.resultingText = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // selectID
            // 
            this.selectID.AutoSize = true;
            this.selectID.Location = new System.Drawing.Point(16, 4);
            this.selectID.Name = "selectID";
            this.selectID.Size = new System.Drawing.Size(67, 17);
            this.selectID.TabIndex = 0;
            this.selectID.Text = "ID трека:";
            this.selectID.Click += new System.EventHandler(this.selectID_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(15, 27);
            this.numericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown.TabIndex = 1;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // resultingText
            // 
            this.resultingText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultingText.Location = new System.Drawing.Point(15, 94);
            this.resultingText.Multiline = true;
            this.resultingText.Name = "resultingText";
            this.resultingText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultingText.Size = new System.Drawing.Size(750, 310);
            this.resultingText.TabIndex = 2;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(15, 55);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(120, 33);
            this.start.TabIndex = 3;
            this.start.Text = "Обработать";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.resultingText);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.selectID);
            this.Name = "Form";
            this.Text = "Субтитры с MaoerFM";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectID;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.TextBox resultingText;
        private System.Windows.Forms.Button start;
    }
}

