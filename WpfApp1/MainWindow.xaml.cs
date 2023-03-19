using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace PrackWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<int> Dostup = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


        int player = 0;
        bool Win = false;
        private void One_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(Dostup.Count.ToString());

            string name = sender.GetType().GetProperty("Name").GetValue(sender).ToString();
            if (name == "One")
            {
                Dostup.Remove(1);

            }
            if (name == "Two")
            {
                Dostup.Remove(2);

            }
            if (name == "Three")
            {
                Dostup.Remove(3);

            }
            if (name == "Four")
            {
                Dostup.Remove(4);

            }
            if (name == "Five")
            {
                Dostup.Remove(5);

            }
            if (name == "Six")
            {
                Dostup.Remove(6);

            }
            if (name == "Seven")
            {
                Dostup.Remove(7);

            }
            if (name == "Eigth")
            {
                Dostup.Remove(8);

            }
            if (name == "Nine")
            {
                Dostup.Remove(9);

            }

            if (player == 0)
            {
                sender.GetType().GetProperty("Content").SetValue(sender, "X");
                player = 1;
                sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);

                Proverka();
                if (Win == false)
                {
                    //MessageBox.Show(name);

                    Mozg();

                }
            }
            else
            {

                sender.GetType().GetProperty("Content").SetValue(sender, "O");
                player = 0;
                sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
                Proverka();

            }




        }

        void Proverka()
        {
            if ((One.Content == "X" && Two.Content == "X" && Three.Content == "X") || (Four.Content == "X" && Five.Content == "X" && Six.Content == "X") || (Seven.Content == "X" && Eigth.Content == "X" && Nine.Content == "X") || (One.Content == "X" && Four.Content == "X" && Seven.Content == "X") || (Two.Content == "X" && Five.Content == "X" && Eigth.Content == "X") || (Three.Content == "X" && Six.Content == "X" && Nine.Content == "X") || (One.Content == "X" && Five.Content == "X" && Nine.Content == "X") || (Seven.Content == "X" && Five.Content == "X" && Three.Content == "X"))
            {
                MessageBox.Show("✖ - Выиграли крестики!");
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
                Win = true;
            }
            else if ((One.Content == "O" && Two.Content == "O" && Three.Content == "O") || (Four.Content == "O" && Five.Content == "O" && Six.Content == "O") || (Seven.Content == "O" && Eigth.Content == "O" && Nine.Content == "O") || (One.Content == "O" && Four.Content == "O" && Seven.Content == "O") || (Two.Content == "O" && Five.Content == "O" && Eigth.Content == "O") || (Three.Content == "O" && Six.Content == "O" && Nine.Content == "O") || (One.Content == "O" && Five.Content == "O" && Nine.Content == "O") || (Seven.Content == "O" && Five.Content == "O" && Three.Content == "O"))
            {
                MessageBox.Show("◯ - Выиграли Нолики!");
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
                Win = true;
            }
            else if (One.Content != "" && Two.Content != "" && Three.Content != "" && Four.Content != "" && Five.Content != "" && Six.Content != "" && Seven.Content != "" && Eigth.Content != "" && Nine.Content != "")
            {
                MessageBox.Show("ⓃⓄ ⓌⒾⓃⓃⒺⓇ!");
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
                Win = true;
            }
        }

        void Mozg()
        {

            if (player == 0)
                return;
            //MessageBox.Show("evrevrevere");
            Random rnd = new Random();
            int number = rnd.Next(0, Dostup.Count);
            //MessageBox.Show(Dostup[number].ToString());
            if (Dostup[number] == 1)
                typeof(System.Windows.Controls.Primitives.ButtonBase).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(One, new object[0]);
            else if (Dostup[number] == 2)
                typeof(System.Windows.Controls.Primitives.ButtonBase).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(Two, new object[0]);
            else if (Dostup[number] == 3)
                typeof(System.Windows.Controls.Primitives.ButtonBase).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(Three, new object[0]);
            else if (Dostup[number] == 4)
                typeof(System.Windows.Controls.Primitives.ButtonBase).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(Four, new object[0]);
            else if (Dostup[number] == 5)
                typeof(System.Windows.Controls.Primitives.ButtonBase).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(Five, new object[0]);
            else if (Dostup[number] == 6)
                typeof(System.Windows.Controls.Primitives.ButtonBase).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(Six, new object[0]);
            else if (Dostup[number] == 7)
                typeof(System.Windows.Controls.Primitives.ButtonBase).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(Seven, new object[0]);
            else if (Dostup[number] == 8)
                typeof(System.Windows.Controls.Primitives.ButtonBase).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(Eigth, new object[0]);
            else if (Dostup[number] == 9)
                typeof(System.Windows.Controls.Primitives.ButtonBase).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(Nine, new object[0]);
        }
    }
}

