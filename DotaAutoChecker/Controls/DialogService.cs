using System.Windows;
using DotaAutoChecker.Interfaces;
using DotaAutoChecker.Properties;
using Microsoft.Win32;

namespace DotaAutoChecker.Controls
{
    public class DialogService: IDialogService
    {
        delegate void SavePathDlg();
        private readonly SavePathDlg _spd;
        public string FilePath { get; set; }

        public DialogService()
        {
            _spd = SavePath;
        }

        public bool OpenFileDialog()
        {
            var openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() != true) return false;
            FilePath = openFileDialog.FileName;
            _spd.Invoke();
            return true;

        }

        public bool SaveFileDialog()
        {
            var saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() != true) return false;
            FilePath = saveFileDialog.FileName;
            return true;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void SavePath()
        {
            Settings.Default.ConfigPath = FilePath;
        }
    }
}
