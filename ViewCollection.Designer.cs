namespace ProjectAlexKadyn
{
    partial class frmViewCollection
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
            lblCollectionName = new System.Windows.Forms.Label();
            txtCollectionName = new System.Windows.Forms.TextBox();
            lblTotalValue = new System.Windows.Forms.Label();
            txtTotalValue = new System.Windows.Forms.TextBox();
            btnAddNewItem = new System.Windows.Forms.Button();
            btnSaveAsCurrent = new System.Windows.Forms.Button();
            btnSaveAsNew = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            gridData = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
            SuspendLayout();
            // 
            // lblCollectionName
            // 
            lblCollectionName.AutoSize = true;
            lblCollectionName.Location = new System.Drawing.Point(91, 25);
            lblCollectionName.Name = "lblCollectionName";
            lblCollectionName.Size = new System.Drawing.Size(99, 15);
            lblCollectionName.TabIndex = 0;
            lblCollectionName.Text = "Collection Name:";
            // 
            // txtCollectionName
            // 
            txtCollectionName.Location = new System.Drawing.Point(94, 53);
            txtCollectionName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCollectionName.Name = "txtCollectionName";
            txtCollectionName.Size = new System.Drawing.Size(172, 23);
            txtCollectionName.TabIndex = 1;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new System.Drawing.Point(392, 25);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new System.Drawing.Size(137, 15);
            lblTotalValue.TabIndex = 4;
            lblTotalValue.Text = "Total Value of Collection:";
            // 
            // txtTotalValue
            // 
            txtTotalValue.Location = new System.Drawing.Point(396, 53);
            txtTotalValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTotalValue.Name = "txtTotalValue";
            txtTotalValue.ReadOnly = true;
            txtTotalValue.Size = new System.Drawing.Size(168, 23);
            txtTotalValue.TabIndex = 5;
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.Location = new System.Drawing.Point(64, 322);
            btnAddNewItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.Size = new System.Drawing.Size(104, 22);
            btnAddNewItem.TabIndex = 6;
            btnAddNewItem.Text = "Add New Item";
            btnAddNewItem.UseVisualStyleBackColor = true;
            btnAddNewItem.Click += btnAddNewItem_Click;
            // 
            // btnSaveAsCurrent
            // 
            btnSaveAsCurrent.Location = new System.Drawing.Point(251, 322);
            btnSaveAsCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSaveAsCurrent.Name = "btnSaveAsCurrent";
            btnSaveAsCurrent.Size = new System.Drawing.Size(116, 22);
            btnSaveAsCurrent.TabIndex = 7;
            btnSaveAsCurrent.Text = "Save As Current";
            btnSaveAsCurrent.UseVisualStyleBackColor = true;
            btnSaveAsCurrent.Click += btnSaveAsCurrent_Click;
            // 
            // btnSaveAsNew
            // 
            btnSaveAsNew.Location = new System.Drawing.Point(372, 322);
            btnSaveAsNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSaveAsNew.Name = "btnSaveAsNew";
            btnSaveAsNew.Size = new System.Drawing.Size(104, 22);
            btnSaveAsNew.TabIndex = 8;
            btnSaveAsNew.Text = "Save As New";
            btnSaveAsNew.UseVisualStyleBackColor = true;
            btnSaveAsNew.Click += btnSaveAsNew_Click;
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Location = new System.Drawing.Point(561, 322);
            btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(66, 22);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // gridData
            // 
            gridData.AllowUserToAddRows = false;
            gridData.AllowUserToDeleteRows = false;
            gridData.AllowUserToResizeColumns = false;
            gridData.AllowUserToResizeRows = false;
            gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2 });
            gridData.Location = new System.Drawing.Point(76, 104);
            gridData.Name = "gridData";
            gridData.RowTemplate.Height = 25;
            gridData.Size = new System.Drawing.Size(533, 193);
            gridData.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "Items";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Value";
            Column2.Name = "Column2";
            // 
            // frmViewCollection
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(700, 422);
            Controls.Add(gridData);
            Controls.Add(btnExit);
            Controls.Add(btnSaveAsNew);
            Controls.Add(btnSaveAsCurrent);
            Controls.Add(btnAddNewItem);
            Controls.Add(txtTotalValue);
            Controls.Add(lblTotalValue);
            Controls.Add(txtCollectionName);
            Controls.Add(lblCollectionName);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmViewCollection";
            Text = "View Collection";
            Activated += frmViewCollection_Load;
            ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCollectionName;
        private System.Windows.Forms.TextBox txtCollectionName;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.TextBox txtTotalValue;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnSaveAsCurrent;
        private System.Windows.Forms.Button btnSaveAsNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}