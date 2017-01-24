// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="">
//   
// </copyright>
// <summary>
//   Interaction logic for MainWindow.xaml
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SolarSystem
{
    using System.Windows;

    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The _data.
        /// </summary>
        private readonly OrbitsCalculator _data = new OrbitsCalculator();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.DataContext = this._data;
            this.InitializeComponent();
        }

        /// <summary>
        /// The main window_ loaded.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this._data.StartTimer();
        }

        /// <summary>
        /// The pause_ checked.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Pause_Checked(object sender, RoutedEventArgs e)
        {
            this._data.Pause(true);
        }

        /// <summary>
        /// The pause_ unchecked.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void Pause_Unchecked(object sender, RoutedEventArgs e)
        {
            this._data.Pause(false);
        }
    }
}