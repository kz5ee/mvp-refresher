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
            closeForm = new Button();
            petTabList = new TabControl();
            petListTab = new TabPage();
            deletePet = new Button();
            editPet = new Button();
            addNewPet = new Button();
            searchPet = new Button();
            searchText = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            petDetailsTab = new TabPage();
            cancel = new Button();
            petColorText = new TextBox();
            label5 = new Label();
            petTypeText = new TextBox();
            label4 = new Label();
            petNameText = new TextBox();
            label3 = new Label();
            savePet = new Button();
            petIdText = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            petTabList.SuspendLayout();
            petListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            petDetailsTab.SuspendLayout();
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
            panel1.Controls.Add(closeForm);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 150);
            panel1.TabIndex = 1;
            // 
            // closeForm
            // 
            closeForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeForm.BackColor = Color.White;
            closeForm.Location = new Point(1521, 32);
            closeForm.Name = "closeForm";
            closeForm.Size = new Size(42, 34);
            closeForm.TabIndex = 1;
            closeForm.Text = "X";
            closeForm.UseVisualStyleBackColor = false;
            // 
            // petTabList
            // 
            petTabList.Controls.Add(petListTab);
            petTabList.Controls.Add(petDetailsTab);
            petTabList.Dock = DockStyle.Fill;
            petTabList.Location = new Point(0, 150);
            petTabList.Name = "petTabList";
            petTabList.SelectedIndex = 0;
            petTabList.Size = new Size(1575, 574);
            petTabList.TabIndex = 2;
            // 
            // petListTab
            // 
            petListTab.Controls.Add(deletePet);
            petListTab.Controls.Add(editPet);
            petListTab.Controls.Add(addNewPet);
            petListTab.Controls.Add(searchPet);
            petListTab.Controls.Add(searchText);
            petListTab.Controls.Add(label6);
            petListTab.Controls.Add(dataGridView1);
            petListTab.Location = new Point(4, 34);
            petListTab.Name = "petListTab";
            petListTab.Padding = new Padding(3);
            petListTab.Size = new Size(1567, 536);
            petListTab.TabIndex = 0;
            petListTab.Text = "Pet List";
            petListTab.UseVisualStyleBackColor = true;
            // 
            // deletePet
            // 
            deletePet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deletePet.Location = new Point(1302, 226);
            deletePet.Name = "deletePet";
            deletePet.Size = new Size(112, 34);
            deletePet.TabIndex = 16;
            deletePet.Text = "Delete";
            deletePet.UseVisualStyleBackColor = true;
            // 
            // editPet
            // 
            editPet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editPet.Location = new Point(1302, 176);
            editPet.Name = "editPet";
            editPet.Size = new Size(112, 34);
            editPet.TabIndex = 15;
            editPet.Text = "Edit";
            editPet.UseVisualStyleBackColor = true;
            // 
            // addNewPet
            // 
            addNewPet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addNewPet.Location = new Point(1302, 125);
            addNewPet.Name = "addNewPet";
            addNewPet.Size = new Size(112, 34);
            addNewPet.TabIndex = 14;
            addNewPet.Text = "Add New";
            addNewPet.UseVisualStyleBackColor = true;
            // 
            // searchPet
            // 
            searchPet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchPet.Location = new Point(1184, 65);
            searchPet.Name = "searchPet";
            searchPet.Size = new Size(112, 34);
            searchPet.TabIndex = 13;
            searchPet.Text = "Search";
            searchPet.UseVisualStyleBackColor = true;
            // 
            // searchText
            // 
            searchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1263, 403);
            dataGridView1.TabIndex = 0;
            // 
            // petDetailsTab
            // 
            petDetailsTab.Controls.Add(cancel);
            petDetailsTab.Controls.Add(petColorText);
            petDetailsTab.Controls.Add(label5);
            petDetailsTab.Controls.Add(petTypeText);
            petDetailsTab.Controls.Add(label4);
            petDetailsTab.Controls.Add(petNameText);
            petDetailsTab.Controls.Add(label3);
            petDetailsTab.Controls.Add(savePet);
            petDetailsTab.Controls.Add(petIdText);
            petDetailsTab.Controls.Add(label2);
            petDetailsTab.Location = new Point(4, 34);
            petDetailsTab.Name = "petDetailsTab";
            petDetailsTab.Padding = new Padding(3);
            petDetailsTab.Size = new Size(1567, 536);
            petDetailsTab.TabIndex = 1;
            petDetailsTab.Text = "Pet Details";
            petDetailsTab.UseVisualStyleBackColor = true;
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
            // savePet
            // 
            savePet.BackColor = Color.White;
            savePet.Location = new Point(53, 361);
            savePet.Name = "savePet";
            savePet.Size = new Size(158, 61);
            savePet.TabIndex = 12;
            savePet.Text = "Save";
            savePet.UseVisualStyleBackColor = false;
            // 
            // petIdText
            // 
            petIdText.Font = new Font("Segoe UI", 12F);
            petIdText.Location = new Point(53, 87);
            petIdText.Name = "petIdText";
            petIdText.ReadOnly = true;
            petIdText.Size = new Size(239, 39);
            petIdText.TabIndex = 11;
            petIdText.Text = "0";
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
            Controls.Add(petTabList);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "PetView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            petTabList.ResumeLayout(false);
            petListTab.ResumeLayout(false);
            petListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            petDetailsTab.ResumeLayout(false);
            petDetailsTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl petTabList;
        private TabPage petListTab;
        private TabPage petDetailsTab;
        private Button searchPet;
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
        private Button savePet;
        private TextBox petIdText;
        private Label label2;
        private Button deletePet;
        private Button editPet;
        private Button addNewPet;
        private Button closeForm;
    }
}