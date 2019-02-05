namespace mypaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pen = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Pen1 = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Pen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(166, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 466);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Pen
            // 
            this.Pen.Controls.Add(this.comboBox2);
            this.Pen.Controls.Add(this.comboBox1);
            this.Pen.Location = new System.Drawing.Point(12, 53);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(148, 100);
            this.Pen.TabIndex = 0;
            this.Pen.TabStop = false;
            this.Pen.Text = "Pen";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // Pen1
            // 
            this.Pen1.AutoSize = true;
            this.Pen1.Location = new System.Drawing.Point(12, 205);
            this.Pen1.Name = "Pen1";
            this.Pen1.Size = new System.Drawing.Size(54, 21);
            this.Pen1.TabIndex = 1;
            this.Pen1.TabStop = true;
            this.Pen1.Text = "Pen";
            this.Pen1.UseVisualStyleBackColor = true;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(12, 232);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(56, 21);
            this.Line.TabIndex = 2;
            this.Line.TabStop = true;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(12, 259);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(93, 21);
            this.Rectangle.TabIndex = 3;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(12, 286);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(62, 21);
            this.Circle.TabIndex = 4;
            this.Circle.TabStop = true;
            this.Circle.Text = "circle";
            this.Circle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 490);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Pen1);
            this.Controls.Add(this.Pen);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Pen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Pen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton Pen1;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

