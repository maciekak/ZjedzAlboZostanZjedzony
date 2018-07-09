using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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

namespace ZjedzAlboZostanZjedzony
{
    /// <summary>
    /// Interaction logic for SimulationView.xaml
    /// </summary>
    public partial class SimulationView : UserControl
    {
        private MainViewModel _mainViewModel;
        public SimulationView()
        {
            InitializeComponent();
            if (Application.Current.MainWindow == null)
                return;

            _mainViewModel = Application.Current.MainWindow.DataContext as MainViewModel;

            SetUpBoard();
        }

        private void SetUpBoard()
        {
            CreateBoard();
            FillEachCell();
        }

        private void CreateBoard()
        {
            for (int i = 0; i < _mainViewModel.MapSize; i++)
            {
                Board.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
                Board.RowDefinitions.Add(new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Star)
                });
            }
        }

        private void FillEachCell()
        {
            for (int col = 0; col < _mainViewModel.MapSize; col++)
            {
                for (int row = 0; row < _mainViewModel.MapSize; row++)
                {
                    var cellText = new TextBlock
                    {
                        TextAlignment = TextAlignment.Center,
                        HorizontalAlignment = HorizontalAlignment.Stretch,
                        VerticalAlignment = VerticalAlignment.Stretch
                    };
                    //var cellBinding = new Binding(_mainViewModel.);
                    //cellText.SetBinding(TextBlock.TextProperty, )
                    //jkljkllll
                    //jkljkl
                    var cell = new Frame
                    {
                        BorderThickness = new Thickness(0.5),
                        BorderBrush = Brushes.Gray,
                        Content = cellText
                    };
                    cell.SetValue(Grid.ColumnProperty, col);
                    cell.SetValue(Grid.RowProperty, row);
                    Board.Children.Add(cell);
                }
            }
        }


    }
}
