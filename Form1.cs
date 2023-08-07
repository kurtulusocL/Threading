using System;
using System.Threading;
using System.Windows.Forms;

namespace Threading
{
    public partial class Form1 : Form
    {
        int numberOne, numberTwo;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MultipleCounter();
        }
        
        void Total()
        {
            numberOne = Convert.ToInt32(txtNumberOne.Text);
            numberTwo = Convert.ToInt32(txtNumberTwo.Text);

            var result = numberOne + numberTwo;
            lblResultOne.Text = result.ToString();
        }

        void Multiplication()
        {
            numberOne = Convert.ToInt32(txtNumberOne.Text);
            numberTwo = Convert.ToInt32(txtNumberTwo.Text);

            var result = numberOne * numberTwo;
            lblResultTwo.Text = result.ToString();
        }

        public void StartMultipleAccounter()
        {
            Thread thread1 = new Thread(new ThreadStart(Total));
            thread1.Priority = ThreadPriority.Lowest;
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(Multiplication));
            thread2.Priority = ThreadPriority.Highest;
            thread2.Start();
        }

        void btnResult_Click(object sender, EventArgs e)
        {
            StartMultipleAccounter();
        }

        public void MultipleCounter()
        {
            Thread thread1 = new Thread(new ThreadStart(ThreadFuncEven));
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(ThreadFuncOdd)); 
            thread2.Start();
        }
        void ThreadFuncEven()
        {
            for (int i = 0; i < 100; i += 2)
            {
                Thread.Sleep(1000);
                listboxOne.Items.Add(i);
            }
        }

        void ThreadFuncOdd()
        {
            for (int i = 1; i < 100; i += 2)
            {
                Thread.Sleep(1000);
                lsbTwo.Items.Add(i);
            }
        }
    }
}