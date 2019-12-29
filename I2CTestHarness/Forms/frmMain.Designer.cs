﻿namespace I2CTestHarness
{
    partial class frmMain
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
            this.btnGetTime = new System.Windows.Forms.Button();
            this.pnlLogs = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaster = new System.Windows.Forms.TextBox();
            this.txtSlave = new System.Windows.Forms.TextBox();
            this.pnlLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetTime
            // 
            this.btnGetTime.Location = new System.Drawing.Point(12, 12);
            this.btnGetTime.Name = "btnGetTime";
            this.btnGetTime.Size = new System.Drawing.Size(75, 23);
            this.btnGetTime.TabIndex = 0;
            this.btnGetTime.Text = "Get Time";
            this.btnGetTime.UseVisualStyleBackColor = true;
            this.btnGetTime.Click += new System.EventHandler(this.btnGetTime_Click);
            // 
            // pnlLogs
            // 
            this.pnlLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogs.ColumnCount = 2;
            this.pnlLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLogs.Controls.Add(this.txtMaster, 0, 0);
            this.pnlLogs.Controls.Add(this.txtSlave, 1, 0);
            this.pnlLogs.Location = new System.Drawing.Point(12, 41);
            this.pnlLogs.Name = "pnlLogs";
            this.pnlLogs.RowCount = 1;
            this.pnlLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLogs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlLogs.Size = new System.Drawing.Size(885, 265);
            this.pnlLogs.TabIndex = 1;
            // 
            // txtMaster
            // 
            this.txtMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaster.Location = new System.Drawing.Point(3, 3);
            this.txtMaster.Multiline = true;
            this.txtMaster.Name = "txtMaster";
            this.txtMaster.ReadOnly = true;
            this.txtMaster.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMaster.Size = new System.Drawing.Size(436, 259);
            this.txtMaster.TabIndex = 0;
            // 
            // txtSlave
            // 
            this.txtSlave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSlave.Location = new System.Drawing.Point(445, 3);
            this.txtSlave.Multiline = true;
            this.txtSlave.Name = "txtSlave";
            this.txtSlave.ReadOnly = true;
            this.txtSlave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSlave.Size = new System.Drawing.Size(437, 259);
            this.txtSlave.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 318);
            this.Controls.Add(this.pnlLogs);
            this.Controls.Add(this.btnGetTime);
            this.Name = "frmMain";
            this.Text = "I2C Test Harness";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlLogs.ResumeLayout(false);
            this.pnlLogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetTime;
        private System.Windows.Forms.TableLayoutPanel pnlLogs;
        private System.Windows.Forms.TextBox txtMaster;
        private System.Windows.Forms.TextBox txtSlave;
    }
}

