namespace WindowsFormsAppWeek2
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
            this.btnChangeDrawing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeDrawing
            // 
            this.btnChangeDrawing.Location = new System.Drawing.Point(345, 194);
            this.btnChangeDrawing.Name = "btnChangeDrawing";
            this.btnChangeDrawing.Size = new System.Drawing.Size(120, 44);
            this.btnChangeDrawing.TabIndex = 0;
            this.btnChangeDrawing.Text = "Change Drawing";
            this.btnChangeDrawing.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangeDrawing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeDrawing;
    }
}

