namespace RobocopyGUI
{
    partial class PathDirection
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.srcPath_textBox = new System.Windows.Forms.TextBox();
            this.dstPath_textBox = new System.Windows.Forms.TextBox();
            this.srcBrowse_button = new System.Windows.Forms.Button();
            this.dstBrowse_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.run_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // srcPath_textBox
            // 
            this.srcPath_textBox.Font = new System.Drawing.Font("굴림", 11F);
            this.srcPath_textBox.Location = new System.Drawing.Point(118, 113);
            this.srcPath_textBox.Name = "srcPath_textBox";
            this.srcPath_textBox.Size = new System.Drawing.Size(264, 24);
            this.srcPath_textBox.TabIndex = 0;
            // 
            // dstPath_textBox
            // 
            this.dstPath_textBox.Font = new System.Drawing.Font("굴림", 11F);
            this.dstPath_textBox.Location = new System.Drawing.Point(118, 230);
            this.dstPath_textBox.Name = "dstPath_textBox";
            this.dstPath_textBox.Size = new System.Drawing.Size(264, 24);
            this.dstPath_textBox.TabIndex = 1;
            // 
            // srcBrowse_button
            // 
            this.srcBrowse_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srcBrowse_button.Font = new System.Drawing.Font("굴림", 11F);
            this.srcBrowse_button.Location = new System.Drawing.Point(402, 113);
            this.srcBrowse_button.Name = "srcBrowse_button";
            this.srcBrowse_button.Size = new System.Drawing.Size(85, 24);
            this.srcBrowse_button.TabIndex = 2;
            this.srcBrowse_button.Text = "Browse";
            this.srcBrowse_button.UseVisualStyleBackColor = true;
            this.srcBrowse_button.Click += new System.EventHandler(this.srcBrowse_button_Click);
            // 
            // dstBrowse_button
            // 
            this.dstBrowse_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dstBrowse_button.Font = new System.Drawing.Font("굴림", 11F);
            this.dstBrowse_button.Location = new System.Drawing.Point(402, 230);
            this.dstBrowse_button.Name = "dstBrowse_button";
            this.dstBrowse_button.Size = new System.Drawing.Size(85, 24);
            this.dstBrowse_button.TabIndex = 3;
            this.dstBrowse_button.Text = "Browse";
            this.dstBrowse_button.UseVisualStyleBackColor = true;
            this.dstBrowse_button.Click += new System.EventHandler(this.dstBrowse_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 14F);
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // run_button
            // 
            this.run_button.Font = new System.Drawing.Font("굴림", 14F);
            this.run_button.Location = new System.Drawing.Point(200, 352);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(112, 48);
            this.run_button.TabIndex = 6;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // PathDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dstBrowse_button);
            this.Controls.Add(this.srcBrowse_button);
            this.Controls.Add(this.dstPath_textBox);
            this.Controls.Add(this.srcPath_textBox);
            this.Name = "PathDirection";
            this.Size = new System.Drawing.Size(520, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox srcPath_textBox;
        private System.Windows.Forms.TextBox dstPath_textBox;
        private System.Windows.Forms.Button srcBrowse_button;
        private System.Windows.Forms.Button dstBrowse_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
