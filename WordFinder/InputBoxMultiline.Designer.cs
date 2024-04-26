namespace WordFinder
{
    partial class InputBoxMultiline
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
            btnOK = new Button();
            txtInputText = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(575, 336);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtInputText
            // 
            txtInputText.CharacterCasing = CharacterCasing.Lower;
            txtInputText.Font = new Font("Courier New", 8F);
            txtInputText.Location = new Point(11, 12);
            txtInputText.MaxLength = 4222;
            txtInputText.Multiline = true;
            txtInputText.Name = "txtInputText";
            txtInputText.ScrollBars = ScrollBars.Vertical;
            txtInputText.Size = new Size(676, 309);
            txtInputText.TabIndex = 0;
            txtInputText.WordWrap = false;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(11, 336);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // InputBoxMultiline
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 394);
            Controls.Add(btnCancel);
            Controls.Add(txtInputText);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputBoxMultiline";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "InputBoxMultiline";
            Load += InputBoxMultiline_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private TextBox txtInputText;
        private Button btnCancel;
    }
}