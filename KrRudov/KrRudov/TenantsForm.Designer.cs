namespace KrRudov
{
    partial class TenantsForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewTenants = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonDelete.FlatAppearance.BorderSize = 3;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(633, 323);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 44);
            this.buttonDelete.TabIndex = 28;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChange.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonChange.FlatAppearance.BorderSize = 3;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Location = new System.Drawing.Point(357, 323);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(119, 44);
            this.buttonChange.TabIndex = 27;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.FlatAppearance.BorderSize = 3;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(59, 323);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 44);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTenants
            // 
            this.dataGridViewTenants.AutoGenerateColumns = false;
            this.dataGridViewTenants.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.rentDataGridViewTextBoxColumn});
            this.dataGridViewTenants.DataSource = this.tenantsBindingSource;
            this.dataGridViewTenants.Location = new System.Drawing.Point(59, 65);
            this.dataGridViewTenants.Name = "dataGridViewTenants";
            this.dataGridViewTenants.Size = new System.Drawing.Size(693, 215);
            this.dataGridViewTenants.TabIndex = 25;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonBack.FlatAppearance.BorderSize = 3;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(3, 5);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 32);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(-2, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(807, 43);
            this.label3.TabIndex = 23;
            this.label3.Text = "Арендаторы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // rentDataGridViewTextBoxColumn
            // 
            this.rentDataGridViewTextBoxColumn.DataPropertyName = "Rent";
            this.rentDataGridViewTextBoxColumn.HeaderText = "Rent";
            this.rentDataGridViewTextBoxColumn.Name = "rentDataGridViewTextBoxColumn";
            // 
            // tenantsBindingSource
            // 
            this.tenantsBindingSource.DataSource = typeof(KrRudov.ModelEF.Tenants);
            // 
            // TenantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 404);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTenants);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label3);
            this.Name = "TenantsForm";
            this.Text = "TenantsForm";
            this.Load += new System.EventHandler(this.TenantsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewTenants;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tenantsBindingSource;
    }
}