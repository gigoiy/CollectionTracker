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
            lblWelcome = new System.Windows.Forms.Label();
            lstCollections = new System.Windows.Forms.ListBox();
            lblCollections = new System.Windows.Forms.Label();
            btnView = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lblWarning = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new System.Drawing.Point(60, 57);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(245, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to our Collection Tracker! ";
            // 
            // lstCollections
            // 
            lstCollections.FormattingEnabled = true;
            lstCollections.ImeMode = System.Windows.Forms.ImeMode.On;
            lstCollections.ItemHeight = 20;
            lstCollections.Location = new System.Drawing.Point(63, 154);
            lstCollections.Name = "lstCollections";
            lstCollections.Size = new System.Drawing.Size(604, 244);
            lstCollections.TabIndex = 1;
            lstCollections.SelectedIndexChanged += lstCollections_SelectedIndexChanged;
            // 
            // lblCollections
            // 
            lblCollections.AutoSize = true;
            lblCollections.Location = new System.Drawing.Point(60, 117);
            lblCollections.Name = "lblCollections";
            lblCollections.Size = new System.Drawing.Size(85, 20);
            lblCollections.TabIndex = 2;
            lblCollections.Text = "Collections:";
            // 
            // btnView
            // 
            btnView.Location = new System.Drawing.Point(63, 457);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(75, 29);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(155, 457);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Location = new System.Drawing.Point(592, 457);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.ForeColor = System.Drawing.Color.Red;
            lblWarning.Location = new System.Drawing.Point(60, 520);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new System.Drawing.Size(347, 20);
            lblWarning.TabIndex = 7;
            lblWarning.Text = "Press \"Delete\" Again to remove selected Collection";
            lblWarning.Visible = false;
            // 
            // frmHome
            // 
            AcceptButton = btnView;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(800, 563);
            Controls.Add(lblWarning);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnView);
            Controls.Add(lblCollections);
            Controls.Add(lstCollections);
            Controls.Add(lblWelcome);
            ImeMode = System.Windows.Forms.ImeMode.On;
            Name = "frmHome";
            Text = "CollectionTracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblCollections;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.ListBox lstCollections;
        private System.Windows.Forms.Label lblWarning;
    }
}

