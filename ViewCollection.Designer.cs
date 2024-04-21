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
            lblModel = new System.Windows.Forms.Label();
            lblTotalValue = new System.Windows.Forms.Label();
            txtTotalValue = new System.Windows.Forms.TextBox();
            btnAddNewItem = new System.Windows.Forms.Button();
            btnSaveAsCurrent = new System.Windows.Forms.Button();
            btnSaveAsNew = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lblValue = new System.Windows.Forms.Label();
            gridItems = new System.Windows.Forms.TableLayoutPanel();
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
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new System.Drawing.Point(64, 113);
            lblModel.Name = "lblModel";
            lblModel.Size = new System.Drawing.Size(91, 15);
            lblModel.TabIndex = 2;
            lblModel.Text = "Collection Item:";
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
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new System.Drawing.Point(543, 112);
            lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblValue.Name = "lblValue";
            lblValue.Size = new System.Drawing.Size(38, 15);
            lblValue.TabIndex = 12;
            lblValue.Text = "Value:";
            // 
            // gridItems
            // 
            gridItems.AutoScroll = true;
            gridItems.BackColor = System.Drawing.Color.Transparent;
            gridItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            gridItems.ColumnCount = 2;
            gridItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.7883F));
            gridItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.2117043F));
            gridItems.ForeColor = System.Drawing.Color.Black;
            gridItems.Location = new System.Drawing.Point(62, 131);
            gridItems.Margin = new System.Windows.Forms.Padding(4);
            gridItems.Name = "gridItems";
            gridItems.RowCount = 6;
            gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.30769F));
            gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.69231F));
            gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            gridItems.Size = new System.Drawing.Size(582, 167);
            gridItems.TabIndex = 10;
            // 
            // frmViewCollection
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(700, 422);
            Controls.Add(lblValue);
            Controls.Add(gridItems);
            Controls.Add(btnExit);
            Controls.Add(btnSaveAsNew);
            Controls.Add(btnSaveAsCurrent);
            Controls.Add(btnAddNewItem);
            Controls.Add(txtTotalValue);
            Controls.Add(lblTotalValue);
            Controls.Add(lblModel);
            Controls.Add(txtCollectionName);
            Controls.Add(lblCollectionName);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmViewCollection";
            Text = "View Collection";
            Activated += frmViewCollection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCollectionName;
        private System.Windows.Forms.TextBox txtCollectionName;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.TextBox txtTotalValue;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnSaveAsCurrent;
        private System.Windows.Forms.Button btnSaveAsNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TableLayoutPanel gridItems;
    }
}