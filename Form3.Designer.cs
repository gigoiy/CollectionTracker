namespace ProjectAlexKadyn
{
    partial class frmAddNewItem
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
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDecription = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.ddCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(59, 27);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(140, 16);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model Name/Number:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(63, 58);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(424, 22);
            this.txtModel.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(59, 103);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(169, 16);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description (10 Word Limit):";
            // 
            // txtDecription
            // 
            this.txtDecription.Location = new System.Drawing.Point(63, 122);
            this.txtDecription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDecription.Multiline = true;
            this.txtDecription.Name = "txtDecription";
            this.txtDecription.Size = new System.Drawing.Size(501, 125);
            this.txtDecription.TabIndex = 3;
            this.txtDecription.TextChanged += new System.EventHandler(this.txtDecription_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(59, 278);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 16);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            // 
            // ddCategory
            // 
            this.ddCategory.FormattingEnabled = true;
            this.ddCategory.Location = new System.Drawing.Point(63, 297);
            this.ddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddCategory.Name = "ddCategory";
            this.ddCategory.Size = new System.Drawing.Size(341, 24);
            this.ddCategory.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 343);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(561, 343);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddNewItem
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ddCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtDecription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddNewItem";
            this.Text = "Add New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDecription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox ddCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
    }
}