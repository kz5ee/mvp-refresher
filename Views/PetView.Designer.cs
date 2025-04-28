namespace mvp_refresher.Views
{
    partial class PetView
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
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            searchText = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            cancel = new Button();
            petColorText = new TextBox();
            label5 = new Label();
            petTypeText = new TextBox();
            label4 = new Label();
            petNameText = new TextBox();
            label3 = new Label();
            save = new Button();
            petIdText = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(57, 47);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 0;
            label1.Text = "PETS";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 150);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 150);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1575, 574);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(searchText);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1567, 536);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pet List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1302, 226);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 16;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(1302, 176);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 15;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1302, 125);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 14;
            button4.Text = "Add New";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1184, 65);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            // 
            // searchText
            // 
            searchText.Location = new Point(33, 68);
            searchText.Name = "searchText";
            searchText.Size = new Size(1136, 31);
            searchText.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(33, 33);
            label6.Name = "label6";
            label6.Size = new Size(130, 32);
            label6.TabIndex = 11;
            label6.Text = "Search Pet:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1263, 403);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cancel);
            tabPage2.Controls.Add(petColorText);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(petTypeText);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(petNameText);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(save);
            tabPage2.Controls.Add(petIdText);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1567, 536);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pet Details";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.BackColor = Color.White;
            cancel.Location = new Point(234, 361);
            cancel.Name = "cancel";
            cancel.Size = new Size(158, 61);
            cancel.TabIndex = 19;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            // 
            // petColorText
            // 
            petColorText.Font = new Font("Segoe UI", 12F);
            petColorText.Location = new Point(53, 274);
            petColorText.Name = "petColorText";
            petColorText.Size = new Size(534, 39);
            petColorText.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(53, 239);
            label5.Name = "label5";
            label5.Size = new Size(107, 32);
            label5.TabIndex = 17;
            label5.Text = "Pet color";
            // 
            // petTypeText
            // 
            petTypeText.Font = new Font("Segoe UI", 12F);
            petTypeText.Location = new Point(348, 173);
            petTypeText.Name = "petTypeText";
            petTypeText.Size = new Size(239, 39);
            petTypeText.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(348, 138);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 15;
            label4.Text = "Pet type";
            // 
            // petNameText
            // 
            petNameText.Font = new Font("Segoe UI", 12F);
            petNameText.Location = new Point(53, 173);
            petNameText.Name = "petNameText";
            petNameText.Size = new Size(239, 39);
            petNameText.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(53, 138);
            label3.Name = "label3";
            label3.Size = new Size(114, 32);
            label3.TabIndex = 13;
            label3.Text = "Pet name";
            // 
            // save
            // 
            save.BackColor = Color.White;
            save.Location = new Point(53, 361);
            save.Name = "save";
            save.Size = new Size(158, 61);
            save.TabIndex = 12;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            // 
            // petIdText
            // 
            petIdText.Font = new Font("Segoe UI", 12F);
            petIdText.Location = new Point(53, 87);
            petIdText.Name = "petIdText";
            petIdText.Size = new Size(239, 39);
            petIdText.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(53, 52);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 10;
            label2.Text = "Pet ID";
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 724);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "PetView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button3;
        private TextBox searchText;
        private Label label6;
        private DataGridView dataGridView1;
        private Button cancel;
        private TextBox petColorText;
        private Label label5;
        private TextBox petTypeText;
        private Label label4;
        private TextBox petNameText;
        private Label label3;
        private Button save;
        private TextBox petIdText;
        private Label label2;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}