namespace MiniBrowserApp
{
    partial class Form1
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
            panel1 = new Panel();
            btnAddFavorite = new Button();
            lstHistory = new ListBox();
            label2 = new Label();
            lstFavorites = new ListBox();
            label1 = new Label();
            btnBack = new Button();
            btnForward = new Button();
            btnRefresh = new Button();
            btnHome = new Button();
            button1 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            txtUrl = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddFavorite);
            panel1.Controls.Add(lstHistory);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lstFavorites);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(550, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 525);
            panel1.TabIndex = 0;
            // 
            // btnAddFavorite
            // 
            btnAddFavorite.Location = new Point(49, 447);
            btnAddFavorite.Name = "btnAddFavorite";
            btnAddFavorite.Size = new Size(171, 38);
            btnAddFavorite.TabIndex = 1;
            btnAddFavorite.Text = "Seçilmişlərə əlavə et";
            btnAddFavorite.UseVisualStyleBackColor = true;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(49, 243);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(150, 164);
            lstHistory.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 220);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Tarixçə";
            // 
            // lstFavorites
            // 
            lstFavorites.FormattingEnabled = true;
            lstFavorites.Location = new Point(49, 49);
            lstFavorites.Name = "lstFavorites";
            lstFavorites.Size = new Size(150, 164);
            lstFavorites.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Seçilmişlər";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            btnForward.Location = new Point(77, 17);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(48, 40);
            btnForward.TabIndex = 5;
            btnForward.Text = "→";
            btnForward.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(141, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(48, 40);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "↻";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(208, 17);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(48, 40);
            btnHome.TabIndex = 7;
            btnHome.Text = "⌂";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(456, 17);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 10;
            button1.Text = "Get";
            button1.UseVisualStyleBackColor = false;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(25, 77);
            webView21.Name = "webView21";
            webView21.Size = new Size(506, 436);
            webView21.TabIndex = 11;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(273, 23);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(148, 27);
            txtUrl.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 525);
            Controls.Add(txtUrl);
            Controls.Add(webView21);
            Controls.Add(button1);
            Controls.Add(btnHome);
            Controls.Add(btnRefresh);
            Controls.Add(btnForward);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private ListBox lstFavorites;
        private Label label1;
        private Button btnAddFavorite;
        private ListBox lstHistory;
        private Button btnBack;
        private Button btnForward;
        private Button btnRefresh;
        private Button btnHome;
        private Button button1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox txtUrl;
    }
}
