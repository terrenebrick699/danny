namespace LUNA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.charCountLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.render = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wordwrap = new System.Windows.Forms.Button();
            this.TimeElapsed = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Chocolate;
            this.newButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newButton.FlatAppearance.BorderSize = 10;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newButton.Font = new System.Drawing.Font("Nintendo NES Font", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.Black;
            this.newButton.Location = new System.Drawing.Point(234, 42);
            this.newButton.Margin = new System.Windows.Forms.Padding(2);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(60, 32);
            this.newButton.TabIndex = 3;
            this.newButton.Text = "NEW";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Chocolate;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Nintendo NES Font", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(160, 42);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 32);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.BackColor = System.Drawing.Color.Chocolate;
            this.openButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openButton.Font = new System.Drawing.Font("Nintendo NES Font", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.ForeColor = System.Drawing.Color.Black;
            this.openButton.Location = new System.Drawing.Point(84, 42);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(72, 32);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "OPEN";
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // charCountLabel
            // 
            this.charCountLabel.AutoSize = true;
            this.charCountLabel.Font = new System.Drawing.Font("Nintendo NES Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charCountLabel.Location = new System.Drawing.Point(84, 12);
            this.charCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.charCountLabel.Name = "charCountLabel";
            this.charCountLabel.Size = new System.Drawing.Size(189, 13);
            this.charCountLabel.TabIndex = 6;
            this.charCountLabel.Text = "CHARACTERS: 0";
            // 
            // textBox
            // 
            this.textBox.AcceptsTab = true;
            this.textBox.AutoWordSelection = true;
            this.textBox.BackColor = System.Drawing.Color.Bisque;
            this.textBox.DetectUrls = false;
            this.textBox.Font = new System.Drawing.Font("Aseprite", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox.Location = new System.Drawing.Point(11, 78);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(579, 336);
            this.textBox.TabIndex = 7;
            this.textBox.Text = "";
            this.textBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // render
            // 
            this.render.BackColor = System.Drawing.Color.Chocolate;
            this.render.Cursor = System.Windows.Forms.Cursors.Hand;
            this.render.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.render.Font = new System.Drawing.Font("Nintendo NES Font", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.render.ForeColor = System.Drawing.Color.Black;
            this.render.Location = new System.Drawing.Point(298, 42);
            this.render.Margin = new System.Windows.Forms.Padding(2);
            this.render.Name = "render";
            this.render.Size = new System.Drawing.Size(131, 32);
            this.render.TabIndex = 8;
            this.render.Text = "HIGHLIGHT MARKDOWN";
            this.render.UseVisualStyleBackColor = false;
            this.render.Click += new System.EventHandler(this.render_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Nintendo NES Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(75, 422);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "ABOUT DANNY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::LUNA.Properties.Resources.dannyicon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nintendo NES Font", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "TIME ELAPSED: LOADING";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // wordwrap
            // 
            this.wordwrap.BackColor = System.Drawing.Color.Chocolate;
            this.wordwrap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wordwrap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wordwrap.Font = new System.Drawing.Font("Nintendo NES Font", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordwrap.ForeColor = System.Drawing.Color.Black;
            this.wordwrap.Location = new System.Drawing.Point(433, 41);
            this.wordwrap.Margin = new System.Windows.Forms.Padding(2);
            this.wordwrap.Name = "wordwrap";
            this.wordwrap.Size = new System.Drawing.Size(157, 32);
            this.wordwrap.TabIndex = 14;
            this.wordwrap.Text = "DISABLE WORD WRAP";
            this.wordwrap.UseVisualStyleBackColor = false;
            this.wordwrap.Click += new System.EventHandler(this.button2_Click);
            // 
            // TimeElapsed
            // 
            this.TimeElapsed.Enabled = true;
            this.TimeElapsed.Interval = 1000;
            this.TimeElapsed.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Nintendo NES Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(298, 422);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "DARK MODE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(599, 457);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.wordwrap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.render);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.charCountLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Danny";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button render;

        #endregion
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label charCountLabel;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wordwrap;
        public System.Windows.Forms.Timer TimeElapsed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

