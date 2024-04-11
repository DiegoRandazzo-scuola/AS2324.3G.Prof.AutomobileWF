namespace AS2324._3G.Prof.AutomobileWF
{
    public partial class Form1 : Form
    {

        const int stepAccelerazione = 10;
        const int stepFrenata = -5;

        double velocita = 0;

        public Form1()
        {
            InitializeComponent();

            // parameters setting on progress bar
            prbVelocita.Minimum = 0;
            prbVelocita.Maximum = 160;

            grbComandi.Enabled = false;
        }

        private void btnAccelera_Click(object sender, EventArgs e)
        {
            velocita += stepAccelerazione;
            string controllo= cmbStrada.Text;
            switch (controllo)
            {
                case "Urbana (50 k/h)":
                    if((int) velocita>50)
                    {
                        string messaggio = "STAI SUPERANDO IL LIMITE DI 50 K/H";
                        lstMonitor.Items.Add(messaggio);
                    }
                    break;
                case "Extraurbana (90 k/h)":
                    if ((int)velocita > 90)
                    {
                        string messaggio = "STAI SUPERANDO IL LIMITE DI 90 K/H";
                        lstMonitor.Items.Add(messaggio);
                    }
                    break;
                case "Autostrada (130 k/h)":
                    if ((int)velocita > 130)
                    {
                        string messaggio = "STAI SUPERANDO IL LIMITE DI 130 K/H";
                        lstMonitor.Items.Add(messaggio);
                    }
                    break;
            }

            monitor();
        }

        private void btnFrena_Click(object sender, EventArgs e)
        {
            velocita += stepFrenata;

            monitor();
        }


        private void monitor()
        {
            prbVelocita.Value = (int)velocita;
        }
        private void btnClacson_Click(object sender, EventArgs e)
        {
            string messaggio = "hai suonato il clacson";
            lstMonitor.Items.Add(messaggio);
        }

        private void chkAccensione_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccensione.Checked == true)
                grbComandi.Enabled = true;
            else
                grbComandi.Enabled = false;

        }
        private void chkCinture_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccensione.Checked == false)
            {
                string messaggio = "non sta usando la cintura di sicurezza";
                lstMonitor.Items.Add(messaggio);
            }
        }
    }
}
