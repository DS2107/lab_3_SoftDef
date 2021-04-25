
namespace Lab3_Stru_IVT_7_V8
{
    partial class MainForm
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
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.listBox_left = new System.Windows.Forms.ListBox();
            this.listBox_right = new System.Windows.Forms.ListBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete_left = new System.Windows.Forms.Button();
            this.button_Delete_right = new System.Windows.Forms.Button();
            this.button_re = new System.Windows.Forms.Button();
            this.button_tp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_path
            // 
            this.textBox_path.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_path.Location = new System.Drawing.Point(12, 32);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(869, 30);
            this.textBox_path.TabIndex = 0;
            // 
            // listBox_left
            // 
            this.listBox_left.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_left.FormattingEnabled = true;
            this.listBox_left.ItemHeight = 23;
            this.listBox_left.Location = new System.Drawing.Point(14, 97);
            this.listBox_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_left.Name = "listBox_left";
            this.listBox_left.Size = new System.Drawing.Size(491, 211);
            this.listBox_left.TabIndex = 1;
            // 
            // listBox_right
            // 
            this.listBox_right.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_right.FormattingEnabled = true;
            this.listBox_right.ItemHeight = 23;
            this.listBox_right.Location = new System.Drawing.Point(549, 97);
            this.listBox_right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_right.Name = "listBox_right";
            this.listBox_right.Size = new System.Drawing.Size(491, 211);
            this.listBox_right.TabIndex = 2;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Add.Location = new System.Drawing.Point(906, 14);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(134, 60);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete_left
            // 
            this.button_Delete_left.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete_left.Location = new System.Drawing.Point(14, 315);
            this.button_Delete_left.Name = "button_Delete_left";
            this.button_Delete_left.Size = new System.Drawing.Size(126, 45);
            this.button_Delete_left.TabIndex = 4;
            this.button_Delete_left.Text = "Удалить";
            this.button_Delete_left.UseVisualStyleBackColor = true;
            this.button_Delete_left.Click += new System.EventHandler(this.button_Delete_left_Click);
            // 
            // button_Delete_right
            // 
            this.button_Delete_right.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete_right.Location = new System.Drawing.Point(549, 315);
            this.button_Delete_right.Name = "button_Delete_right";
            this.button_Delete_right.Size = new System.Drawing.Size(120, 45);
            this.button_Delete_right.TabIndex = 5;
            this.button_Delete_right.Text = "Удалить";
            this.button_Delete_right.UseVisualStyleBackColor = true;
            this.button_Delete_right.Click += new System.EventHandler(this.button_Delete_right_Click);
            // 
            // button_re
            // 
            this.button_re.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_re.Location = new System.Drawing.Point(906, 315);
            this.button_re.Name = "button_re";
            this.button_re.Size = new System.Drawing.Size(134, 45);
            this.button_re.TabIndex = 6;
            this.button_re.Text = "Вернуть";
            this.button_re.UseVisualStyleBackColor = true;
            this.button_re.Click += new System.EventHandler(this.button_re_Click);
            // 
            // button_tp
            // 
            this.button_tp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tp.Location = new System.Drawing.Point(324, 315);
            this.button_tp.Name = "button_tp";
            this.button_tp.Size = new System.Drawing.Size(181, 45);
            this.button_tp.TabIndex = 7;
            this.button_tp.Text = "Переместить";
            this.button_tp.UseVisualStyleBackColor = true;
            this.button_tp.Click += new System.EventHandler(this.button_tp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 398);
            this.Controls.Add(this.button_tp);
            this.Controls.Add(this.button_re);
            this.Controls.Add(this.button_Delete_right);
            this.Controls.Add(this.button_Delete_left);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listBox_right);
            this.Controls.Add(this.listBox_left);
            this.Controls.Add(this.textBox_path);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "FilePathTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.ListBox listBox_left;
        private System.Windows.Forms.ListBox listBox_right;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete_left;
        private System.Windows.Forms.Button button_Delete_right;
        private System.Windows.Forms.Button button_re;
        private System.Windows.Forms.Button button_tp;
    }
}

