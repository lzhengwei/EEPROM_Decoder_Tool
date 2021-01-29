namespace EEPROM_Decoder_Tool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_open = new System.Windows.Forms.Button();
            this.textBox_open = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_save = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_open.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.button_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_open.Location = new System.Drawing.Point(505, 61);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(141, 66);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = false;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // textBox_open
            // 
            this.textBox_open.Location = new System.Drawing.Point(53, 85);
            this.textBox_open.Name = "textBox_open";
            this.textBox_open.ReadOnly = true;
            this.textBox_open.Size = new System.Drawing.Size(424, 22);
            this.textBox_open.TabIndex = 1;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.SandyBrown;
            this.button_save.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Beige;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(505, 199);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(141, 66);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_save
            // 
            this.textBox_save.Location = new System.Drawing.Point(53, 223);
            this.textBox_save.Name = "textBox_save";
            this.textBox_save.ReadOnly = true;
            this.textBox_save.Size = new System.Drawing.Size(424, 22);
            this.textBox_save.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 124);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(37, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(623, 124);
            this.label2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 298);
            this.Controls.Add(this.textBox_save);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_open);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "EEPROM Decode Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.TextBox textBox_open;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

