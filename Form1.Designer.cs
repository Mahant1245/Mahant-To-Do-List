namespace To_Do_List
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddTextbox = new System.Windows.Forms.TextBox();
            this.RemoveTextbox = new System.Windows.Forms.TextBox();
            this.RemoveAllBtn = new System.Windows.Forms.Button();
            this.TodoListbox = new System.Windows.Forms.ListBox();
            this.CompletedItemListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(48, 87);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(613, 87);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 1;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddTextbox
            // 
            this.AddTextbox.Location = new System.Drawing.Point(38, 58);
            this.AddTextbox.Name = "AddTextbox";
            this.AddTextbox.Size = new System.Drawing.Size(100, 23);
            this.AddTextbox.TabIndex = 3;
            this.AddTextbox.TextChanged += new System.EventHandler(this.AddTextbox_TextChanged);
            // 
            // RemoveTextbox
            // 
            this.RemoveTextbox.Location = new System.Drawing.Point(598, 58);
            this.RemoveTextbox.Name = "RemoveTextbox";
            this.RemoveTextbox.Size = new System.Drawing.Size(100, 23);
            this.RemoveTextbox.TabIndex = 5;
            // 
            // RemoveAllBtn
            // 
            this.RemoveAllBtn.Location = new System.Drawing.Point(38, 376);
            this.RemoveAllBtn.Name = "RemoveAllBtn";
            this.RemoveAllBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveAllBtn.TabIndex = 6;
            this.RemoveAllBtn.Text = "Remove All";
            this.RemoveAllBtn.UseVisualStyleBackColor = true;
            this.RemoveAllBtn.Click += new System.EventHandler(this.RemoveAllBtn_Click);
            // 
            // TodoListbox
            // 
            this.TodoListbox.FormattingEnabled = true;
            this.TodoListbox.ItemHeight = 15;
            this.TodoListbox.Location = new System.Drawing.Point(210, 175);
            this.TodoListbox.Name = "TodoListbox";
            this.TodoListbox.Size = new System.Drawing.Size(175, 259);
            this.TodoListbox.TabIndex = 8;
            // 
            // CompletedItemListbox
            // 
            this.CompletedItemListbox.FormattingEnabled = true;
            this.CompletedItemListbox.ItemHeight = 15;
            this.CompletedItemListbox.Location = new System.Drawing.Point(407, 175);
            this.CompletedItemListbox.Name = "CompletedItemListbox";
            this.CompletedItemListbox.Size = new System.Drawing.Size(184, 259);
            this.CompletedItemListbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "enter the activity to add to the to-do list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter the activity that is completed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 45);
            this.label4.TabIndex = 13;
            this.label4.Text = "click \"Remove All\" if you have\r\ncompleted all activities listed \r\nin to-do list";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(689, 396);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 14;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "To Do List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Completed List";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(689, 425);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 17;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompletedItemListbox);
            this.Controls.Add(this.TodoListbox);
            this.Controls.Add(this.RemoveAllBtn);
            this.Controls.Add(this.RemoveTextbox);
            this.Controls.Add(this.AddTextbox);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.TextBox AddTextbox;
        private System.Windows.Forms.TextBox RemoveTextbox;
        private System.Windows.Forms.Button RemoveAllBtn;
        private System.Windows.Forms.ListBox TodoListbox;
        private System.Windows.Forms.ListBox CompletedItemListbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CloseBtn;
    }
}
