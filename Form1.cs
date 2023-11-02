using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public string appDate = "02/11/2023";
        public string appVersion = "V0.1";
        public string appName = "Clock ";

        private Timer timer;
        private Msg msg;
        
        private TimeSpan elapsed = TimeSpan.Zero;
        private bool isRunning = false;
        private string historique = "";
        private int historiqueCounter = 0;

        private string defaultValue = "00:00:00:000";

        private bool showMilliseconds = true;
        private bool showSeconds = true;
        private bool showMinutes = true;
        private bool showHours = true;


        public Form1()
        {
            InitializeComponent();
            appName += appVersion;

            timer = new Timer();
            timer.Interval = showMilliseconds ? 1 : 1000;
            timer.Tick += Timer_Tick;

            msg = new Msg(this);

            timerScreen.Text = defaultValue;
        }

        private string GetTimerType()
        {
            if (showHours)
            {
                if (showMinutes)
                {
                    if (showSeconds)
                    {
                        if (showMilliseconds)
                        {
                            return @"hh\:mm\:ss\.fff";
                        }
                        return @"hh\:mm\:ss";
                    }
                    return @"hh\:mm";
                }
                return @"hh";
            }
            return string.Empty;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (showMilliseconds)
            {
                elapsed = elapsed.Add(TimeSpan.FromMilliseconds(1));
            }

            if (showSeconds && elapsed.Milliseconds == 0)
            {
                elapsed = elapsed.Add(TimeSpan.FromSeconds(1));
            }

            if (showMinutes && elapsed.Seconds == 0 && elapsed.Milliseconds == 0)
            {
                elapsed = elapsed.Add(TimeSpan.FromMinutes(1));
            }

            if (showHours && elapsed.Minutes == 0 && elapsed.Seconds == 0 && elapsed.Milliseconds == 0)
            {
                elapsed = elapsed.Add(TimeSpan.FromHours(1));
            }

            UpdateTimerDisplay();
        }

        private void UpdateTimerDisplay()
        {
            string format = GetTimerType();
            if (!string.IsNullOrEmpty(format))
            {
                if (showMilliseconds)
                {
                    timerScreen.Text = string.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                        elapsed.Hours, elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);
                }
                else
                {
                    timerScreen.Text = elapsed.ToString(format);
                }
            }
        }

        private void désactiverLesMillisecondesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMilliseconds = !showMilliseconds;
            UpdateTimerDisplay();
        }

        private void désactiverLesSecondesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSeconds = !showSeconds;
            UpdateTimerDisplay();
        }

        private void désactiverLesMinutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMinutes = !showMinutes;
            UpdateTimerDisplay();
        }

        private void désactiverLesHeuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHours = !showHours;
            UpdateTimerDisplay();
        }


        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer.Stop();
                isRunning = false;
                startStopButton.Text = "Démarrer";
                startStopButton.ForeColor = Color.FromArgb(0, 192, 0);
            }
            else
            {
                timer.Start();
                isRunning = true;
                startStopButton.Text = "Arrêter";
                startStopButton.ForeColor = Color.FromArgb(255, 128, 0);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if(timerScreen.Text != "00:00:00:00")
            {
                timer.Stop();
                msg.Success("Le temps était de " + timerScreen.Text + " !");
                historiqueCounter++;
                historique += historiqueCounter + " - " + timerScreen.Text + "\n";
                isRunning = false;
                startStopButton.Text = "Démarrer";
                startStopButton.ForeColor = Color.FromArgb(0, 192, 0);
                elapsed = TimeSpan.Zero;
                UpdateTimerDisplay();
            }
        }

        private void voirLhistoriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historique.Length > 0)
            {
                msg.Historique(historique);
            }
            else
            {
                msg.Error("Aucun historique actuellement.");
            }
        }

        private void viderLhistoriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = msg.YesNo("Voulez-vous vraiment vider l'historique ?", "Confirmation");

            if (dialogResult == DialogResult.Yes)
            {
                msg.Success("L'historique a été supprimé avec un total de " + historiqueCounter + " temps réalisé(s).");
                historique = "";
                historiqueCounter = 0;
            }
        }

        private void enregistrerLhistoriqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historique.Length > 0) { 
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt";
                saveFileDialog.Title = "Enregistrer l'historique";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    try
                    {
                        System.IO.File.WriteAllText(fileName, historique);
                        DialogResult mboxResult = msg.YesNo("L'historique a été enregistré avec succès dans : " + fileName + "\n\nSouhaitez-vous vider l'historique actuel après l'avoir enregistré ?", "Succès");

                        if(mboxResult == DialogResult.Yes)
                        {
                            historique = "";
                            historiqueCounter = 0;
                            msg.Success("L'historique a été vidé avec succès.");
                        }
                    }
                    catch (Exception ex)
                    {
                        msg.Error("Une erreur s'est produite lors de l'enregistrement du fichier : " + ex.Message);
                    }
                }
            } else
            {
                msg.Error("Aucun historique actuellement, aucun enregistrement possible.");
            }
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msg.Info($"Application créée par Alexis.\n\nVersion actuelle de l'application: {appVersion}\nDate de la version: {appDate}");
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string getAppName()
        {
            return appName;
        }
    }
}
