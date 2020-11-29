using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

//Scritto da Rizzo Alessio 4^G
//Programma che genera 1000 parole da dieci lettere su un singolo o su multipli Thread
//Note:
namespace GeneratoreParole
{
    public partial class frmMain : Form
    {
        //Dichiarazione StopWatch
        Stopwatch stopwatch1 = new Stopwatch();
        Stopwatch stopwatch2 = new Stopwatch();

        //Random Array che genera 10000 lettere che andranno a comporre parole da 10 lettere
        Random rnd = new Random();

        //Implementazione Liste
        List<string> PAROLE1;
        List<string> PAROLE2;
        public frmMain()
        {
            InitializeComponent();       
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Clear la textbox
            txtBox1.Clear();
            //Pulisco StopWatch
            stopwatch1 = new Stopwatch();
            //Viene creata una nuova lista
            PAROLE1 = new List<string>();
            //Quando il bottone viene premuto lo stopwatch inizia a contare
            stopwatch1.Start();
            //Viene fatto partire il BGW
            bgw1.RunWorkerAsync();                     
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Clear la textbox
            txtBox2.Clear();
            // Pulisco StopWatch
            stopwatch2 = new Stopwatch();
            //Viene creata una nuova lista
            PAROLE2 = new List<string>();                     
            //Vengono fatti partire i BGW
            bgw2.RunWorkerAsync();
            bgw3.RunWorkerAsync();
            bgw4.RunWorkerAsync();
            //Quando il bottone viene premuto lo stopwatch inizia a contare
            stopwatch2.Start();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //Se il bottone "Gara" viene cliccato allora è come se i due bottoni start venissero cliccati insieme
            btn1_Click(sender, e);
            btn2_Click(sender, e);          
        }

        private void bgw1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Mentre gli elementi della lista PAROLE1 sono minori o uguali di 1000
            while (PAROLE1.Count <= 1000)
            {
                //La lista PAROLE1 aggiunge elementi richiamando il metodo GeneraParole
                PAROLE1.Add(GeneratoreDiParole());

                bgw1.ReportProgress(PAROLE1.Count / 10);
                Thread.Sleep(10);
            }
        }

        private void bgw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgrsBar1.Value = e.ProgressPercentage;
        }

        private void bgw1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgw1.CancelAsync();
            stopwatch1.Stop();
            txtBox1.Text = stopwatch1.ElapsedMilliseconds.ToString();           
        }

        private void bgw2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;

            while (PAROLE2.Count <= 1000)
            {
                lock (PAROLE2)
                {
                    PAROLE2.Add(GeneratoreDiParole());
                }
                bgw.ReportProgress(PAROLE2.Count / 10);
                Thread.Sleep(10);
            }
        }

        private void bgw2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgrsBar2.Value = e.ProgressPercentage;
        }

        private void bgw2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Fermo i tre BGW
            bgw2.CancelAsync();            
            //Fermo lo StopWatch2
            stopwatch2.Stop();
            //Stampo nella textBox2 il tempo in Millisecondi
            txtBox2.Text = stopwatch2.ElapsedMilliseconds.ToString();            
        }

        //Metodo che genera parole di 10 caratteri
        public string GeneratoreDiParole()
        {
            string parole = "";
            for (int j = 0; j < 10; j++)
            {
                parole += Convert.ToChar(rnd.Next(65, 98));
            }
            return parole;
        }

        private void bgw3_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;

            while (PAROLE2.Count <= 1000)
            {
                lock (PAROLE2)
                {
                    PAROLE2.Add(GeneratoreDiParole());
                }
                bgw.ReportProgress(PAROLE2.Count / 3);
                Thread.Sleep(10);
            }
        }
        private void bgw3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
        }

        private void bgw3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgw3.CancelAsync();
        }
        private void bgw4_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;

            while (PAROLE2.Count <= 1000)
            {
                lock (PAROLE2)
                {
                    PAROLE2.Add(GeneratoreDiParole());
                }
                bgw.ReportProgress(PAROLE2.Count / 3);
                Thread.Sleep(10);
            }
        }       

        private void bgw4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void bgw4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgw4.CancelAsync();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtBox1.Enabled = false;
            txtBox2.Enabled = false;
        }
    }
}
