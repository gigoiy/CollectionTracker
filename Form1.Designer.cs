namespace ProjectAlexKadyn
{
    partial class frmHome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lstCollections = new System.Windows.Forms.ListBox();
            this.lblCollections = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(60, 46);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(219, 16);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to our Collection Tracker! ";
            // 
            // lstCollections
            // 
            this.lstCollections.FormattingEnabled = true;
            this.lstCollections.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lstCollections.ItemHeight = 16;
            this.lstCollections.Items.AddRange(new object[] {
            "Add New Collection"});
            this.lstCollections.Location = new System.Drawing.Point(63, 123);
            this.lstCollections.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCollections.Name = "lstCollections";
            this.lstCollections.Size = new System.Drawing.Size(604, 196);
            this.lstCollections.TabIndex = 1;
            this.lstCollections.SelectedIndexChanged += new System.EventHandler(this.lstCollections_SelectedIndexChanged);
            // 
            // lblCollections
            // 
            this.lblCollections.AutoSize = true;
            this.lblCollections.Location = new System.Drawing.Point(60, 94);
            this.lblCollections.Name = "lblCollections";
            this.lblCollections.Size = new System.Drawing.Size(76, 16);
            this.lblCollections.TabIndex = 2;
            this.lblCollections.Text = "Collections:";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(63, 366);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(155, 366);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(592, 366);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHome
            // 
            this.AcceptButton = this.btnView;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblCollections);
            this.Controls.Add(this.lstCollections);
            this.Controls.Add(this.lblWelcome);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHome";
            this.Text = "CollectionTracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCollections;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.ListBox lstCollections;
    }
}

