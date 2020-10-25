namespace Huffman
{
    partial class Huffman
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
            this.LoadFileBtn = new System.Windows.Forms.Button();
            this.LoadEncodedFileBtn = new System.Windows.Forms.Button();
            this.EncodeFileBtn = new System.Windows.Forms.Button();
            this.DecodeFileBtn = new System.Windows.Forms.Button();
            this.TextArea = new System.Windows.Forms.TextBox();
            this.EncodeTextBtn = new System.Windows.Forms.Button();
            this.CodesBox = new System.Windows.Forms.ListBox();
            this.ShowCodesCB = new System.Windows.Forms.CheckBox();
            this.CoderLabel = new System.Windows.Forms.Label();
            this.DecoderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoadFileBtn
            // 
            this.LoadFileBtn.Location = new System.Drawing.Point(87, 47);
            this.LoadFileBtn.Name = "LoadFileBtn";
            this.LoadFileBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadFileBtn.TabIndex = 0;
            this.LoadFileBtn.Text = "Load File";
            this.LoadFileBtn.UseVisualStyleBackColor = true;
            this.LoadFileBtn.Click += new System.EventHandler(this.LoadFileBtn_Click);
            // 
            // LoadEncodedFileBtn
            // 
            this.LoadEncodedFileBtn.Location = new System.Drawing.Point(612, 47);
            this.LoadEncodedFileBtn.Name = "LoadEncodedFileBtn";
            this.LoadEncodedFileBtn.Size = new System.Drawing.Size(119, 23);
            this.LoadEncodedFileBtn.TabIndex = 1;
            this.LoadEncodedFileBtn.Text = "Load Encoded File";
            this.LoadEncodedFileBtn.UseVisualStyleBackColor = true;
            this.LoadEncodedFileBtn.Click += new System.EventHandler(this.LoadEncodedFileBtn_Click);
            // 
            // EncodeFileBtn
            // 
            this.EncodeFileBtn.Location = new System.Drawing.Point(87, 90);
            this.EncodeFileBtn.Name = "EncodeFileBtn";
            this.EncodeFileBtn.Size = new System.Drawing.Size(75, 23);
            this.EncodeFileBtn.TabIndex = 2;
            this.EncodeFileBtn.Text = "Encode File";
            this.EncodeFileBtn.UseVisualStyleBackColor = true;
            this.EncodeFileBtn.Click += new System.EventHandler(this.EncodeFileBtn_Click);
            // 
            // DecodeFileBtn
            // 
            this.DecodeFileBtn.Location = new System.Drawing.Point(612, 90);
            this.DecodeFileBtn.Name = "DecodeFileBtn";
            this.DecodeFileBtn.Size = new System.Drawing.Size(119, 23);
            this.DecodeFileBtn.TabIndex = 3;
            this.DecodeFileBtn.Text = "Decode File";
            this.DecodeFileBtn.UseVisualStyleBackColor = true;
            this.DecodeFileBtn.Click += new System.EventHandler(this.DecodeFileBtn_Click);
            // 
            // TextArea
            // 
            this.TextArea.Location = new System.Drawing.Point(48, 200);
            this.TextArea.Multiline = true;
            this.TextArea.Name = "TextArea";
            this.TextArea.Size = new System.Drawing.Size(159, 148);
            this.TextArea.TabIndex = 0;
            // 
            // EncodeTextBtn
            // 
            this.EncodeTextBtn.Location = new System.Drawing.Point(48, 384);
            this.EncodeTextBtn.Name = "EncodeTextBtn";
            this.EncodeTextBtn.Size = new System.Drawing.Size(159, 23);
            this.EncodeTextBtn.TabIndex = 4;
            this.EncodeTextBtn.Text = "Encode Input Text";
            this.EncodeTextBtn.UseVisualStyleBackColor = true;
            this.EncodeTextBtn.Click += new System.EventHandler(this.EncodeTextBtn_Click);
            // 
            // CodesBox
            // 
            this.CodesBox.FormattingEnabled = true;
            this.CodesBox.Location = new System.Drawing.Point(354, 232);
            this.CodesBox.Name = "CodesBox";
            this.CodesBox.Size = new System.Drawing.Size(120, 95);
            this.CodesBox.TabIndex = 5;
            // 
            // ShowCodesCB
            // 
            this.ShowCodesCB.AutoSize = true;
            this.ShowCodesCB.Location = new System.Drawing.Point(388, 200);
            this.ShowCodesCB.Name = "ShowCodesCB";
            this.ShowCodesCB.Size = new System.Drawing.Size(86, 17);
            this.ShowCodesCB.TabIndex = 6;
            this.ShowCodesCB.Text = "Show Codes";
            this.ShowCodesCB.UseVisualStyleBackColor = true;
            // 
            // CoderLabel
            // 
            this.CoderLabel.AutoSize = true;
            this.CoderLabel.Location = new System.Drawing.Point(104, 9);
            this.CoderLabel.Name = "CoderLabel";
            this.CoderLabel.Size = new System.Drawing.Size(35, 13);
            this.CoderLabel.TabIndex = 7;
            this.CoderLabel.Text = "Coder";
            // 
            // DecoderLabel
            // 
            this.DecoderLabel.AutoSize = true;
            this.DecoderLabel.Location = new System.Drawing.Point(656, 9);
            this.DecoderLabel.Name = "DecoderLabel";
            this.DecoderLabel.Size = new System.Drawing.Size(48, 13);
            this.DecoderLabel.TabIndex = 8;
            this.DecoderLabel.Text = "Decoder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cale:";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(239, 9);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(0, 13);
            this.pathLabel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // Huffman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecoderLabel);
            this.Controls.Add(this.CoderLabel);
            this.Controls.Add(this.ShowCodesCB);
            this.Controls.Add(this.CodesBox);
            this.Controls.Add(this.EncodeTextBtn);
            this.Controls.Add(this.TextArea);
            this.Controls.Add(this.DecodeFileBtn);
            this.Controls.Add(this.EncodeFileBtn);
            this.Controls.Add(this.LoadEncodedFileBtn);
            this.Controls.Add(this.LoadFileBtn);
            this.Name = "Huffman";
            this.Text = "Huffman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadFileBtn;
        private System.Windows.Forms.Button LoadEncodedFileBtn;
        private System.Windows.Forms.Button EncodeFileBtn;
        private System.Windows.Forms.Button DecodeFileBtn;
        private System.Windows.Forms.TextBox TextArea;
        private System.Windows.Forms.Button EncodeTextBtn;
        private System.Windows.Forms.ListBox CodesBox;
        private System.Windows.Forms.CheckBox ShowCodesCB;
        private System.Windows.Forms.Label CoderLabel;
        private System.Windows.Forms.Label DecoderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

