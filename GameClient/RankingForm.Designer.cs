﻿namespace GameClient
{
    partial class RankingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingForm));
            this.dataGridViewRanking = new System.Windows.Forms.DataGridView();
            this.tabControlRanking = new System.Windows.Forms.TabControl();
            this.tabPageOffLineRanking = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).BeginInit();
            this.tabControlRanking.SuspendLayout();
            this.tabPageOffLineRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRanking
            // 
            this.dataGridViewRanking.AllowUserToAddRows = false;
            this.dataGridViewRanking.AllowUserToResizeColumns = false;
            this.dataGridViewRanking.AllowUserToResizeRows = false;
            this.dataGridViewRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRanking.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRanking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRanking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRanking.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRanking.GridColor = System.Drawing.Color.Black;
            this.dataGridViewRanking.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRanking.Name = "dataGridViewRanking";
            this.dataGridViewRanking.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRanking.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRanking.RowHeadersVisible = false;
            this.dataGridViewRanking.RowHeadersWidth = 51;
            this.dataGridViewRanking.RowTemplate.Height = 27;
            this.dataGridViewRanking.Size = new System.Drawing.Size(468, 303);
            this.dataGridViewRanking.TabIndex = 0;
            // 
            // tabControlRanking
            // 
            this.tabControlRanking.Controls.Add(this.tabPageOffLineRanking);
            this.tabControlRanking.Controls.Add(this.tabPage2);
            this.tabControlRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRanking.Location = new System.Drawing.Point(0, 0);
            this.tabControlRanking.Name = "tabControlRanking";
            this.tabControlRanking.SelectedIndex = 0;
            this.tabControlRanking.Size = new System.Drawing.Size(482, 342);
            this.tabControlRanking.TabIndex = 1;
            // 
            // tabPageOffLineRanking
            // 
            this.tabPageOffLineRanking.Controls.Add(this.dataGridViewRanking);
            this.tabPageOffLineRanking.Location = new System.Drawing.Point(4, 29);
            this.tabPageOffLineRanking.Name = "tabPageOffLineRanking";
            this.tabPageOffLineRanking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOffLineRanking.Size = new System.Drawing.Size(474, 309);
            this.tabPageOffLineRanking.TabIndex = 0;
            this.tabPageOffLineRanking.Text = "离线排行榜";
            this.tabPageOffLineRanking.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "在线排行榜";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 342);
            this.Controls.Add(this.tabControlRanking);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "RankingForm";
            this.Text = "高分榜";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).EndInit();
            this.tabControlRanking.ResumeLayout(false);
            this.tabPageOffLineRanking.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRanking;
        private System.Windows.Forms.TabControl tabControlRanking;
        private System.Windows.Forms.TabPage tabPageOffLineRanking;
        private System.Windows.Forms.TabPage tabPage2;
    }
}