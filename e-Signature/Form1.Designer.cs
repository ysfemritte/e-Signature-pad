
namespace e_Signature
{
    partial class Form1
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
            this.SignaturePanel = new System.Windows.Forms.Panel();
            this.SavePNG = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SignatureDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SignatureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SignaturePanel
            // 
            this.SignaturePanel.BackColor = System.Drawing.Color.White;
            this.SignaturePanel.Location = new System.Drawing.Point(26, 30);
            this.SignaturePanel.Name = "SignaturePanel";
            this.SignaturePanel.Size = new System.Drawing.Size(631, 200);
            this.SignaturePanel.TabIndex = 0;
            this.SignaturePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SignaturePanel_Paint);
            this.SignaturePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignaturePanel_MouseDown);
            this.SignaturePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SignaturePanel_MouseMove);
            // 
            // SavePNG
            // 
            this.SavePNG.Location = new System.Drawing.Point(674, 30);
            this.SavePNG.Name = "SavePNG";
            this.SavePNG.Size = new System.Drawing.Size(103, 53);
            this.SavePNG.TabIndex = 1;
            this.SavePNG.Text = "Save As PNG";
            this.SavePNG.UseVisualStyleBackColor = true;
            this.SavePNG.Click += new System.EventHandler(this.SavePNG_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(674, 106);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(103, 53);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(674, 177);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(103, 53);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SignatureDataGridView
            // 
            this.SignatureDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SignatureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SignatureDataGridView.Location = new System.Drawing.Point(26, 236);
            this.SignatureDataGridView.Name = "SignatureDataGridView";
            this.SignatureDataGridView.RowHeadersWidth = 51;
            this.SignatureDataGridView.RowTemplate.Height = 24;
            this.SignatureDataGridView.Size = new System.Drawing.Size(323, 202);
            this.SignatureDataGridView.TabIndex = 4;
            this.SignatureDataGridView.DoubleClick += new System.EventHandler(this.SignatureDataGridView_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignatureDataGridView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SavePNG);
            this.Controls.Add(this.SignaturePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SignatureDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SignaturePanel;
        private System.Windows.Forms.Button SavePNG;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView SignatureDataGridView;
    }
}

