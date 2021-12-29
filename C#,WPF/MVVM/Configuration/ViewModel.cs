using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Configuration
{
    class ViewModel : INotifyPropertyChanged
    {
        Model model = new Model();
        public Model ModelProperty
        {
            set
            {
                model = value;
                NotifyPropertyChanged("ModelProperty");
            }
            get
            {
                return model;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            //if (this.PropertyChanged != null)
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public ICommand MyCommandSave { get; set; }
         public ICommand MyCommandLoad { get; set; }
         public ICommand CommandStorageServerAdd { get; set; }
         public ICommand CommandWorklistServerAdd { get; set; }


        public ViewModel()
        {
            //  ViewModel viewModel = new ViewModel();
            MyCommandSave = new Command(ExecuteMethodSave, CanExecuteMethod);
            MyCommandLoad = new Command(ExecuteMethodLoad, CanExecuteMethod);
            CommandStorageServerAdd = new Command(StorageServerAdd, CanExecuteMethod);
            CommandWorklistServerAdd = new Command(WorklistServerAdd, CanExecuteMethod);
        }

        public void WorklistServerAdd(object obj)
        {
            AddNetwork addNetwork = new AddNetwork();
            WorklistServer worklistServer = new WorklistServer();

            if (addNetwork.ShowDialog() == true)
            {
                try
                {
                    worklistServer.Alias = addNetwork.alias.Text;
                    worklistServer.CalledAeTitle = addNetwork.calledAeTitle.Text;
                    worklistServer.CallingAeTitle = addNetwork.callingAeTitle.Text;
                    worklistServer.IPAddress = addNetwork.iPAddress.Text;
                    worklistServer.Port = Convert.ToInt32(addNetwork.port.Text);
                    worklistServer.CharacterSet = addNetwork.characterSet.Text;

                    model.WorklistServerTableProperty.Add(worklistServer);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void StorageServerAdd(object obj)
        {
            AddNetwork addNetwork = new AddNetwork();
            StorageServer storageServer = new StorageServer();

            if (addNetwork.ShowDialog() == true)
            {
                try
                {
                    storageServer.Alias = addNetwork.alias.Text;
                    storageServer.CalledAeTitle = addNetwork.calledAeTitle.Text;
                    storageServer.CallingAeTitle = addNetwork.callingAeTitle.Text;
                    storageServer.IPAddress = addNetwork.iPAddress.Text;
                    storageServer.Port = Convert.ToInt32(addNetwork.port.Text);
                    storageServer.CharacterSet = addNetwork.characterSet.Text;

                    model.StorageServerTableProperty.Add(storageServer);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public bool CanExecuteMethod(object arg)
        {
            return true;
        }


        public void ExecuteMethodSave(object obj)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(model);
                string filePath = "configuration.json";

                using (StreamWriter streamWriter = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    streamWriter.Write(jsonString);
                }
                MessageBox.Show("configuration.json file Saved");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public void ExecuteMethodLoad(object obj)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                // Nullable<bool> result = openFileDialog.ShowDialog();
                bool? result = openFileDialog.ShowDialog();
                string filePath = "";

                if (result == true)
                {
                    filePath = openFileDialog.FileName;
                }

                string jsonString;
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    jsonString = streamReader.ReadToEnd();
                }

                try
                {
                    ModelProperty = JsonConvert.DeserializeObject<Model>(jsonString);
                    MessageBox.Show("loaded");
                }
                catch (Exception e)
                {
                    string fileName = "DefaultConfiguration.json";
                    filePath = Path.GetFullPath(fileName);
                    using (StreamReader streamReader = new StreamReader(filePath))
                    {
                        jsonString = streamReader.ReadToEnd();
                    }
                    ModelProperty = JsonConvert.DeserializeObject<Model>(jsonString);

                    MessageBox.Show(e.Message);
                    MessageBox.Show("default configuration loaded");
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


    }
}
