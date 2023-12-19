namespace KrRudov
{
    partial class MallForm
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
            this.dataGridViewMall = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coeffcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavilionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonDelete.FlatAppearance.BorderSize = 3;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(633, 295);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 53);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonChange.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonChange.FlatAppearance.BorderSize = 3;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Location = new System.Drawing.Point(348, 295);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(119, 53);
            this.buttonChange.TabIndex = 21;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonAdd.FlatAppearance.BorderSize = 3;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(59, 295);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 53);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridViewMall
            // 
            this.dataGridViewMall.AutoGenerateColumns = false;
            this.dataGridViewMall.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewMall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.amountPDataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.coeffcostDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.pavilionDataGridViewTextBoxColumn,
            this.rentDataGridViewTextBoxColumn});
            this.dataGridViewMall.DataSource = this.mallBindingSource;
            this.dataGridViewMall.Location = new System.Drawing.Point(59, 56);
            this.dataGridViewMall.Name = "dataGridViewMall";
            this.dataGridViewMall.Size = new System.Drawing.Size(693, 215);
            this.dataGridViewMall.TabIndex = 19;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonBack.FlatAppearance.BorderSize = 3;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(12, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 32);
            this.buttonBack.TabIndex = 18;
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
            this.label3.Location = new System.Drawing.Point(-1, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(810, 43);
            this.label3.TabIndex = 17;
            this.label3.Text = "Торговые центры";
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
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // amountPDataGridViewTextBoxColumn
            // 
            this.amountPDataGridViewTextBoxColumn.DataPropertyName = "Amount_P";
            this.amountPDataGridViewTextBoxColumn.HeaderText = "Amount_P";
            this.amountPDataGridViewTextBoxColumn.Name = "amountPDataGridViewTextBoxColumn";
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.DataPropertyName = "Town";
            this.townDataGridViewTextBoxColumn.HeaderText = "Town";
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // coeffcostDataGridViewTextBoxColumn
            // 
            this.coeffcostDataGridViewTextBoxColumn.DataPropertyName = "Coeff_cost";
            this.coeffcostDataGridViewTextBoxColumn.HeaderText = "Coeff_cost";
            this.coeffcostDataGridViewTextBoxColumn.Name = "coeffcostDataGridViewTextBoxColumn";
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // pavilionDataGridViewTextBoxColumn
            // 
            this.pavilionDataGridViewTextBoxColumn.DataPropertyName = "Pavilion";
            this.pavilionDataGridViewTextBoxColumn.HeaderText = "Pavilion";
            this.pavilionDataGridViewTextBoxColumn.Name = "pavilionDataGridViewTextBoxColumn";
            // 
            // rentDataGridViewTextBoxColumn
            // 
            this.rentDataGridViewTextBoxColumn.DataPropertyName = "Rent";
            this.rentDataGridViewTextBoxColumn.HeaderText = "Rent";
            this.rentDataGridViewTextBoxColumn.Name = "rentDataGridViewTextBoxColumn";
            // 
            // mallBindingSource
            // 
            this.mallBindingSource.DataSource = typeof(KrRudov.ModelEF.Mall);
            // 
            // MallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 395);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewMall);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label3);
            this.Name = "MallForm";
            this.Text = "MallForm";
            this.Load += new System.EventHandler(this.MallForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mallBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.DataGridView dataGridViewMall;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coeffcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavilionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mallBindingSource;
    }
}