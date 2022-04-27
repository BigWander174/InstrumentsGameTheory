namespace InstrumentsGameTheory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ANumerics = new System.Windows.Forms.NumericUpDown();
            this.BNumerics = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.simpleView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANumerics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumerics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainView
            // 
            this.mainView.AllowUserToAddRows = false;
            this.mainView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.mainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainView.Location = new System.Drawing.Point(12, 82);
            this.mainView.Name = "mainView";
            this.mainView.RowHeadersWidth = 75;
            this.mainView.RowTemplate.Height = 29;
            this.mainView.Size = new System.Drawing.Size(496, 290);
            this.mainView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // ANumerics
            // 
            this.ANumerics.Location = new System.Drawing.Point(37, 7);
            this.ANumerics.Name = "ANumerics";
            this.ANumerics.Size = new System.Drawing.Size(150, 27);
            this.ANumerics.TabIndex = 2;
            this.ANumerics.ValueChanged += new System.EventHandler(this.ANumerics_ValueChanged);
            // 
            // BNumerics
            // 
            this.BNumerics.Location = new System.Drawing.Point(37, 40);
            this.BNumerics.Name = "BNumerics";
            this.BNumerics.Size = new System.Drawing.Size(150, 27);
            this.BNumerics.TabIndex = 4;
            this.BNumerics.ValueChanged += new System.EventHandler(this.BNumerics_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 77);
            this.button1.TabIndex = 5;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // simpleView
            // 
            this.simpleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simpleView.Location = new System.Drawing.Point(711, 82);
            this.simpleView.Name = "simpleView";
            this.simpleView.RowHeadersWidth = 51;
            this.simpleView.RowTemplate.Height = 29;
            this.simpleView.Size = new System.Drawing.Size(390, 210);
            this.simpleView.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Упрощенная матрица";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(711, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "B";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(764, 321);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(252, 27);
            this.textBoxA.TabIndex = 10;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(764, 359);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(252, 27);
            this.textBoxB.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 462);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simpleView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BNumerics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ANumerics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainView);
            this.Name = "Form1";
            this.Text = "Теория игр";
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANumerics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumerics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView mainView;
        private Label label1;
        private NumericUpDown ANumerics;
        private NumericUpDown BNumerics;
        private Label label2;
        private Button button1;
        private DataGridView simpleView;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxA;
        private TextBox textBoxB;
    }
}