namespace ScintillaNET_FindReplaceDialog_CN
{
    partial class IncrementalSearcher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFind = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.brnPrevious = new System.Windows.Forms.Button();
            this.btnHighlightAll = new System.Windows.Forms.Button();
            this.btnClearHighlights = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFind.Location = new System.Drawing.Point(0, 0);
            this.lblFind.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(37, 26);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "&����";
            this.lblFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(45, 1);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 1, 0, 0);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(179, 25);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lblFind);
            this.flowLayoutPanel1.Controls.Add(this.txtFind);
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Controls.Add(this.brnPrevious);
            this.flowLayoutPanel1.Controls.Add(this.btnHighlightAll);
            this.flowLayoutPanel1.Controls.Add(this.btnClearHighlights);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 26);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.BackgroundImage = global::ScintillaNET_FindReplaceDialog_CN.Properties.Resources.GoToNextMessage;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.Image = global::ScintillaNET_FindReplaceDialog_CN.Properties.Resources.GoToNextMessage;
            this.btnNext.Location = new System.Drawing.Point(228, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(22, 22);
            this.btnNext.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnNext, "��һ��");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // brnPrevious
            // 
            this.brnPrevious.AutoSize = true;
            this.brnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.brnPrevious.FlatAppearance.BorderSize = 0;
            this.brnPrevious.Image = global::ScintillaNET_FindReplaceDialog_CN.Properties.Resources.GoToPreviousMessage;
            this.brnPrevious.Location = new System.Drawing.Point(250, 0);
            this.brnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.brnPrevious.Name = "brnPrevious";
            this.brnPrevious.Size = new System.Drawing.Size(22, 22);
            this.brnPrevious.TabIndex = 3;
            this.toolTip.SetToolTip(this.brnPrevious, "��һ��");
            this.brnPrevious.UseVisualStyleBackColor = true;
            this.brnPrevious.Click += new System.EventHandler(this.brnPrevious_Click);
            // 
            // btnHighlightAll
            // 
            this.btnHighlightAll.AutoSize = true;
            this.btnHighlightAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHighlightAll.BackgroundImage = global::ScintillaNET_FindReplaceDialog_CN.Properties.Resources.LineColorHS;
            this.btnHighlightAll.FlatAppearance.BorderSize = 0;
            this.btnHighlightAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighlightAll.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnHighlightAll.Image = global::ScintillaNET_FindReplaceDialog_CN.Properties.Resources.LineColorHS;
            this.btnHighlightAll.Location = new System.Drawing.Point(272, 0);
            this.btnHighlightAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnHighlightAll.Name = "btnHighlightAll";
            this.btnHighlightAll.Size = new System.Drawing.Size(22, 22);
            this.btnHighlightAll.TabIndex = 4;
            this.btnHighlightAll.Text = "&h";
            this.toolTip.SetToolTip(this.btnHighlightAll, "ͻ����ʾ����ƥ��(ALT+H)");
            this.btnHighlightAll.UseVisualStyleBackColor = true;
            this.btnHighlightAll.Click += new System.EventHandler(this.btnHighlightAll_Click);
            // 
            // btnClearHighlights
            // 
            this.btnClearHighlights.AutoSize = true;
            this.btnClearHighlights.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearHighlights.FlatAppearance.BorderSize = 0;
            this.btnClearHighlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearHighlights.Image = global::ScintillaNET_FindReplaceDialog_CN.Properties.Resources.DeleteHS;
            this.btnClearHighlights.Location = new System.Drawing.Point(294, 0);
            this.btnClearHighlights.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearHighlights.Name = "btnClearHighlights";
            this.btnClearHighlights.Size = new System.Drawing.Size(22, 22);
            this.btnClearHighlights.TabIndex = 5;
            this.btnClearHighlights.Text = "&j";
            this.toolTip.SetToolTip(this.btnClearHighlights, "ȡ��ͻ��(ALT+J)");
            this.btnClearHighlights.UseVisualStyleBackColor = true;
            this.btnClearHighlights.Click += new System.EventHandler(this.btnClearHighlights_Click);
            // 
            // IncrementalSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "IncrementalSearcher";
            this.Size = new System.Drawing.Size(316, 26);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button brnPrevious;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHighlightAll;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnClearHighlights;
    }
}
