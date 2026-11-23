using System;
using System.Windows.Forms;

namespace MiniBrowserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            webView21.ZoomFactor = 0.8;

            button1.Click += button1_Click;
            btnBack.Click += btnBack_Click_1;
            btnForward.Click += btnForward_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnHome.Click += btnHome_Click;
            btnAddFavorite.Click += btnAddFavorite_Click;
            lstFavorites.SelectedIndexChanged += lstFavorites_SelectedIndexChanged;
        }

        private void webView21_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                return;
            }

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            webView21.Source = new Uri(url);
            lstHistory.Items.Add(url);
        }

        private void lstFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFavorites.SelectedItem == null)
            {
                return;
            }

            string url = lstFavorites.SelectedItem.ToString().Trim();
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "https://" + url;
            }

            txtUrl.Text = url;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
            {
                webView21.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward)
            {
                webView21.GoForward();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            string homeUrl = "https://www.google.com";
            txtUrl.Text = homeUrl;
            webView21.Source = new Uri(homeUrl);
        }

        private void btnAddFavorite_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                return;
            }

            url = url.Replace("https://", "").Replace("http://", "").TrimEnd('/');

            if (!lstFavorites.Items.Contains(url))
            {
                lstFavorites.Items.Add(url);
            }
        }
    }
}