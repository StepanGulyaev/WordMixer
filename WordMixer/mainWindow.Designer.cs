namespace WordMixer
    {
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.mixButton = new System.Windows.Forms.Button();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.string1LabelBox = new System.Windows.Forms.Label();
            this.string2LabelBox = new System.Windows.Forms.Label();
            this.resultLabelBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputBox1
            // 
            this.inputBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox1.Font = new System.Drawing.Font("Arial Narrow", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox1.Location = new System.Drawing.Point(134, 63);
            this.inputBox1.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(941, 50);
            this.inputBox1.TabIndex = 0;
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.Font = new System.Drawing.Font("Arial Narrow", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(133, 248);
            this.resultBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(941, 50);
            this.resultBox.TabIndex = 2;
            // 
            // mixButton
            // 
            this.mixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mixButton.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mixButton.Location = new System.Drawing.Point(133, 350);
            this.mixButton.Margin = new System.Windows.Forms.Padding(4);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(942, 158);
            this.mixButton.TabIndex = 2;
            this.mixButton.Text = "MIX";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // inputBox2
            // 
            this.inputBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputBox2.Font = new System.Drawing.Font("Arial Narrow", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox2.Location = new System.Drawing.Point(134, 153);
            this.inputBox2.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(941, 50);
            this.inputBox2.TabIndex = 1;
            // 
            // string1LabelBox
            // 
            this.string1LabelBox.AutoSize = true;
            this.string1LabelBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.string1LabelBox.Location = new System.Drawing.Point(123, 26);
            this.string1LabelBox.Name = "string1LabelBox";
            this.string1LabelBox.Size = new System.Drawing.Size(125, 36);
            this.string1LabelBox.TabIndex = 3;
            this.string1LabelBox.Text = "String1:";
            // 
            // string2LabelBox
            // 
            this.string2LabelBox.AutoSize = true;
            this.string2LabelBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.string2LabelBox.Location = new System.Drawing.Point(123, 117);
            this.string2LabelBox.Name = "string2LabelBox";
            this.string2LabelBox.Size = new System.Drawing.Size(125, 36);
            this.string2LabelBox.TabIndex = 4;
            this.string2LabelBox.Text = "String2:";
            // 
            // resultLabelBox
            // 
            this.resultLabelBox.AutoSize = true;
            this.resultLabelBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabelBox.Location = new System.Drawing.Point(123, 211);
            this.resultLabelBox.Name = "resultLabelBox";
            this.resultLabelBox.Size = new System.Drawing.Size(114, 36);
            this.resultLabelBox.TabIndex = 5;
            this.resultLabelBox.Text = "Result:";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 582);
            this.Controls.Add(this.resultLabelBox);
            this.Controls.Add(this.string2LabelBox);
            this.Controls.Add(this.string1LabelBox);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.inputBox1);
            this.Font = new System.Drawing.Font("Constantia", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainWindow";
            this.Text = "WordMixer";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.Label string1LabelBox;
        private System.Windows.Forms.Label string2LabelBox;
        private System.Windows.Forms.Label resultLabelBox;
        public System.Windows.Forms.Button mixButton;

        }
    }

