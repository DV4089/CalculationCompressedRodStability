namespace CalculationCompressedRodStability
{
    partial class MainWindow
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
            numericUpDown_l = new NumericUpDown();
            numericUpDown_d = new NumericUpDown();
            label_l = new Label();
            label_d = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton_shema3 = new RadioButton();
            radioButton_shema2 = new RadioButton();
            radioButton_shema1 = new RadioButton();
            Calculationbutton = new Button();
            Resetbutton = new Button();
            textBox_result = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_l).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_d).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDown_l
            // 
            numericUpDown_l.DecimalPlaces = 1;
            numericUpDown_l.Location = new Point(166, 30);
            numericUpDown_l.Name = "numericUpDown_l";
            numericUpDown_l.Size = new Size(120, 23);
            numericUpDown_l.TabIndex = 0;
            numericUpDown_l.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown_d
            // 
            numericUpDown_d.DecimalPlaces = 1;
            numericUpDown_d.Location = new Point(166, 80);
            numericUpDown_d.Name = "numericUpDown_d";
            numericUpDown_d.Size = new Size(120, 23);
            numericUpDown_d.TabIndex = 0;
            numericUpDown_d.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label_l
            // 
            label_l.AutoSize = true;
            label_l.Location = new Point(10, 30);
            label_l.Name = "label_l";
            label_l.Size = new Size(153, 15);
            label_l.TabIndex = 1;
            label_l.Text = "Введите длину стержня, м:";
            // 
            // label_d
            // 
            label_d.AutoSize = true;
            label_d.Location = new Point(10, 80);
            label_d.Name = "label_d";
            label_d.Size = new Size(128, 15);
            label_d.TabIndex = 1;
            label_d.Text = "Диаметр стержня, см:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Schema;
            pictureBox1.Location = new Point(27, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 273);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown_l);
            groupBox1.Controls.Add(numericUpDown_d);
            groupBox1.Controls.Add(label_l);
            groupBox1.Controls.Add(label_d);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 130);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод начальных значений";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton_shema3);
            groupBox2.Controls.Add(radioButton_shema2);
            groupBox2.Controls.Add(radioButton_shema1);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(10, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 410);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выбор расчетной схемы";
            // 
            // radioButton_shema3
            // 
            radioButton_shema3.AutoSize = true;
            radioButton_shema3.Location = new Point(27, 364);
            radioButton_shema3.Name = "radioButton_shema3";
            radioButton_shema3.Size = new Size(198, 19);
            radioButton_shema3.TabIndex = 4;
            radioButton_shema3.Text = "Схема 3) Заделка с двух сторон";
            radioButton_shema3.UseVisualStyleBackColor = true;
            // 
            // radioButton_shema2
            // 
            radioButton_shema2.AutoSize = true;
            radioButton_shema2.Location = new Point(27, 339);
            radioButton_shema2.Name = "radioButton_shema2";
            radioButton_shema2.Size = new Size(176, 19);
            radioButton_shema2.TabIndex = 4;
            radioButton_shema2.Text = "Схема 2) Свободный конец";
            radioButton_shema2.UseVisualStyleBackColor = true;
            // 
            // radioButton_shema1
            // 
            radioButton_shema1.AutoSize = true;
            radioButton_shema1.CheckAlign = ContentAlignment.TopLeft;
            radioButton_shema1.Checked = true;
            radioButton_shema1.Location = new Point(27, 314);
            radioButton_shema1.Name = "radioButton_shema1";
            radioButton_shema1.Size = new Size(214, 19);
            radioButton_shema1.TabIndex = 4;
            radioButton_shema1.TabStop = true;
            radioButton_shema1.Text = "Схема 1) Шарнирное закрепление";
            radioButton_shema1.UseVisualStyleBackColor = true;
            // 
            // Calculationbutton
            // 
            Calculationbutton.Location = new Point(306, 40);
            Calculationbutton.Name = "Calculationbutton";
            Calculationbutton.Size = new Size(100, 30);
            Calculationbutton.TabIndex = 6;
            Calculationbutton.Text = "Рассчитать";
            Calculationbutton.UseVisualStyleBackColor = true;
            Calculationbutton.Click += Calculationbutton_Click;
            // 
            // Resetbutton
            // 
            Resetbutton.Location = new Point(306, 90);
            Resetbutton.Name = "Resetbutton";
            Resetbutton.Size = new Size(100, 30);
            Resetbutton.TabIndex = 6;
            Resetbutton.Text = "Сбросить всё";
            Resetbutton.UseVisualStyleBackColor = true;
            Resetbutton.Click += Resetbutton_Click;
            // 
            // textBox_result
            // 
            textBox_result.Location = new Point(306, 172);
            textBox_result.Name = "textBox_result";
            textBox_result.Size = new Size(140, 23);
            textBox_result.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 150);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 8;
            label1.Text = "Итог, Н";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 571);
            Controls.Add(label1);
            Controls.Add(textBox_result);
            Controls.Add(Resetbutton);
            Controls.Add(Calculationbutton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainWindow";
            Text = "Расчёт сжатого стержня на устойчивость";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_l).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_d).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown_l;
        private NumericUpDown numericUpDown_d;
        private Label label_l;
        private Label label_d;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton_shema3;
        private RadioButton radioButton_shema2;
        private RadioButton radioButton_shema1;
        private Button Calculationbutton;
        private Button Resetbutton;
        private TextBox textBox_result;
        private Label label1;
    }
}