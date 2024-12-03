namespace InformationSecurityLab7
{
    partial class GronsfeldCipherForm
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
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.buttonCypher = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Location = new System.Drawing.Point(12, 12);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(299, 95);
            this.textBoxDecrypted.TabIndex = 0;
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Location = new System.Drawing.Point(317, 12);
            this.textBoxEncrypted.Multiline = true;
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(299, 95);
            this.textBoxEncrypted.TabIndex = 1;
            // 
            // buttonCypher
            // 
            this.buttonCypher.Location = new System.Drawing.Point(258, 113);
            this.buttonCypher.Name = "buttonCypher";
            this.buttonCypher.Size = new System.Drawing.Size(109, 46);
            this.buttonCypher.TabIndex = 2;
            this.buttonCypher.Text = "Шифровать";
            this.buttonCypher.UseVisualStyleBackColor = true;
            this.buttonCypher.Click += new System.EventHandler(this.buttonCypher_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(12, 127);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(119, 20);
            this.textBoxKey.TabIndex = 3;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(137, 130);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(33, 13);
            this.labelKey.TabIndex = 4;
            this.labelKey.Text = "Ключ";
            // 
            // GronsfeldCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 168);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonCypher);
            this.Controls.Add(this.textBoxEncrypted);
            this.Controls.Add(this.textBoxDecrypted);
            this.Name = "GronsfeldCipherForm";
            this.Text = "Шифр Гронсфельда";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Button buttonCypher;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
    }
}

