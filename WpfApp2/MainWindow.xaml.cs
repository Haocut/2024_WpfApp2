using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            int number;
            List<int> primes = new List<int>();

            bool isSucces = int.TryParse(MyTextBox.Text, out number);

            if (!isSucces)
            {
                MessageBox.Show("請輸入整數", "錯誤");
            }
            else if (number < 2)
            {
                MessageBox.Show("請輸入大於等於2的整數", "錯誤");
            }
            else
            {
                string primeText = $"{number}的質數有：";
                for (int i = 2; i <= number; i++)
                {
                 if(IsPrime(i)) primes.Add(i);
                }
                foreach (var p in primes)
                {
                    primeText += p +" ";
                }
                MyTextBlock.Text = primeText;
            }
        }

        private bool IsPrime(int p)
        {
            
            for (int i = 2; i < p; i++)
            {
                if (p % i == 0) return false;
            }
            return true;
        }

        
    }   

}