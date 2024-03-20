namespace ProjectAlexKadyn
{
    partial class FrmViewCollection
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
            this.lblCollectionName = new System.Windows.Forms.Label();
            this.txtCurrentCollection = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnSaveAsCurrent = new System.Windows.Forms.Button();
            this.btnSaveAsNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gridItems = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCollectionName
            // 
            this.lblCollectionName.AutoSize = true;
            this.lblCollectionName.Location = new System.Drawing.Point(78, 22);
            this.lblCollectionName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCollectionName.Name = "lblCollectionName";
            this.lblCollectionName.Size = new System.Drawing.Size(87, 13);
            this.lblCollectionName.TabIndex = 0;
            this.lblCollectionName.Text = "Collection Name:";
            // 
            // txtCurrentCollection
            // 
            this.txtCurrentCollection.Location = new System.Drawing.Point(81, 46);
            this.txtCurrentCollection.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentCollection.Name = "txtCurrentCollection";
            this.txtCurrentCollection.Size = new System.Drawing.Size(148, 20);
            this.txtCurrentCollection.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(55, 98);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(112, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model Name/Number:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(336, 22);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(125, 13);
            this.lblTotalValue.TabIndex = 4;
            this.lblTotalValue.Text = "Total Value of Collection:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(55, 279);
            this.btnAddNewItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(89, 19);
            this.btnAddNewItem.TabIndex = 6;
            this.btnAddNewItem.Text = "Add New Item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnSaveAsCurrent
            // 
            this.btnSaveAsCurrent.Location = new System.Drawing.Point(215, 279);
            this.btnSaveAsCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAsCurrent.Name = "btnSaveAsCurrent";
            this.btnSaveAsCurrent.Size = new System.Drawing.Size(99, 19);
            this.btnSaveAsCurrent.TabIndex = 7;
            this.btnSaveAsCurrent.Text = "Save As Current";
            this.btnSaveAsCurrent.UseVisualStyleBackColor = true;
            this.btnSaveAsCurrent.Click += new System.EventHandler(this.btnSaveAsCurrent_Click);
            // 
            // btnSaveAsNew
            // 
            this.btnSaveAsNew.Location = new System.Drawing.Point(319, 279);
            this.btnSaveAsNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveAsNew.Name = "btnSaveAsNew";
            this.btnSaveAsNew.Size = new System.Drawing.Size(89, 19);
            this.btnSaveAsNew.TabIndex = 8;
            this.btnSaveAsNew.Text = "Save As New";
            this.btnSaveAsNew.UseVisualStyleBackColor = true;
            this.btnSaveAsNew.Click += new System.EventHandler(this.btnSaveAsNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(481, 279);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 19);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gridItems
            // 
            this.gridItems.AutoScroll = true;
            this.gridItems.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.gridItems.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gridItems.ColumnCount = 3;
            this.gridItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.gridItems.Location = new System.Drawing.Point(53, 114);
            this.gridItems.Name = "gridItems";
            this.gridItems.RowCount = 6;
            this.gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.30769F));
            this.gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.69231F));
            this.gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.gridItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gridItems.Size = new System.Drawing.Size(499, 145);
            this.gridItems.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(279, 98);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description:";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(502, 98);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(37, 13);
            this.lblValue.TabIndex = 12;
            this.lblValue.Text = "Value:";
            // 
            // FrmViewCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveAsNew);
            this.Controls.Add(this.btnSaveAsCurrent);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtCurrentCollection);
            this.Controls.Add(this.lblCollectionName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmViewCollection";
            this.Text = "View Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCollectionName;
        private System.Windows.Forms.TextBox txtCurrentCollection;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnSaveAsCurrent;
        private System.Windows.Forms.Button btnSaveAsNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel gridItems;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblValue;
    }
}