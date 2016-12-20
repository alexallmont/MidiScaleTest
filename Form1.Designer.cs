namespace MidiScaleTest
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
            this.keyScroll = new System.Windows.Forms.HScrollBar();
            this.majMinCombo = new System.Windows.Forms.ComboBox();
            this.noteScroll = new System.Windows.Forms.HScrollBar();
            this.addScroll = new System.Windows.Forms.HScrollBar();
            this.arpScroll = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // keyScroll
            // 
            this.keyScroll.LargeChange = 1;
            this.keyScroll.Location = new System.Drawing.Point(59, 9);
            this.keyScroll.Maximum = 11;
            this.keyScroll.Name = "keyScroll";
            this.keyScroll.Size = new System.Drawing.Size(183, 21);
            this.keyScroll.TabIndex = 1;
            this.keyScroll.ValueChanged += new System.EventHandler(this.keyScroll_ValueChanged);
            // 
            // majMinCombo
            // 
            this.majMinCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.majMinCombo.FormattingEnabled = true;
            this.majMinCombo.Location = new System.Drawing.Point(245, 9);
            this.majMinCombo.Name = "majMinCombo";
            this.majMinCombo.Size = new System.Drawing.Size(80, 21);
            this.majMinCombo.TabIndex = 4;
            // 
            // noteScroll
            // 
            this.noteScroll.LargeChange = 1;
            this.noteScroll.Location = new System.Drawing.Point(59, 36);
            this.noteScroll.Maximum = 48;
            this.noteScroll.Name = "noteScroll";
            this.noteScroll.Size = new System.Drawing.Size(183, 21);
            this.noteScroll.TabIndex = 5;
            this.noteScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.noteScroll_Scroll);
            // 
            // addScroll
            // 
            this.addScroll.LargeChange = 1;
            this.addScroll.Location = new System.Drawing.Point(59, 63);
            this.addScroll.Maximum = 48;
            this.addScroll.Name = "addScroll";
            this.addScroll.Size = new System.Drawing.Size(266, 21);
            this.addScroll.TabIndex = 6;
            // 
            // arpScroll
            // 
            this.arpScroll.LargeChange = 1;
            this.arpScroll.Location = new System.Drawing.Point(59, 90);
            this.arpScroll.Maximum = 48;
            this.arpScroll.Name = "arpScroll";
            this.arpScroll.Size = new System.Drawing.Size(266, 21);
            this.arpScroll.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Add";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Arp";
            // 
            // noteButton
            // 
            this.noteButton.Location = new System.Drawing.Point(246, 36);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(79, 23);
            this.noteButton.TabIndex = 13;
            this.noteButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 123);
            this.Controls.Add(this.noteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arpScroll);
            this.Controls.Add(this.addScroll);
            this.Controls.Add(this.noteScroll);
            this.Controls.Add(this.majMinCombo);
            this.Controls.Add(this.keyScroll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar keyScroll;
        private System.Windows.Forms.ComboBox majMinCombo;
        private System.Windows.Forms.HScrollBar noteScroll;
        private System.Windows.Forms.HScrollBar addScroll;
        private System.Windows.Forms.HScrollBar arpScroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button noteButton;
    }
}

