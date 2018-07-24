using DotaAutoChecker.Controls;
using DotaAutoChecker.Properties;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace DotaAutoChecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables

        private bool _clicked;
        private Point _lmAbs;

        private readonly DialogService _ds;
        private readonly ConfigManager _cm;
        private DispatcherTimer _dispatcherTimer;

        #endregion
        
        #region Constructor

        public MainWindow()
        {
            _ds = new DialogService {FilePath = Settings.Default.ConfigPath};
            _cm = new ConfigManager();
            InitializeComponent();
            FixButtonPosition();
        }

        #endregion

        #region Loading Events

        private void Window_Activated(object sender, EventArgs e)
        {
            RefreshFace();
            SetTimerOn();
        }

        #endregion

        #region Controls

        private void BtnDirectory_Click(object sender, RoutedEventArgs e)
        {
            if (_ds.OpenFileDialog()) RefreshStatusBar();
        }

        private void BtnFindReplace_Click(object sender, RoutedEventArgs e)
        {
            string configFile = _cm.DoMagic(_ds.FilePath);
            StatusTextBlock.Text = configFile;
            RefreshFace();
        }

        private void BtnTerminate_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

        #endregion

        #region Moving Window

        void Grid_MouseDown(object sender, MouseEventArgs e) => GrabMouseCoords(e);

        void Grid_MouseUp(object sender, MouseEventArgs e) => _clicked = false;

        void Grid_MouseMove(object sender, MouseEventArgs e) => DragWindow(e);

        #endregion

        #region Helpers

        private void RefreshFace()
        {
            RefreshStatusBar();
            RefreshDistanceParameter();
            RefreshColorize();
        }

        private void RefreshStatusBar()
        {
            _ds.FilePath = Settings.Default.ConfigPath;
            RefreshDistanceParameter();
        }

        private void RefreshDistanceParameter()
        {
            if (string.IsNullOrEmpty(_ds.FilePath)) return;
            lblCameraDistance.Text = _cm.GetCameraDistanceValue(_ds.FilePath);
        }

        private void RefreshColorize()
        {
            if (!int.TryParse(lblCameraDistance.Text, out int distance))
            {
                lblCameraDistance.Text = "Wrong distance in field";
                lblCameraDistance.Background = FindResource("TronYellowBrush") as Brush;
                lblCameraDistance.Foreground = FindResource("TronBackground") as Brush;
                return;
            }

            if (Settings.Default.OptimalCameraValue != distance)
            {
                lblCameraDistance.Background = FindResource("TronBackground") as Brush;
                lblCameraDistance.Foreground = FindResource("TronRedBrush") as Brush;
                return;
            }

            lblCameraDistance.Background = FindResource("TronBackground") as Brush;
            lblCameraDistance.Foreground = FindResource("TronGreenBrush") as Brush;
        }

        private void FixButtonPosition()
        {
            double botMargin = 50;//StatusBarPanel.Height + 2;
            var btnGetTargetMargin = BtnGetTarget.Margin;
            var btnFixDistance = BtnFixDistance.Margin;
            var btnTerminate = BtnTerminate.Margin;

            btnGetTargetMargin.Bottom = botMargin;
            btnFixDistance.Bottom = botMargin;
            btnTerminate.Bottom = botMargin;

        }
        
        private void SetTimerOn()
        {
            _dispatcherTimer = new DispatcherTimer();
            _dispatcherTimer.Tick += (sender, e) =>
            {
                TimerBox.Text = DateTime.Now.ToLongTimeString();
                CommandManager.InvalidateRequerySuggested();
            };
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            _dispatcherTimer.Start();
        }

        private void GrabMouseCoords(MouseEventArgs e)
        {
            _clicked = true;
            _lmAbs = e.GetPosition(this);
            _lmAbs.Y = Convert.ToInt16(Top) + _lmAbs.Y;
            _lmAbs.X = Convert.ToInt16(Left) + _lmAbs.X;
        }

        private void DragWindow(MouseEventArgs e)
        {
            if (!_clicked) return;
            Point mousePosition = e.GetPosition(this);

            var mousePositionAbs = new Point { X = Convert.ToInt16(Left) + mousePosition.X, Y = Convert.ToInt16(Top) + mousePosition.Y };

            Left = Left + (mousePositionAbs.X - _lmAbs.X);
            Top = Top + (mousePositionAbs.Y - _lmAbs.Y);
            _lmAbs = mousePositionAbs;
        }

        #endregion
    }
}
