namespace ReleaseInstructions {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cMNumberLabel;
            System.Windows.Forms.Label releaseDatePRODLabel;
            System.Windows.Forms.Label releaseDateUATLabel;
            System.Windows.Forms.Label releaseFolderLabel;
            System.Windows.Forms.Label releaseManagerLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cMNumberTextBox = new System.Windows.Forms.TextBox();
            this.releaseDatePRODDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.releaseDateUATDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.releaseFolderTextBox = new System.Windows.Forms.TextBox();
            this.releaseManagerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tasksDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.serversDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serversBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.environmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.releaseTasksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.environmentsComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.btSaveUniverse = new System.Windows.Forms.Button();
            this.tpReleaseTasks = new System.Windows.Forms.TabPage();
            this.serversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.environmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            cMNumberLabel = new System.Windows.Forms.Label();
            releaseDatePRODLabel = new System.Windows.Forms.Label();
            releaseDateUATLabel = new System.Windows.Forms.Label();
            releaseFolderLabel = new System.Windows.Forms.Label();
            releaseManagerLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseTasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cMNumberLabel
            // 
            cMNumberLabel.AutoSize = true;
            cMNumberLabel.Location = new System.Drawing.Point(7, 31);
            cMNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cMNumberLabel.Name = "cMNumberLabel";
            cMNumberLabel.Size = new System.Drawing.Size(63, 13);
            cMNumberLabel.TabIndex = 1;
            cMNumberLabel.Text = "CMNumber:";
            // 
            // releaseDatePRODLabel
            // 
            releaseDatePRODLabel.AutoSize = true;
            releaseDatePRODLabel.Location = new System.Drawing.Point(7, 50);
            releaseDatePRODLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            releaseDatePRODLabel.Name = "releaseDatePRODLabel";
            releaseDatePRODLabel.Size = new System.Drawing.Size(109, 13);
            releaseDatePRODLabel.TabIndex = 3;
            releaseDatePRODLabel.Text = "Release Date PROD:";
            // 
            // releaseDateUATLabel
            // 
            releaseDateUATLabel.AutoSize = true;
            releaseDateUATLabel.Location = new System.Drawing.Point(7, 69);
            releaseDateUATLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            releaseDateUATLabel.Name = "releaseDateUATLabel";
            releaseDateUATLabel.Size = new System.Drawing.Size(100, 13);
            releaseDateUATLabel.TabIndex = 5;
            releaseDateUATLabel.Text = "Release Date UAT:";
            // 
            // releaseFolderLabel
            // 
            releaseFolderLabel.AutoSize = true;
            releaseFolderLabel.Location = new System.Drawing.Point(7, 88);
            releaseFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            releaseFolderLabel.Name = "releaseFolderLabel";
            releaseFolderLabel.Size = new System.Drawing.Size(81, 13);
            releaseFolderLabel.TabIndex = 7;
            releaseFolderLabel.Text = "Release Folder:";
            // 
            // releaseManagerLabel
            // 
            releaseManagerLabel.AutoSize = true;
            releaseManagerLabel.Location = new System.Drawing.Point(7, 107);
            releaseManagerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            releaseManagerLabel.Name = "releaseManagerLabel";
            releaseManagerLabel.Size = new System.Drawing.Size(94, 13);
            releaseManagerLabel.TabIndex = 9;
            releaseManagerLabel.Text = "Release Manager:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(5, 13);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // cMNumberTextBox
            // 
            this.cMNumberTextBox.Location = new System.Drawing.Point(117, 29);
            this.cMNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cMNumberTextBox.Name = "cMNumberTextBox";
            this.cMNumberTextBox.Size = new System.Drawing.Size(111, 20);
            this.cMNumberTextBox.TabIndex = 2;
            // 
            // releaseDatePRODDateTimePicker
            // 
            this.releaseDatePRODDateTimePicker.Location = new System.Drawing.Point(117, 48);
            this.releaseDatePRODDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.releaseDatePRODDateTimePicker.Name = "releaseDatePRODDateTimePicker";
            this.releaseDatePRODDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.releaseDatePRODDateTimePicker.TabIndex = 4;
            // 
            // releaseDateUATDateTimePicker
            // 
            this.releaseDateUATDateTimePicker.Location = new System.Drawing.Point(117, 67);
            this.releaseDateUATDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.releaseDateUATDateTimePicker.Name = "releaseDateUATDateTimePicker";
            this.releaseDateUATDateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.releaseDateUATDateTimePicker.TabIndex = 6;
            // 
            // releaseFolderTextBox
            // 
            this.releaseFolderTextBox.Location = new System.Drawing.Point(117, 86);
            this.releaseFolderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.releaseFolderTextBox.Name = "releaseFolderTextBox";
            this.releaseFolderTextBox.Size = new System.Drawing.Size(111, 20);
            this.releaseFolderTextBox.TabIndex = 8;
            // 
            // releaseManagerTextBox
            // 
            this.releaseManagerTextBox.Location = new System.Drawing.Point(117, 105);
            this.releaseManagerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.releaseManagerTextBox.Name = "releaseManagerTextBox";
            this.releaseManagerTextBox.Size = new System.Drawing.Size(111, 20);
            this.releaseManagerTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReleaseInstructions.Properties.Resources.server;
            this.pictureBox1.Location = new System.Drawing.Point(660, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.Location = new System.Drawing.Point(205, 161);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.DragEnter += new System.Windows.Forms.DragEventHandler(this.button2_DragEnter);
            this.button2.DragOver += new System.Windows.Forms.DragEventHandler(this.button2_DragOver);
            // 
            // tasksDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tasksDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tasksDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tasksDataGridView.Location = new System.Drawing.Point(261, 22);
            this.tasksDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.tasksDataGridView.Name = "tasksDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tasksDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tasksDataGridView.RowTemplate.Height = 31;
            this.tasksDataGridView.Size = new System.Drawing.Size(310, 119);
            this.tasksDataGridView.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpConfiguration);
            this.tabControl1.Controls.Add(this.tpReleaseTasks);
            this.tabControl1.Location = new System.Drawing.Point(7, 218);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(849, 337);
            this.tabControl1.TabIndex = 16;
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.AutoScroll = true;
            this.tpConfiguration.Controls.Add(this.serversDataGridView);
            this.tpConfiguration.Controls.Add(this.releaseTasksDataGridView);
            this.tpConfiguration.Controls.Add(this.environmentsComboBox);
            this.tpConfiguration.Controls.Add(nameLabel);
            this.tpConfiguration.Controls.Add(this.nameTextBox);
            this.tpConfiguration.Controls.Add(this.btSaveUniverse);
            this.tpConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tpConfiguration.Margin = new System.Windows.Forms.Padding(2);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(2);
            this.tpConfiguration.Size = new System.Drawing.Size(841, 311);
            this.tpConfiguration.TabIndex = 0;
            this.tpConfiguration.Text = "Configuration";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // serversDataGridView
            // 
            this.serversDataGridView.AutoGenerateColumns = false;
            this.serversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.serversDataGridView.DataSource = this.serversBindingSource1;
            this.serversDataGridView.Location = new System.Drawing.Point(8, 63);
            this.serversDataGridView.Name = "serversDataGridView";
            this.serversDataGridView.Size = new System.Drawing.Size(339, 220);
            this.serversDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn5.HeaderText = "Role";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Environment";
            this.dataGridViewTextBoxColumn7.HeaderText = "Environment";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // serversBindingSource1
            // 
            this.serversBindingSource1.DataMember = "Servers";
            this.serversBindingSource1.DataSource = this.environmentsBindingSource;
            // 
            // environmentsBindingSource
            // 
            this.environmentsBindingSource.DataMember = "Environments";
            this.environmentsBindingSource.DataSource = this.universeBindingSource;
            // 
            // universeBindingSource
            // 
            this.universeBindingSource.DataSource = typeof(ReleaseInstructions.Model.Universe);
            // 
            // releaseTasksDataGridView
            // 
            this.releaseTasksDataGridView.AutoGenerateColumns = false;
            this.releaseTasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.releaseTasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.releaseTasksDataGridView.DataSource = this.releaseTasksBindingSource;
            this.releaseTasksDataGridView.Location = new System.Drawing.Point(392, 13);
            this.releaseTasksDataGridView.Name = "releaseTasksDataGridView";
            this.releaseTasksDataGridView.Size = new System.Drawing.Size(437, 100);
            this.releaseTasksDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RazorTemplate";
            this.dataGridViewTextBoxColumn3.HeaderText = "RazorTemplate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // releaseTasksBindingSource
            // 
            this.releaseTasksBindingSource.DataMember = "ReleaseTasks";
            this.releaseTasksBindingSource.DataSource = this.universeBindingSource;
            // 
            // environmentsComboBox
            // 
            this.environmentsComboBox.DataSource = this.environmentsBindingSource;
            this.environmentsComboBox.DisplayMember = "Name";
            this.environmentsComboBox.FormattingEnabled = true;
            this.environmentsComboBox.Location = new System.Drawing.Point(8, 36);
            this.environmentsComboBox.Name = "environmentsComboBox";
            this.environmentsComboBox.Size = new System.Drawing.Size(141, 21);
            this.environmentsComboBox.TabIndex = 9;
            this.environmentsComboBox.ValueMember = "Abbreviation";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.universeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(49, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // btSaveUniverse
            // 
            this.btSaveUniverse.Location = new System.Drawing.Point(705, 277);
            this.btSaveUniverse.Margin = new System.Windows.Forms.Padding(2);
            this.btSaveUniverse.Name = "btSaveUniverse";
            this.btSaveUniverse.Size = new System.Drawing.Size(124, 25);
            this.btSaveUniverse.TabIndex = 8;
            this.btSaveUniverse.Text = "Save Configuration";
            this.btSaveUniverse.UseVisualStyleBackColor = true;
            this.btSaveUniverse.Click += new System.EventHandler(this.btSaveUniverse_Click);
            // 
            // tpReleaseTasks
            // 
            this.tpReleaseTasks.Location = new System.Drawing.Point(4, 22);
            this.tpReleaseTasks.Margin = new System.Windows.Forms.Padding(2);
            this.tpReleaseTasks.Name = "tpReleaseTasks";
            this.tpReleaseTasks.Padding = new System.Windows.Forms.Padding(2);
            this.tpReleaseTasks.Size = new System.Drawing.Size(841, 311);
            this.tpReleaseTasks.TabIndex = 1;
            this.tpReleaseTasks.Text = "Release Tasks";
            this.tpReleaseTasks.UseVisualStyleBackColor = true;
            // 
            // serversBindingSource
            // 
            this.serversBindingSource.DataSource = this.environmentsBindingSource1;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 571);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tasksDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(cMNumberLabel);
            this.Controls.Add(this.cMNumberTextBox);
            this.Controls.Add(releaseDatePRODLabel);
            this.Controls.Add(this.releaseDatePRODDateTimePicker);
            this.Controls.Add(releaseDateUATLabel);
            this.Controls.Add(this.releaseDateUATDateTimePicker);
            this.Controls.Add(releaseFolderLabel);
            this.Controls.Add(this.releaseFolderTextBox);
            this.Controls.Add(releaseManagerLabel);
            this.Controls.Add(this.releaseManagerTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpConfiguration.ResumeLayout(false);
            this.tpConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseTasksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cMNumberTextBox;
        private System.Windows.Forms.DateTimePicker releaseDatePRODDateTimePicker;
        private System.Windows.Forms.DateTimePicker releaseDateUATDateTimePicker;
        private System.Windows.Forms.TextBox releaseFolderTextBox;
        private System.Windows.Forms.TextBox releaseManagerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tasksDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.TabPage tpReleaseTasks;
        private System.Windows.Forms.BindingSource serversBindingSource;
        private System.Windows.Forms.BindingSource environmentsBindingSource1;
        private System.Windows.Forms.Button btSaveUniverse;
        private System.Windows.Forms.DataGridView serversDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource serversBindingSource1;
        private System.Windows.Forms.BindingSource environmentsBindingSource;
        private System.Windows.Forms.BindingSource universeBindingSource;
        private System.Windows.Forms.DataGridView releaseTasksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource releaseTasksBindingSource;
        private System.Windows.Forms.ComboBox environmentsComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}

