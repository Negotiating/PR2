namespace PR2_1_2_WF
{
	partial class practic2
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
			this.task1 = new System.Windows.Forms.GroupBox();
			this.result = new System.Windows.Forms.Label();
			this.y = new System.Windows.Forms.TextBox();
			this.x = new System.Windows.Forms.TextBox();
			this.y_label = new System.Windows.Forms.Label();
			this.x_label = new System.Windows.Forms.Label();
			this.Check = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.task2 = new System.Windows.Forms.GroupBox();
			this.names_label = new System.Windows.Forms.Label();
			this.names = new System.Windows.Forms.RichTextBox();
			this.sex = new System.Windows.Forms.ComboBox();
			this.sex_label = new System.Windows.Forms.Label();
			this.task3 = new System.Windows.Forms.GroupBox();
			this.show = new System.Windows.Forms.Button();
			this.show_box = new System.Windows.Forms.RichTextBox();
			this.task4 = new System.Windows.Forms.GroupBox();
			this.show4 = new System.Windows.Forms.Button();
			this.show_box4 = new System.Windows.Forms.RichTextBox();
			this.task1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.task2.SuspendLayout();
			this.task3.SuspendLayout();
			this.task4.SuspendLayout();
			this.SuspendLayout();
			// 
			// task1
			// 
			this.task1.Controls.Add(this.result);
			this.task1.Controls.Add(this.y);
			this.task1.Controls.Add(this.x);
			this.task1.Controls.Add(this.y_label);
			this.task1.Controls.Add(this.x_label);
			this.task1.Controls.Add(this.Check);
			this.task1.Controls.Add(this.pictureBox1);
			this.task1.Location = new System.Drawing.Point(11, 13);
			this.task1.Name = "task1";
			this.task1.Size = new System.Drawing.Size(400, 308);
			this.task1.TabIndex = 0;
			this.task1.TabStop = false;
			this.task1.Text = "Задание 1";
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(228, 225);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(0, 17);
			this.result.TabIndex = 6;
			// 
			// y
			// 
			this.y.Location = new System.Drawing.Point(126, 75);
			this.y.Name = "y";
			this.y.Size = new System.Drawing.Size(100, 22);
			this.y.TabIndex = 5;
			this.y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_KeyPress);
			// 
			// x
			// 
			this.x.Location = new System.Drawing.Point(126, 43);
			this.x.Name = "x";
			this.x.Size = new System.Drawing.Size(100, 22);
			this.x.TabIndex = 4;
			this.x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_KeyPress);
			// 
			// y_label
			// 
			this.y_label.AutoSize = true;
			this.y_label.Location = new System.Drawing.Point(18, 75);
			this.y_label.Name = "y_label";
			this.y_label.Size = new System.Drawing.Size(103, 17);
			this.y_label.TabIndex = 3;
			this.y_label.Text = "Координата y:";
			// 
			// x_label
			// 
			this.x_label.AutoSize = true;
			this.x_label.Location = new System.Drawing.Point(18, 43);
			this.x_label.Name = "x_label";
			this.x_label.Size = new System.Drawing.Size(102, 17);
			this.x_label.TabIndex = 2;
			this.x_label.Text = "Координата x:";
			// 
			// Check
			// 
			this.Check.Location = new System.Drawing.Point(228, 245);
			this.Check.Name = "Check";
			this.Check.Size = new System.Drawing.Size(166, 53);
			this.Check.TabIndex = 1;
			this.Check.Text = "Проверить";
			this.Check.UseVisualStyleBackColor = true;
			this.Check.Click += new System.EventHandler(this.Check_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PR2_1_2_WF.Properties.Resources.график;
			this.pictureBox1.Location = new System.Drawing.Point(6, 115);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(216, 183);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// task2
			// 
			this.task2.Controls.Add(this.names_label);
			this.task2.Controls.Add(this.names);
			this.task2.Controls.Add(this.sex);
			this.task2.Controls.Add(this.sex_label);
			this.task2.Location = new System.Drawing.Point(434, 13);
			this.task2.Name = "task2";
			this.task2.Size = new System.Drawing.Size(221, 308);
			this.task2.TabIndex = 1;
			this.task2.TabStop = false;
			this.task2.Text = "Задание 2";
			// 
			// names_label
			// 
			this.names_label.AutoSize = true;
			this.names_label.Location = new System.Drawing.Point(6, 72);
			this.names_label.Name = "names_label";
			this.names_label.Size = new System.Drawing.Size(55, 17);
			this.names_label.TabIndex = 3;
			this.names_label.Text = "Имена:";
			// 
			// names
			// 
			this.names.Enabled = false;
			this.names.Location = new System.Drawing.Point(6, 92);
			this.names.Name = "names";
			this.names.Size = new System.Drawing.Size(209, 206);
			this.names.TabIndex = 2;
			this.names.Text = "";
			// 
			// sex
			// 
			this.sex.FormattingEnabled = true;
			this.sex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
			this.sex.Location = new System.Drawing.Point(72, 35);
			this.sex.Name = "sex";
			this.sex.Size = new System.Drawing.Size(121, 24);
			this.sex.TabIndex = 1;
			this.sex.SelectedIndexChanged += new System.EventHandler(this.sex_SelectedIndexChanged);
			// 
			// sex_label
			// 
			this.sex_label.AutoSize = true;
			this.sex_label.Location = new System.Drawing.Point(28, 35);
			this.sex_label.Name = "sex_label";
			this.sex_label.Size = new System.Drawing.Size(38, 17);
			this.sex_label.TabIndex = 0;
			this.sex_label.Text = "Пол:";
			// 
			// task3
			// 
			this.task3.Controls.Add(this.show);
			this.task3.Controls.Add(this.show_box);
			this.task3.Location = new System.Drawing.Point(17, 330);
			this.task3.Name = "task3";
			this.task3.Size = new System.Drawing.Size(296, 245);
			this.task3.TabIndex = 2;
			this.task3.TabStop = false;
			this.task3.Text = "Задание 3";
			// 
			// show
			// 
			this.show.Location = new System.Drawing.Point(10, 186);
			this.show.Name = "show";
			this.show.Size = new System.Drawing.Size(272, 53);
			this.show.TabIndex = 1;
			this.show.Text = "Показать";
			this.show.UseVisualStyleBackColor = true;
			this.show.Click += new System.EventHandler(this.show_Click);
			// 
			// show_box
			// 
			this.show_box.Location = new System.Drawing.Point(10, 26);
			this.show_box.Name = "show_box";
			this.show_box.Size = new System.Drawing.Size(272, 154);
			this.show_box.TabIndex = 0;
			this.show_box.Text = "";
			// 
			// task4
			// 
			this.task4.Controls.Add(this.show4);
			this.task4.Controls.Add(this.show_box4);
			this.task4.Location = new System.Drawing.Point(359, 330);
			this.task4.Name = "task4";
			this.task4.Size = new System.Drawing.Size(296, 245);
			this.task4.TabIndex = 3;
			this.task4.TabStop = false;
			this.task4.Text = "Задание 4";
			// 
			// show4
			// 
			this.show4.Location = new System.Drawing.Point(10, 186);
			this.show4.Name = "show4";
			this.show4.Size = new System.Drawing.Size(272, 53);
			this.show4.TabIndex = 1;
			this.show4.Text = "Показать";
			this.show4.UseVisualStyleBackColor = true;
			this.show4.Click += new System.EventHandler(this.show4_Click);
			// 
			// show_box4
			// 
			this.show_box4.Location = new System.Drawing.Point(10, 26);
			this.show_box4.Name = "show_box4";
			this.show_box4.Size = new System.Drawing.Size(272, 154);
			this.show_box4.TabIndex = 0;
			this.show_box4.Text = "";
			// 
			// practic2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 587);
			this.Controls.Add(this.task4);
			this.Controls.Add(this.task3);
			this.Controls.Add(this.task2);
			this.Controls.Add(this.task1);
			this.Name = "practic2";
			this.Text = "Практикум 2";
			this.task1.ResumeLayout(false);
			this.task1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.task2.ResumeLayout(false);
			this.task2.PerformLayout();
			this.task3.ResumeLayout(false);
			this.task4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox task1;
		private System.Windows.Forms.TextBox y;
		private System.Windows.Forms.TextBox x;
		private System.Windows.Forms.Label y_label;
		private System.Windows.Forms.Label x_label;
		private System.Windows.Forms.Button Check;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label result;
		private System.Windows.Forms.GroupBox task2;
		private System.Windows.Forms.Label sex_label;
		private System.Windows.Forms.ComboBox sex;
		private System.Windows.Forms.RichTextBox names;
		private System.Windows.Forms.Label names_label;
		private System.Windows.Forms.GroupBox task3;
		private System.Windows.Forms.Button show;
		private System.Windows.Forms.RichTextBox show_box;
		private System.Windows.Forms.GroupBox task4;
		private System.Windows.Forms.Button show4;
		private System.Windows.Forms.RichTextBox show_box4;
	}
}

