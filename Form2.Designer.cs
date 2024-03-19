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
            this.lblItemsInCollection = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnSaveAsCurrent = new System.Windows.Forms.Button();
            this.btnSaveAsNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCollectionName
            // 
            this.lblCollectionName.AutoSize = true;
            this.lblCollectionName.Location = new System.Drawing.Point(66, 57);
            this.lblCollectionName.Name = "lblCollectionName";
            this.lblCollectionName.Size = new System.Drawing.Size(109, 16);
            this.lblCollectionName.TabIndex = 0;
            this.lblCollectionName.Text = "Collection Name:";
            // 
            // txtCurrentCollection
            // 
            this.txtCurrentCollection.Location = new System.Drawing.Point(249, 54);
            this.txtCurrentCollection.Name = "txtCurrentCollection";
            this.txtCurrentCollection.Size = new System.Drawing.Size(196, 22);
            this.txtCurrentCollection.TabIndex = 1;
            // 
            // lblItemsInCollection
            // 
            this.lblItemsInCollection.AutoSize = true;
            this.lblItemsInCollection.Location = new System.Drawing.Point(66, 109);
            this.lblItemsInCollection.Name = "lblItemsInCollection";
            this.lblItemsInCollection.Size = new System.Drawing.Size(117, 16);
            this.lblItemsInCollection.TabIndex = 2;
            this.lblItemsInCollection.Text = "Items In Collection:";
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 16;
            this.lstItems.Location = new System.Drawing.Point(69, 141);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(647, 148);
            this.lstItems.TabIndex = 3;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(490, 57);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(45, 16);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "Value:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 5;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(73, 343);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(119, 23);
            this.btnAddNewItem.TabIndex = 6;
            this.btnAddNewItem.Text = "Add New Item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnSaveAsCurrent
            // 
            this.btnSaveAsCurrent.Location = new System.Drawing.Point(287, 343);
            this.btnSaveAsCurrent.Name = "btnSaveAsCurrent";
            this.btnSaveAsCurrent.Size = new System.Drawing.Size(132, 23);
            this.btnSaveAsCurrent.TabIndex = 7;
            this.btnSaveAsCurrent.Text = "Save As Current";
            this.btnSaveAsCurrent.UseVisualStyleBackColor = true;
            // 
            // btnSaveAsNew
            // 
            this.btnSaveAsNew.Location = new System.Drawing.Point(425, 343);
            this.btnSaveAsNew.Name = "btnSaveAsNew";
            this.btnSaveAsNew.Size = new System.Drawing.Size(119, 23);
            this.btnSaveAsNew.TabIndex = 8;
            this.btnSaveAsNew.Text = "Save As New";
            this.btnSaveAsNew.UseVisualStyleBackColor = true;
            this.btnSaveAsNew.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(641, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmViewCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveAsNew);
            this.Controls.Add(this.btnSaveAsCurrent);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.lblItemsInCollection);
            this.Controls.Add(this.txtCurrentCollection);
            this.Controls.Add(this.lblCollectionName);
            this.Name = "FrmViewCollection";
            this.Text = "View Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCollectionName;
        private System.Windows.Forms.TextBox txtCurrentCollection;
        private System.Windows.Forms.Label lblItemsInCollection;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnSaveAsCurrent;
        private System.Windows.Forms.Button btnSaveAsNew;
        private System.Windows.Forms.Button btnExit;
    }
}