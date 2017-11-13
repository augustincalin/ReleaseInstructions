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
            System.Windows.Forms.Label nameLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpConfigurationGeneral = new System.Windows.Forms.TabPage();
            this.serversDataGridView = new System.Windows.Forms.DataGridView();
            this.serversBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.releaseTasksDataGridView = new System.Windows.Forms.DataGridView();
            this.releaseTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.environmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.environmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.componentsDataGridView = new System.Windows.Forms.DataGridView();
            this.componentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.tpConfigurationRelationships = new System.Windows.Forms.TabPage();
            this.tpReleaseTasks = new System.Windows.Forms.TabPage();
            this.btLoadUniverse = new System.Windows.Forms.Button();
            this.btSaveUniverse = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpConfigurationGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseTasksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(16, 16);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(70, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpConfigurationGeneral);
            this.tabControl1.Controls.Add(this.tpConfigurationRelationships);
            this.tabControl1.Controls.Add(this.tpReleaseTasks);
            this.tabControl1.Location = new System.Drawing.Point(13, 93);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2015, 1119);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpConfigurationGeneral
            // 
            this.tpConfigurationGeneral.AutoScroll = true;
            this.tpConfigurationGeneral.Controls.Add(this.serversDataGridView);
            this.tpConfigurationGeneral.Controls.Add(this.releaseTasksDataGridView);
            this.tpConfigurationGeneral.Controls.Add(this.environmentsDataGridView);
            this.tpConfigurationGeneral.Controls.Add(this.label4);
            this.tpConfigurationGeneral.Controls.Add(this.label3);
            this.tpConfigurationGeneral.Controls.Add(this.label2);
            this.tpConfigurationGeneral.Controls.Add(this.label1);
            this.tpConfigurationGeneral.Controls.Add(this.componentsDataGridView);
            this.tpConfigurationGeneral.Controls.Add(nameLabel);
            this.tpConfigurationGeneral.Controls.Add(this.nameTextBox);
            this.tpConfigurationGeneral.Location = new System.Drawing.Point(4, 33);
            this.tpConfigurationGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.tpConfigurationGeneral.Name = "tpConfigurationGeneral";
            this.tpConfigurationGeneral.Padding = new System.Windows.Forms.Padding(4);
            this.tpConfigurationGeneral.Size = new System.Drawing.Size(2007, 1082);
            this.tpConfigurationGeneral.TabIndex = 0;
            this.tpConfigurationGeneral.Text = "Configuration: General";
            this.tpConfigurationGeneral.UseVisualStyleBackColor = true;
            // 
            // serversDataGridView
            // 
            this.serversDataGridView.AutoGenerateColumns = false;
            this.serversDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serversDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.serversDataGridView.DataSource = this.serversBindingSource1;
            this.serversDataGridView.Location = new System.Drawing.Point(1056, 401);
            this.serversDataGridView.Name = "serversDataGridView";
            this.serversDataGridView.RowTemplate.Height = 31;
            this.serversDataGridView.Size = new System.Drawing.Size(716, 220);
            this.serversDataGridView.TabIndex = 10;
            // 
            // serversBindingSource1
            // 
            this.serversBindingSource1.DataMember = "Servers";
            this.serversBindingSource1.DataSource = this.universeBindingSource;
            // 
            // releaseTasksDataGridView
            // 
            this.releaseTasksDataGridView.AutoGenerateColumns = false;
            this.releaseTasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.releaseTasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.releaseTasksDataGridView.DataSource = this.releaseTasksBindingSource;
            this.releaseTasksDataGridView.Location = new System.Drawing.Point(1047, 96);
            this.releaseTasksDataGridView.Name = "releaseTasksDataGridView";
            this.releaseTasksDataGridView.RowTemplate.Height = 31;
            this.releaseTasksDataGridView.Size = new System.Drawing.Size(730, 220);
            this.releaseTasksDataGridView.TabIndex = 10;
            // 
            // releaseTasksBindingSource
            // 
            this.releaseTasksBindingSource.DataMember = "ReleaseTasks";
            this.releaseTasksBindingSource.DataSource = this.universeBindingSource;
            // 
            // environmentsDataGridView
            // 
            this.environmentsDataGridView.AutoGenerateColumns = false;
            this.environmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.environmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.environmentsDataGridView.DataSource = this.environmentsBindingSource;
            this.environmentsDataGridView.Location = new System.Drawing.Point(21, 401);
            this.environmentsDataGridView.Name = "environmentsDataGridView";
            this.environmentsDataGridView.RowTemplate.Height = 31;
            this.environmentsDataGridView.Size = new System.Drawing.Size(802, 220);
            this.environmentsDataGridView.TabIndex = 8;
            // 
            // environmentsBindingSource
            // 
            this.environmentsBindingSource.DataMember = "Environments";
            this.environmentsBindingSource.DataSource = this.universeBindingSource;
            // 
            // label4
            // 
            this.label4.Image = global::ReleaseInstructions.Properties.Resources.server;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(1042, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 48);
            this.label4.TabIndex = 6;
            this.label4.Text = "Servers";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Image = global::ReleaseInstructions.Properties.Resources.release_task;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(1042, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Release Tasks";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Image = global::ReleaseInstructions.Properties.Resources.environment;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(16, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Environments";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Image = global::ReleaseInstructions.Properties.Resources.component;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Components";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // componentsDataGridView
            // 
            this.componentsDataGridView.AutoGenerateColumns = false;
            this.componentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.componentsDataGridView.DataSource = this.componentsBindingSource;
            this.componentsDataGridView.Location = new System.Drawing.Point(21, 96);
            this.componentsDataGridView.Name = "componentsDataGridView";
            this.componentsDataGridView.RowTemplate.Height = 31;
            this.componentsDataGridView.Size = new System.Drawing.Size(802, 220);
            this.componentsDataGridView.TabIndex = 2;
            // 
            // componentsBindingSource
            // 
            this.componentsBindingSource.DataMember = "Components";
            this.componentsBindingSource.DataSource = this.universeBindingSource;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.universeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(92, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(354, 29);
            this.nameTextBox.TabIndex = 1;
            // 
            // tpConfigurationRelationships
            // 
            this.tpConfigurationRelationships.AutoScroll = true;
            this.tpConfigurationRelationships.AutoScrollMargin = new System.Drawing.Size(30, 30);
            this.tpConfigurationRelationships.AutoScrollMinSize = new System.Drawing.Size(30, 30);
            this.tpConfigurationRelationships.Location = new System.Drawing.Point(4, 33);
            this.tpConfigurationRelationships.Name = "tpConfigurationRelationships";
            this.tpConfigurationRelationships.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfigurationRelationships.Size = new System.Drawing.Size(2007, 1082);
            this.tpConfigurationRelationships.TabIndex = 2;
            this.tpConfigurationRelationships.Text = "Configuration: Relationships";
            this.tpConfigurationRelationships.UseVisualStyleBackColor = true;
            this.tpConfigurationRelationships.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tpConfigurationRelationships_MouseMove);
            // 
            // tpReleaseTasks
            // 
            this.tpReleaseTasks.Location = new System.Drawing.Point(4, 33);
            this.tpReleaseTasks.Margin = new System.Windows.Forms.Padding(4);
            this.tpReleaseTasks.Name = "tpReleaseTasks";
            this.tpReleaseTasks.Padding = new System.Windows.Forms.Padding(4);
            this.tpReleaseTasks.Size = new System.Drawing.Size(2007, 1082);
            this.tpReleaseTasks.TabIndex = 1;
            this.tpReleaseTasks.Text = "Release Tasks";
            this.tpReleaseTasks.UseVisualStyleBackColor = true;
            // 
            // btLoadUniverse
            // 
            this.btLoadUniverse.Location = new System.Drawing.Point(12, 24);
            this.btLoadUniverse.Name = "btLoadUniverse";
            this.btLoadUniverse.Size = new System.Drawing.Size(217, 46);
            this.btLoadUniverse.TabIndex = 13;
            this.btLoadUniverse.Text = "Load Configuration";
            this.btLoadUniverse.UseVisualStyleBackColor = true;
            this.btLoadUniverse.Click += new System.EventHandler(this.btLoadUniverse_Click);
            // 
            // btSaveUniverse
            // 
            this.btSaveUniverse.Location = new System.Drawing.Point(236, 24);
            this.btSaveUniverse.Margin = new System.Windows.Forms.Padding(4);
            this.btSaveUniverse.Name = "btSaveUniverse";
            this.btSaveUniverse.Size = new System.Drawing.Size(227, 46);
            this.btSaveUniverse.TabIndex = 8;
            this.btSaveUniverse.Text = "Save Configuration";
            this.btSaveUniverse.UseVisualStyleBackColor = true;
            this.btSaveUniverse.Click += new System.EventHandler(this.btSaveUniverse_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn8.HeaderText = "Role";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn9.HeaderText = "Description";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ParentEnvironment";
            this.dataGridViewTextBoxColumn10.HeaderText = "ParentEnvironment";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // universeBindingSource
            // 
            this.universeBindingSource.DataSource = typeof(ReleaseInstructions.Model.Universe);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn11.HeaderText = "Id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn12.HeaderText = "Title";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "RazorTemplate";
            this.dataGridViewTextBoxColumn13.HeaderText = "RazorTemplate";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 600;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Abbreviation";
            this.dataGridViewTextBoxColumn5.HeaderText = "Abbreviation";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2041, 1225);
            this.Controls.Add(this.btLoadUniverse);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btSaveUniverse);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpConfigurationGeneral.ResumeLayout(false);
            this.tpConfigurationGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseTasksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpConfigurationGeneral;
        private System.Windows.Forms.TabPage tpReleaseTasks;
        private System.Windows.Forms.Button btSaveUniverse;
        private System.Windows.Forms.Button btLoadUniverse;
        private System.Windows.Forms.TabPage tpConfigurationRelationships;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource universeBindingSource;
        private System.Windows.Forms.DataGridView environmentsDataGridView;
        private System.Windows.Forms.BindingSource environmentsBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView componentsDataGridView;
        private System.Windows.Forms.BindingSource componentsBindingSource;
        private System.Windows.Forms.DataGridView releaseTasksDataGridView;
        private System.Windows.Forms.BindingSource releaseTasksBindingSource;
        private System.Windows.Forms.BindingSource serversBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView serversDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}

