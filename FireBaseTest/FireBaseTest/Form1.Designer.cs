namespace FireBaseTest
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.WriteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.BirthText = new System.Windows.Forms.TextBox();
            this.GenderText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(42, 105);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(75, 23);
            this.WriteButton.TabIndex = 0;
            this.WriteButton.Text = "DB_Write";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.Write_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(75, 6);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 21);
            this.NameText.TabIndex = 4;
            // 
            // BirthText
            // 
            this.BirthText.Location = new System.Drawing.Point(75, 34);
            this.BirthText.Name = "BirthText";
            this.BirthText.Size = new System.Drawing.Size(100, 21);
            this.BirthText.TabIndex = 5;
            // 
            // GenderText
            // 
            this.GenderText.Location = new System.Drawing.Point(75, 61);
            this.GenderText.Name = "GenderText";
            this.GenderText.Size = new System.Drawing.Size(100, 21);
            this.GenderText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 143);
            this.Controls.Add(this.GenderText);
            this.Controls.Add(this.BirthText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WriteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox BirthText;
        private System.Windows.Forms.TextBox GenderText;
    }
}

