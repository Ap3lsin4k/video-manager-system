using System;
using System.Windows;
using System.Windows.Controls;
using VMS.ViewModel;

namespace VMS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //const int maxCamNums = 16;

        //int ColumRows = (int)Math.Sqrt(maxCamNums);

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();

            //ColumnDefinition[] ColDefs = new ColumnDefinition[ColumRows]; // Массив столбцов
            //RowDefinition[] RowDefs = new RowDefinition[ColumRows]; // Массив строчек

            //for (int i = 0; i < ColumRows; i++) 
            //{
            //    ColDefs[i] = new ColumnDefinition(); // инициализация столбцов
            //    MainGrid.ColumnDefinitions.Add(ColDefs[i]); // добавляем их в основную сетку

            //    RowDefs[i] = new RowDefinition(); // инициализация строчек
            //    MainGrid.RowDefinitions.Add(RowDefs[i]); // добавляем их в сетку
            //}

           

        }

    }
}
