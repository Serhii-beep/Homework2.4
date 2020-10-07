namespace HM_Geometry
{
    partial class Form2
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
            this.tbSide1 = new System.Windows.Forms.TextBox();
            this.tbSide2 = new System.Windows.Forms.TextBox();
            this.tbSide3 = new System.Windows.Forms.TextBox();
            this.lblSide1 = new System.Windows.Forms.Label();
            this.lblSide2 = new System.Windows.Forms.Label();
            this.lblSide3 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.tbAngle1 = new System.Windows.Forms.TextBox();
            this.tbAngle2 = new System.Windows.Forms.TextBox();
            this.tbAngle3 = new System.Windows.Forms.TextBox();
            this.tbPerimeter = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.lblAngle1 = new System.Windows.Forms.Label();
            this.lblAngle2 = new System.Windows.Forms.Label();
            this.lblAngle3 = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSide1
            // 
            this.tbSide1.Location = new System.Drawing.Point(12, 26);
            this.tbSide1.Name = "tbSide1";
            this.tbSide1.Size = new System.Drawing.Size(125, 27);
            this.tbSide1.TabIndex = 0;
            // 
            // tbSide2
            // 
            this.tbSide2.Location = new System.Drawing.Point(328, 26);
            this.tbSide2.Name = "tbSide2";
            this.tbSide2.Size = new System.Drawing.Size(125, 27);
            this.tbSide2.TabIndex = 1;
            // 
            // tbSide3
            // 
            this.tbSide3.Location = new System.Drawing.Point(663, 26);
            this.tbSide3.Name = "tbSide3";
            this.tbSide3.Size = new System.Drawing.Size(125, 27);
            this.tbSide3.TabIndex = 2;
            // 
            // lblSide1
            // 
            this.lblSide1.AutoSize = true;
            this.lblSide1.Location = new System.Drawing.Point(12, 68);
            this.lblSide1.Name = "lblSide1";
            this.lblSide1.Size = new System.Drawing.Size(118, 20);
            this.lblSide1.TabIndex = 3;
            this.lblSide1.Text = "Перша сторона";
            this.lblSide1.Click += new System.EventHandler(this.lblSide1_Click);
            // 
            // lblSide2
            // 
            this.lblSide2.AutoSize = true;
            this.lblSide2.Location = new System.Drawing.Point(343, 68);
            this.lblSide2.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.lblSide2.Name = "lblSide2";
            this.lblSide2.Size = new System.Drawing.Size(110, 20);
            this.lblSide2.TabIndex = 4;
            this.lblSide2.Text = "Друга сторона";
            this.lblSide2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSide3
            // 
            this.lblSide3.AutoSize = true;
            this.lblSide3.Location = new System.Drawing.Point(679, 68);
            this.lblSide3.Name = "lblSide3";
            this.lblSide3.Size = new System.Drawing.Size(109, 20);
            this.lblSide3.TabIndex = 5;
            this.lblSide3.Text = "Третя сторона";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(639, 371);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(149, 67);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Розрахувати";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // tbAngle1
            // 
            this.tbAngle1.Location = new System.Drawing.Point(12, 202);
            this.tbAngle1.Name = "tbAngle1";
            this.tbAngle1.ReadOnly = true;
            this.tbAngle1.Size = new System.Drawing.Size(125, 27);
            this.tbAngle1.TabIndex = 7;
            // 
            // tbAngle2
            // 
            this.tbAngle2.Location = new System.Drawing.Point(12, 254);
            this.tbAngle2.Name = "tbAngle2";
            this.tbAngle2.ReadOnly = true;
            this.tbAngle2.Size = new System.Drawing.Size(125, 27);
            this.tbAngle2.TabIndex = 8;
            // 
            // tbAngle3
            // 
            this.tbAngle3.Location = new System.Drawing.Point(12, 307);
            this.tbAngle3.Name = "tbAngle3";
            this.tbAngle3.ReadOnly = true;
            this.tbAngle3.Size = new System.Drawing.Size(125, 27);
            this.tbAngle3.TabIndex = 9;
            // 
            // tbPerimeter
            // 
            this.tbPerimeter.Location = new System.Drawing.Point(12, 361);
            this.tbPerimeter.Name = "tbPerimeter";
            this.tbPerimeter.ReadOnly = true;
            this.tbPerimeter.Size = new System.Drawing.Size(125, 27);
            this.tbPerimeter.TabIndex = 10;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(12, 411);
            this.tbArea.Name = "tbArea";
            this.tbArea.ReadOnly = true;
            this.tbArea.Size = new System.Drawing.Size(125, 27);
            this.tbArea.TabIndex = 11;
            // 
            // lblAngle1
            // 
            this.lblAngle1.AutoSize = true;
            this.lblAngle1.Location = new System.Drawing.Point(180, 209);
            this.lblAngle1.Name = "lblAngle1";
            this.lblAngle1.Size = new System.Drawing.Size(91, 20);
            this.lblAngle1.TabIndex = 12;
            this.lblAngle1.Text = "Перший кут";
            // 
            // lblAngle2
            // 
            this.lblAngle2.AutoSize = true;
            this.lblAngle2.Location = new System.Drawing.Point(180, 261);
            this.lblAngle2.Name = "lblAngle2";
            this.lblAngle2.Size = new System.Drawing.Size(83, 20);
            this.lblAngle2.TabIndex = 13;
            this.lblAngle2.Text = "Другий кут";
            // 
            // lblAngle3
            // 
            this.lblAngle3.AutoSize = true;
            this.lblAngle3.Location = new System.Drawing.Point(180, 314);
            this.lblAngle3.Name = "lblAngle3";
            this.lblAngle3.Size = new System.Drawing.Size(77, 20);
            this.lblAngle3.TabIndex = 14;
            this.lblAngle3.Text = "Третій кут";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(180, 368);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(80, 20);
            this.lblPerimeter.TabIndex = 15;
            this.lblPerimeter.Text = "Периметр";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(180, 418);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(57, 20);
            this.lblArea.TabIndex = 16;
            this.lblArea.Text = "Площа";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(639, 290);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 61);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblAngle3);
            this.Controls.Add(this.lblAngle2);
            this.Controls.Add(this.lblAngle1);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbPerimeter);
            this.Controls.Add(this.tbAngle3);
            this.Controls.Add(this.tbAngle2);
            this.Controls.Add(this.tbAngle1);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblSide3);
            this.Controls.Add(this.lblSide2);
            this.Controls.Add(this.lblSide1);
            this.Controls.Add(this.tbSide3);
            this.Controls.Add(this.tbSide2);
            this.Controls.Add(this.tbSide1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSide1;
        private System.Windows.Forms.TextBox tbSide2;
        private System.Windows.Forms.TextBox tbSide3;
        private System.Windows.Forms.Label lblSide1;
        private System.Windows.Forms.Label lblSide2;
        private System.Windows.Forms.Label lblSide3;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox tbAngle1;
        private System.Windows.Forms.TextBox tbAngle2;
        private System.Windows.Forms.TextBox tbAngle3;
        private System.Windows.Forms.TextBox tbPerimeter;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Label lblAngle1;
        private System.Windows.Forms.Label lblAngle2;
        private System.Windows.Forms.Label lblAngle3;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnClear;
    }
}