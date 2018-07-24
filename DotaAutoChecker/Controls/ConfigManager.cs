using System;
using System.IO;
using System.Text;
using System.Windows.Input;
using DotaAutoChecker.Exceptions;
using DotaAutoChecker.Interfaces;

namespace DotaAutoChecker.Controls
{
    public class ConfigManager: IConfigManager
    {
        private readonly string _distanceConfig = "dota_camera_distance\0";
        private string _config;

        public string DoMagic(string path)
        {
            var dtStart = DateTime.Now;
            LoadFileInMemory(path);
            string result = $"Loading {(DateTime.Now - dtStart).TotalSeconds}s. ";

            dtStart = DateTime.Now;
            FindAndReplaceConfig(path);
            Clear();
            result += $"Reading {(DateTime.Now - dtStart).TotalSeconds}s.";

            return result;
        }

        public string GetCameraDistanceValue(string path)
        {
            LoadFileInMemory(path);
            string result = ReadingDistanceParameter(GetParameterIndex());
            Clear();

            return result;
        }

        #region Helpers

        private void LoadFileInMemory(string path) => _config = Encoding.Default.GetString(File.ReadAllBytes(path));

        private void FindAndReplaceConfig(string path)
        {
            FindAndReplaceDistanceValue();
            SaveBinary(path);
        }

        private void FindAndReplaceDistanceValue()
        {
            int index = GetParameterIndex();
            ReplaceDistanceValue(index);
        }

        private int GetParameterIndex()
        {
            int index = 0;
            int result = -1;
            bool repeat = false;

            if (!_config.Contains(_distanceConfig)) throw new NoMatchesException();

            while ((index = _config.IndexOf(_distanceConfig, index, StringComparison.Ordinal)) != -1)
            {
                repeat = !repeat;
                result = index;
                index += _distanceConfig.Length;
                if (!repeat) throw new UnexpectedValueException();
            }

            if (result == -1) throw new WrongIndexException();

            return result;
        }

        private void ReplaceDistanceValue(int index) => _config = _config.Remove(index + 24, 4).Insert(index + 24, 1600.ToString());

        private void SaveBinary(string path) => File.WriteAllBytes(path, Encoding.Default.GetBytes(_config));

        private string ReadingDistanceParameter(int index)
        {
            return _config.Substring(index + 24, 4);
        }

        private void Clear()
        {
            _config = null;
            GC.Collect();
        }

        #endregion

    }
}
