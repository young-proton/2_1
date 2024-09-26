
namespace _2_1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total_answer = new System.Windows.Forms.Label();
            this.class_c_answer = new System.Windows.Forms.Label();
            this.class_b_answer = new System.Windows.Forms.Label();
            this.class_a_answer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.class_c_value = new System.Windows.Forms.TextBox();
            this.class_b_value = new System.Windows.Forms.TextBox();
            this.class_a_value = new System.Windows.Forms.TextBox();
            this.class_c_lbl = new System.Windows.Forms.Label();
            this.class_b_lbl = new System.Windows.Forms.Label();
            this.class_a_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.total_answer);
            this.groupBox2.Controls.Add(this.class_c_answer);
            this.groupBox2.Controls.Add(this.class_b_answer);
            this.groupBox2.Controls.Add(this.class_a_answer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(414, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 299);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculated revenue";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // total_answer
            // 
            this.total_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_answer.Location = new System.Drawing.Point(138, 236);
            this.total_answer.Name = "total_answer";
            this.total_answer.Size = new System.Drawing.Size(122, 25);
            this.total_answer.TabIndex = 7;
            this.total_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // class_c_answer
            // 
            this.class_c_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.class_c_answer.Location = new System.Drawing.Point(138, 199);
            this.class_c_answer.Name = "class_c_answer";
            this.class_c_answer.Size = new System.Drawing.Size(122, 25);
            this.class_c_answer.TabIndex = 6;
            this.class_c_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.class_c_answer.Click += new System.EventHandler(this.label11_Click);
            // 
            // class_b_answer
            // 
            this.class_b_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.class_b_answer.Location = new System.Drawing.Point(138, 161);
            this.class_b_answer.Name = "class_b_answer";
            this.class_b_answer.Size = new System.Drawing.Size(122, 25);
            this.class_b_answer.TabIndex = 5;
            this.class_b_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // class_a_answer
            // 
            this.class_a_answer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.class_a_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.class_a_answer.Location = new System.Drawing.Point(138, 125);
            this.class_a_answer.Name = "class_a_answer";
            this.class_a_answer.Size = new System.Drawing.Size(122, 25);
            this.class_a_answer.TabIndex = 4;
            this.class_a_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Class С:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Class B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Class A:";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.class_c_value);
            this.groupBox3.Controls.Add(this.class_b_value);
            this.groupBox3.Controls.Add(this.class_a_value);
            this.groupBox3.Controls.Add(this.class_c_lbl);
            this.groupBox3.Controls.Add(this.class_b_lbl);
            this.groupBox3.Controls.Add(this.class_a_lbl);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 299);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tickets sold";
            // 
            // class_c_value
            // 
            this.class_c_value.Location = new System.Drawing.Point(125, 214);
            this.class_c_value.Name = "class_c_value";
            this.class_c_value.Size = new System.Drawing.Size(159, 29);
            this.class_c_value.TabIndex = 6;
            // 
            // class_b_value
            // 
            this.class_b_value.Location = new System.Drawing.Point(126, 178);
            this.class_b_value.Name = "class_b_value";
            this.class_b_value.Size = new System.Drawing.Size(159, 29);
            this.class_b_value.TabIndex = 5;
            // 
            // class_a_value
            // 
            this.class_a_value.Location = new System.Drawing.Point(126, 140);
            this.class_a_value.Name = "class_a_value";
            this.class_a_value.Size = new System.Drawing.Size(159, 29);
            this.class_a_value.TabIndex = 4;
            // 
            // class_c_lbl
            // 
            this.class_c_lbl.AutoSize = true;
            this.class_c_lbl.Location = new System.Drawing.Point(34, 219);
            this.class_c_lbl.Name = "class_c_lbl";
            this.class_c_lbl.Size = new System.Drawing.Size(78, 24);
            this.class_c_lbl.TabIndex = 3;
            this.class_c_lbl.Text = "Class С:";
            // 
            // class_b_lbl
            // 
            this.class_b_lbl.AutoSize = true;
            this.class_b_lbl.Location = new System.Drawing.Point(34, 181);
            this.class_b_lbl.Name = "class_b_lbl";
            this.class_b_lbl.Size = new System.Drawing.Size(77, 24);
            this.class_b_lbl.TabIndex = 2;
            this.class_b_lbl.Text = "Class B:";
            // 
            // class_a_lbl
            // 
            this.class_a_lbl.AutoSize = true;
            this.class_a_lbl.Location = new System.Drawing.Point(34, 145);
            this.class_a_lbl.Name = "class_a_lbl";
            this.class_a_lbl.Size = new System.Drawing.Size(78, 24);
            this.class_a_lbl.TabIndex = 1;
            this.class_a_lbl.Text = "Class A:";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold for each class of seats";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(311, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 69);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear all";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(530, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(92, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 69);
            this.button3.TabIndex = 8;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Location = new System.Drawing.Point(100, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 57);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ammount of money that you earned ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 413);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "App";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label total_answer;
        private System.Windows.Forms.Label class_c_answer;
        private System.Windows.Forms.Label class_b_answer;
        private System.Windows.Forms.Label class_a_answer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox class_c_value;
        private System.Windows.Forms.TextBox class_b_value;
        private System.Windows.Forms.TextBox class_a_value;
        private System.Windows.Forms.Label class_c_lbl;
        private System.Windows.Forms.Label class_b_lbl;
        private System.Windows.Forms.Label class_a_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}

