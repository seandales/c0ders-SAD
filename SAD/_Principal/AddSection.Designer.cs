﻿namespace WindowsFormsApp4
{
    partial class AddSection
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
            this.btnAddSection = new System.Windows.Forms.Button();
            this.btnSectionCancel = new System.Windows.Forms.Button();
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboGradeLevelSection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSupervisor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddSection
            // 
            this.btnAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(220)))), ((int)(((byte)(129)))));
            this.btnAddSection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(1)))));
            this.btnAddSection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(65)))));
            this.btnAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSection.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSection.ImageKey = "(none)";
            this.btnAddSection.Location = new System.Drawing.Point(331, 290);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddSection.Size = new System.Drawing.Size(100, 34);
            this.btnAddSection.TabIndex = 75;
            this.btnAddSection.Text = "Add";
            this.btnAddSection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddSection.UseVisualStyleBackColor = false;
            // 
            // btnSectionCancel
            // 
            this.btnSectionCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(92)))), ((int)(((byte)(76)))));
            this.btnSectionCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(12)))));
            this.btnSectionCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(60)))), ((int)(((byte)(44)))));
            this.btnSectionCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSectionCancel.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionCancel.ImageKey = "(none)";
            this.btnSectionCancel.Location = new System.Drawing.Point(225, 290);
            this.btnSectionCancel.Name = "btnSectionCancel";
            this.btnSectionCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSectionCancel.Size = new System.Drawing.Size(100, 34);
            this.btnSectionCancel.TabIndex = 74;
            this.btnSectionCancel.Text = "Cancel";
            this.btnSectionCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSectionCancel.UseVisualStyleBackColor = false;
            // 
            // txtSectionName
            // 
            this.txtSectionName.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSectionName.Location = new System.Drawing.Point(64, 69);
            this.txtSectionName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(367, 25);
            this.txtSectionName.TabIndex = 63;
            this.txtSectionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Grade Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Section Name:";
            // 
            // comboGradeLevelSection
            // 
            this.comboGradeLevelSection.FormattingEnabled = true;
            this.comboGradeLevelSection.Location = new System.Drawing.Point(62, 205);
            this.comboGradeLevelSection.Name = "comboGradeLevelSection";
            this.comboGradeLevelSection.Size = new System.Drawing.Size(121, 21);
            this.comboGradeLevelSection.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Select Supervisor";
            // 
            // comboSupervisor
            // 
            this.comboSupervisor.FormattingEnabled = true;
            this.comboSupervisor.Location = new System.Drawing.Point(62, 143);
            this.comboSupervisor.Name = "comboSupervisor";
            this.comboSupervisor.Size = new System.Drawing.Size(121, 21);
            this.comboSupervisor.TabIndex = 76;
            // 
            // AddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.comboSupervisor);
            this.Controls.Add(this.comboGradeLevelSection);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.btnSectionCancel);
            this.Controls.Add(this.txtSectionName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "AddSection";
            this.Text = "AddSection";
            this.Load += new System.EventHandler(this.AddSection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Button btnSectionCancel;
        public System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboGradeLevelSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSupervisor;
    }
}