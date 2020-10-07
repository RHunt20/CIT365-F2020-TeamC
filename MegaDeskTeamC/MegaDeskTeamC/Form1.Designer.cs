namespace MegaDeskTeamC
{
    partial class MainMenu
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
            this.AddQuote = new System.Windows.Forms.Button();
            this.ViewQuotes = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuote
            // 
            this.AddQuote.Location = new System.Drawing.Point(26, 26);
            this.AddQuote.Name = "AddQuote";
            this.AddQuote.Size = new System.Drawing.Size(132, 58);
            this.AddQuote.TabIndex = 0;
            this.AddQuote.Text = "Add New Quote";
            this.AddQuote.UseVisualStyleBackColor = true;
            this.AddQuote.Click += new System.EventHandler(this.AddQuote_Click);
            // 
            // ViewQuotes
            // 
            this.ViewQuotes.Location = new System.Drawing.Point(26, 90);
            this.ViewQuotes.Name = "ViewQuotes";
            this.ViewQuotes.Size = new System.Drawing.Size(132, 61);
            this.ViewQuotes.TabIndex = 1;
            this.ViewQuotes.Text = "View Quotes";
            this.ViewQuotes.UseVisualStyleBackColor = true;
            this.ViewQuotes.Click += new System.EventHandler(this.ViewQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.Location = new System.Drawing.Point(26, 157);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(132, 60);
            this.SearchQuotes.TabIndex = 2;
            this.SearchQuotes.Text = "Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = true;
            this.SearchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(26, 223);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(132, 60);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.ViewQuotes);
            this.Controls.Add(this.AddQuote);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Team C Mega Desk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuote;
        private System.Windows.Forms.Button ViewQuotes;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button Exit;
    }
}

