namespace Minesweeper
{
    partial class Form_Rank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rank));
            this.Label_Beginner = new System.Windows.Forms.Label();
            this.Label_Expert = new System.Windows.Forms.Label();
            this.Label_Intermediate = new System.Windows.Forms.Label();
            this.Button_Reset = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Beginner
            // 
            this.Label_Beginner.AutoSize = true;
            this.Label_Beginner.Location = new System.Drawing.Point(25, 47);
            this.Label_Beginner.Name = "Label_Beginner";
            this.Label_Beginner.Size = new System.Drawing.Size(53, 12);
            this.Label_Beginner.TabIndex = 0;
            this.Label_Beginner.Text = "Beginner";
            // 
            // Label_Expert
            // 
            this.Label_Expert.AutoSize = true;
            this.Label_Expert.Location = new System.Drawing.Point(25, 103);
            this.Label_Expert.Name = "Label_Expert";
            this.Label_Expert.Size = new System.Drawing.Size(41, 12);
            this.Label_Expert.TabIndex = 1;
            this.Label_Expert.Text = "Expert";
            // 
            // Label_Intermediate
            // 
            this.Label_Intermediate.AutoSize = true;
            this.Label_Intermediate.Location = new System.Drawing.Point(25, 74);
            this.Label_Intermediate.Name = "Label_Intermediate";
            this.Label_Intermediate.Size = new System.Drawing.Size(77, 12);
            this.Label_Intermediate.TabIndex = 2;
            this.Label_Intermediate.Text = "Intermediate";
            // 
            // Button_Reset
            // 
            this.Button_Reset.Location = new System.Drawing.Point(27, 146);
            this.Button_Reset.Name = "Button_Reset";
            this.Button_Reset.Size = new System.Drawing.Size(75, 23);
            this.Button_Reset.TabIndex = 3;
            this.Button_Reset.Text = "清零";
            this.Button_Reset.UseVisualStyleBackColor = true;
            this.Button_Reset.Click += new System.EventHandler(this.Button_Reset_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(146, 146);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 208);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.Button_Reset);
            this.Controls.Add(this.Label_Intermediate);
            this.Controls.Add(this.Label_Expert);
            this.Controls.Add(this.Label_Beginner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Rank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Rank";
            this.Load += new System.EventHandler(this.Form_Rank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Beginner;
        private System.Windows.Forms.Label Label_Expert;
        private System.Windows.Forms.Label Label_Intermediate;
        private System.Windows.Forms.Button Button_Reset;
        private System.Windows.Forms.Button button_OK;
    }
}