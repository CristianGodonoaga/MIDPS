namespace GUI__alculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.change_sign = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.labelOperatie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(58, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxValue.Location = new System.Drawing.Point(12, 12);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.ShortcutsEnabled = false;
            this.textBoxValue.Size = new System.Drawing.Size(224, 27);
            this.textBoxValue.TabIndex = 4;
            this.textBoxValue.Text = "0";
            this.textBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(104, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(12, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(58, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 34);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(104, 89);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 34);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(12, 49);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 34);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Location = new System.Drawing.Point(58, 49);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 34);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Location = new System.Drawing.Point(104, 49);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 34);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button0.Location = new System.Drawing.Point(12, 169);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(40, 34);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.point.Location = new System.Drawing.Point(58, 169);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(40, 34);
            this.point.TabIndex = 13;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.buttonDecimal_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add.Location = new System.Drawing.Point(150, 129);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(40, 34);
            this.add.TabIndex = 17;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sub.Location = new System.Drawing.Point(196, 129);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(40, 34);
            this.sub.TabIndex = 16;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // times
            // 
            this.times.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.times.Location = new System.Drawing.Point(150, 89);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(40, 34);
            this.times.TabIndex = 15;
            this.times.Text = "*";
            this.times.UseVisualStyleBackColor = false;
            this.times.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.div.Location = new System.Drawing.Point(196, 89);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(40, 34);
            this.div.TabIndex = 14;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.power.Location = new System.Drawing.Point(150, 49);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(40, 34);
            this.power.TabIndex = 18;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = false;
            this.power.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sqrt.Location = new System.Drawing.Point(196, 49);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(40, 34);
            this.sqrt.TabIndex = 19;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // change_sign
            // 
            this.change_sign.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.change_sign.Location = new System.Drawing.Point(104, 169);
            this.change_sign.Name = "change_sign";
            this.change_sign.Size = new System.Drawing.Size(40, 34);
            this.change_sign.TabIndex = 20;
            this.change_sign.Text = "+/-";
            this.change_sign.UseVisualStyleBackColor = false;
            this.change_sign.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonClear.Location = new System.Drawing.Point(150, 169);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(40, 34);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.equal.Location = new System.Drawing.Point(196, 169);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(40, 34);
            this.equal.TabIndex = 22;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.buttonEqal_Click);
            // 
            // labelOperatie
            // 
            this.labelOperatie.AutoSize = true;
            this.labelOperatie.BackColor = System.Drawing.SystemColors.Control;
            this.labelOperatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOperatie.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelOperatie.Location = new System.Drawing.Point(13, 14);
            this.labelOperatie.Name = "labelOperatie";
            this.labelOperatie.Size = new System.Drawing.Size(15, 24);
            this.labelOperatie.TabIndex = 23;
            this.labelOperatie.Text = " ";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 215);
            this.Controls.Add(this.labelOperatie);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.change_sign);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.power);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.times);
            this.Controls.Add(this.div);
            this.Controls.Add(this.point);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button change_sign;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Label labelOperatie;
    }
}

