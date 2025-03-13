namespace hesap_makinası
{
    public partial class hesapMakinesi : Form
    {
        char _islem;
        bool _ekranTemizlenecekmi;
        int _ilkSayi;
        public hesapMakinesi()


        {
            InitializeComponent();
        }

        private void hesapMakinesi_Load(object sender, EventArgs e)
        {

        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                sonucLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (sonucLabel.Text == "0")
                sonucLabel.Text = "";

            sonucLabel.Text += rakam1Button.Text;
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                sonucLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (sonucLabel.Text == "0")
                sonucLabel.Text = "";

            sonucLabel.Text += rakam2Button.Text;
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                sonucLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (sonucLabel.Text == "0")
                sonucLabel.Text = "";

            sonucLabel.Text += rakam3Button.Text;
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                sonucLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (sonucLabel.Text == "0")
                sonucLabel.Text = "";

            sonucLabel.Text += rakam4Button.Text;
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                sonucLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (sonucLabel.Text == "0")
                sonucLabel.Text = "";

            sonucLabel.Text += rakam5Button.Text;
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                sonucLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (sonucLabel.Text == "0")
                sonucLabel.Text = "";

            sonucLabel.Text += rakam6Button.Text;
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                sonucLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (sonucLabel.Text == "0")
                sonucLabel.Text = "";

            sonucLabel.Text += rakam7Button.Text;
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                sonucLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (sonucLabel.Text == "0")
                sonucLabel.Text = "";

            sonucLabel.Text += rakam8Button.Text;
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                sonucLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (sonucLabel.Text == "0")
                sonucLabel.Text = "";

            sonucLabel.Text += rakam9Button.Text;
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                sonucLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (sonucLabel.Text == "0")
                sonucLabel.Text = "";

            sonucLabel.Text += rakam0Button.Text;
        }

        private void toplamabutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(sonucLabel.Text);

        }

        private void cıkarmaButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(sonucLabel.Text);

        }

        private void carpmaButton_Click(object sender, EventArgs e)
        {
            _islem = 'x';
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(sonucLabel.Text);

        }

        private void bolmeButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(sonucLabel.Text);

        }

        private void tutulanIslemLabel_Click(object sender, EventArgs e)
        {
            tutulanIslemLabel.Text = Convert.ToString(_islem);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (_islem == 'x')
                sonucLabel.Text = Convert.ToString(Convert.ToInt32(sonucLabel.Text) * _ilkSayi);
            if (_islem == '/')
                sonucLabel.Text = Convert.ToString(Convert.ToInt32(sonucLabel.Text) / _ilkSayi);
            if (_islem == '+')
                sonucLabel.Text = Convert.ToString(Convert.ToInt32(sonucLabel.Text) + _ilkSayi);
            if (_islem == '-')
                sonucLabel.Text = Convert.ToString(Convert.ToInt32(sonucLabel.Text) - _ilkSayi);
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            sonucLabel.Text = "0";
            _ilkSayi = 0;
        }
    }
}
