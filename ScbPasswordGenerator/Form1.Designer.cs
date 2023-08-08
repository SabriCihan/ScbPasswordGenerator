using System;

namespace ScbPasswordGenerator
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.isCapital = new System.Windows.Forms.CheckBox();
      this.isLower = new System.Windows.Forms.CheckBox();
      this.isNumber = new System.Windows.Forms.CheckBox();
      this.isSymbol = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.copyButton = new System.Windows.Forms.Button();
      this.resultLabel = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 12);
      this.label1.MaximumSize = new System.Drawing.Size(460, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(259, 14);
      this.label1.TabIndex = 0;
      this.label1.Text = "Karmaşık şifre üretme uygulamasıdır.";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(390, 315);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(160, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Copyright © Tüm Hakları Saklıdır";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button1.Location = new System.Drawing.Point(16, 237);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(250, 36);
      this.button1.TabIndex = 2;
      this.button1.Text = "Şifre Üret →";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.textBox1.Location = new System.Drawing.Point(280, 238);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(189, 35);
      this.textBox1.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 315);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(94, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Sabri Cihan Bircan";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.Location = new System.Drawing.Point(11, 176);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(180, 22);
      this.label4.TabIndex = 5;
      this.label4.Text = "Karakter Sayısı: ";
      // 
      // comboBox1
      // 
      this.comboBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
      this.comboBox1.Location = new System.Drawing.Point(190, 174);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(76, 30);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.Text = "8";
      // 
      // isCapital
      // 
      this.isCapital.AutoSize = true;
      this.isCapital.Checked = true;
      this.isCapital.CheckState = System.Windows.Forms.CheckState.Checked;
      this.isCapital.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.isCapital.Location = new System.Drawing.Point(412, 172);
      this.isCapital.Margin = new System.Windows.Forms.Padding(2);
      this.isCapital.Name = "isCapital";
      this.isCapital.Size = new System.Drawing.Size(96, 19);
      this.isCapital.TabIndex = 6;
      this.isCapital.Text = "Büyük harf";
      this.isCapital.UseVisualStyleBackColor = true;
      // 
      // isLower
      // 
      this.isLower.AutoSize = true;
      this.isLower.Checked = true;
      this.isLower.CheckState = System.Windows.Forms.CheckState.Checked;
      this.isLower.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.isLower.Location = new System.Drawing.Point(308, 171);
      this.isLower.Margin = new System.Windows.Forms.Padding(2);
      this.isLower.Name = "isLower";
      this.isLower.Size = new System.Drawing.Size(96, 19);
      this.isLower.TabIndex = 7;
      this.isLower.Text = "Küçük harf";
      this.isLower.UseVisualStyleBackColor = true;
      // 
      // isNumber
      // 
      this.isNumber.AutoSize = true;
      this.isNumber.Checked = true;
      this.isNumber.CheckState = System.Windows.Forms.CheckState.Checked;
      this.isNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.isNumber.Location = new System.Drawing.Point(308, 195);
      this.isNumber.Margin = new System.Windows.Forms.Padding(2);
      this.isNumber.Name = "isNumber";
      this.isNumber.Size = new System.Drawing.Size(61, 19);
      this.isNumber.TabIndex = 8;
      this.isNumber.Text = "Rakam";
      this.isNumber.UseVisualStyleBackColor = true;
      // 
      // isSymbol
      // 
      this.isSymbol.AutoSize = true;
      this.isSymbol.Checked = true;
      this.isSymbol.CheckState = System.Windows.Forms.CheckState.Checked;
      this.isSymbol.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.isSymbol.Location = new System.Drawing.Point(412, 195);
      this.isSymbol.Margin = new System.Windows.Forms.Padding(2);
      this.isSymbol.Name = "isSymbol";
      this.isSymbol.Size = new System.Drawing.Size(117, 19);
      this.isSymbol.TabIndex = 9;
      this.isSymbol.Text = "Özel Karakter";
      this.isSymbol.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(12, 56);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(259, 14);
      this.label5.TabIndex = 10;
      this.label5.Text = "Güvenli Şifre Belirleme Standartları";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(12, 79);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(441, 56);
      this.label6.TabIndex = 11;
      this.label6.Text = "•\tŞifre, en az 8 karakterden oluşmalıdır.\r\n•\tŞifre, en az 1 küçük, 1 büyük ve 1 ö" +
    "zel karakter içermelidir.\r\n•\tŞifre, 90 günde bir değiştirilmelidir.\r\n•\tYeni şifr" +
    "e, önceki 3 şifreden farklı olmalıdır.";
      // 
      // copyButton
      // 
      this.copyButton.Location = new System.Drawing.Point(475, 237);
      this.copyButton.Name = "copyButton";
      this.copyButton.Size = new System.Drawing.Size(75, 36);
      this.copyButton.TabIndex = 13;
      this.copyButton.Text = "Kopyala";
      this.copyButton.UseVisualStyleBackColor = true;
      this.copyButton.Visible = false;
      this.copyButton.Click += new System.EventHandler(this.button2_Click);
      // 
      // resultLabel
      // 
      this.resultLabel.AutoSize = true;
      this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.resultLabel.ForeColor = System.Drawing.Color.Red;
      this.resultLabel.Location = new System.Drawing.Point(16, 280);
      this.resultLabel.Name = "resultLabel";
      this.resultLabel.Size = new System.Drawing.Size(0, 15);
      this.resultLabel.TabIndex = 14;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.InitialImage = null;
      this.pictureBox1.Location = new System.Drawing.Point(475, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(81, 77);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 12;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.HighlightText;
      this.ClientSize = new System.Drawing.Size(568, 343);
      this.Controls.Add(this.resultLabel);
      this.Controls.Add(this.copyButton);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.isSymbol);
      this.Controls.Add(this.isNumber);
      this.Controls.Add(this.isLower);
      this.Controls.Add(this.isCapital);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "SCB Password Generator";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.CheckBox isCapital;
    private System.Windows.Forms.CheckBox isLower;
    private System.Windows.Forms.CheckBox isNumber;
    private System.Windows.Forms.CheckBox isSymbol;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button copyButton;
    private System.Windows.Forms.Label resultLabel;
  }
}

