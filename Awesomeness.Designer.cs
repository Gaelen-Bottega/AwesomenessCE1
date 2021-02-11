
namespace AwesomenessCE1
{
    partial class Awesomeness
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelAwesomenessPrompt = new System.Windows.Forms.Label();
            this.LeftNo = new System.Windows.Forms.Button();
            this.RightNo = new System.Windows.Forms.Button();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelAwesomenessPrompt
            // 
            this.labelAwesomenessPrompt.Location = new System.Drawing.Point(12, 9);
            this.labelAwesomenessPrompt.Name = "labelAwesomenessPrompt";
            this.labelAwesomenessPrompt.Size = new System.Drawing.Size(288, 67);
            this.labelAwesomenessPrompt.TabIndex = 0;
            this.labelAwesomenessPrompt.Text = "The computer has detected that you are awesome. \r\nIs there a chance you are aweso" +
    "me?";
            this.labelAwesomenessPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelAwesomenessPrompt, "Is there a chance you are awesome?");
            // 
            // LeftNo
            // 
            this.LeftNo.Location = new System.Drawing.Point(116, 90);
            this.LeftNo.Name = "LeftNo";
            this.LeftNo.Size = new System.Drawing.Size(75, 23);
            this.LeftNo.TabIndex = 2;
            this.LeftNo.Text = "&No";
            this.toolTip1.SetToolTip(this.LeftNo, "Click to say you are not cool");
            this.LeftNo.UseVisualStyleBackColor = true;
            this.LeftNo.Visible = false;
            this.LeftNo.Click += new System.EventHandler(this.HideLeft);
            this.LeftNo.MouseEnter += new System.EventHandler(this.HideLeft);
            // 
            // RightNo
            // 
            this.RightNo.Location = new System.Drawing.Point(214, 90);
            this.RightNo.Name = "RightNo";
            this.RightNo.Size = new System.Drawing.Size(75, 23);
            this.RightNo.TabIndex = 3;
            this.RightNo.Text = "&No";
            this.toolTip1.SetToolTip(this.RightNo, "Click this to say you are not cool");
            this.RightNo.UseVisualStyleBackColor = true;
            this.RightNo.Click += new System.EventHandler(this.HideRight);
            this.RightNo.MouseEnter += new System.EventHandler(this.HideRight);
            // 
            // ButtonYes
            // 
            this.ButtonYes.Location = new System.Drawing.Point(18, 90);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(75, 23);
            this.ButtonYes.TabIndex = 1;
            this.ButtonYes.Text = "&Yes";
            this.toolTip1.SetToolTip(this.ButtonYes, "Click me to declare you are awesome");
            this.ButtonYes.UseVisualStyleBackColor = true;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYesClick);
            // 
            // Awesomeness
            // 
            this.AcceptButton = this.ButtonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 138);
            this.Controls.Add(this.ButtonYes);
            this.Controls.Add(this.RightNo);
            this.Controls.Add(this.LeftNo);
            this.Controls.Add(this.labelAwesomenessPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Awesomeness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Awesomeness Detector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAwesomenessPrompt;
        private System.Windows.Forms.Button LeftNo;
        private System.Windows.Forms.Button RightNo;
        private System.Windows.Forms.Button ButtonYes;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

