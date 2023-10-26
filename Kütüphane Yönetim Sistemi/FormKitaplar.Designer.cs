namespace Kütüphane_Yönetim_Sistemi
{
    partial class FormKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            groupBox1 = new GroupBox();
            button7 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button5 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 321);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap İşlemleri";
            // 
            // button7
            // 
            button7.Location = new Point(262, 271);
            button7.Name = "button7";
            button7.Size = new Size(99, 44);
            button7.TabIndex = 16;
            button7.Text = "Temizle";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button2
            // 
            button2.Location = new Point(146, 271);
            button2.Name = "button2";
            button2.Size = new Size(99, 44);
            button2.TabIndex = 14;
            button2.Text = "Kitap Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(30, 271);
            button1.Name = "button1";
            button1.Size = new Size(99, 44);
            button1.TabIndex = 13;
            button1.Text = "Kitap Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(146, 191);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 195);
            label7.Name = "label7";
            label7.Size = new Size(114, 19);
            label7.TabIndex = 6;
            label7.Text = "Kitap Türü Kodu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 150);
            label5.Name = "label5";
            label5.Size = new Size(43, 19);
            label5.TabIndex = 4;
            label5.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 115);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 3;
            label4.Text = "Yazar Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 2;
            label3.Text = "Kitap Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(146, 36);
            label2.Name = "label2";
            label2.Size = new Size(14, 19);
            label2.TabIndex = 1;
            label2.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 36);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 0;
            label1.Text = "KitapID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(411, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 321);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödünç İşlemleri";
            // 
            // button5
            // 
            button5.Location = new Point(120, 138);
            button5.Name = "button5";
            button5.Size = new Size(115, 63);
            button5.TabIndex = 16;
            button5.Text = "Ödünç Başlat";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(139, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(16, 78);
            label9.Name = "label9";
            label9.Size = new Size(45, 19);
            label9.TabIndex = 2;
            label9.Text = "Tarih:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 36);
            label8.Name = "label8";
            label8.Size = new Size(88, 19);
            label8.TabIndex = 1;
            label8.Text = "Ödünç Alan:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(743, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(283, 321);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "İade İşlemleri";
            // 
            // button4
            // 
            button4.Location = new Point(92, 138);
            button4.Name = "button4";
            button4.Size = new Size(99, 44);
            button4.TabIndex = 16;
            button4.Text = "Kitap İade Et";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(95, 75);
            button3.Name = "button3";
            button3.Size = new Size(99, 44);
            button3.TabIndex = 15;
            button3.Text = "Gecikme Bedeli Hesapla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(170, 36);
            label12.Name = "label12";
            label12.Size = new Size(24, 19);
            label12.TabIndex = 4;
            label12.Text = "TL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(136, 36);
            label11.Name = "label11";
            label11.Size = new Size(17, 19);
            label11.TabIndex = 3;
            label11.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(16, 36);
            label10.Name = "label10";
            label10.Size = new Size(114, 19);
            label10.TabIndex = 2;
            label10.Text = "Gecikme Bedeli:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(990, 156);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(14, 344);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1012, 178);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1038, 534);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormKitaplar";
            Text = "Kütüphane YTS by Alien";
            FormClosed += FormKitaplar_FormClosed;
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private Label label9;
        private Label label8;
        private Button button5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button button7;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
    }
}