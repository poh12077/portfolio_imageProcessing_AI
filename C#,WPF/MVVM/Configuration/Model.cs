using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace Configuration
{
    class Table
    {
        public ObservableCollection<StorageServer> storageServerTable = new ObservableCollection<StorageServer>();
        public ObservableCollection<WorklistServer> worklistServerTable = new ObservableCollection<WorklistServer>();
    }

    class Model
    {
        #region link 
        
        General general = new General();
        public General GeneralProperty
        {
            set
            {
                general = value;
            }
            get
            {
                return general;
            }
        }


        private StorageServer selectedStorageServer;
        public StorageServer SelectedStorageServerProperty
        {
            set
            {
                selectedStorageServer = value;
            }
            get
            {
                return selectedStorageServer;
            }
        }

        private WorklistServer selectedWorklistServer;
        public WorklistServer SelectedWorklistServerProperty
        {
            set
            {
                selectedWorklistServer = value;
            }
            get
            {
                return selectedWorklistServer;
            }
        }

        //  public ObservableCollection<StorageServer> storageServerTable = new ObservableCollection<StorageServer>();
        Table table = new Table();
        public ObservableCollection<StorageServer> StorageServerTableProperty
        {
            set
            {
                table.storageServerTable = value;
            }
            get
            {
                return table.storageServerTable;
            }
        }

       // public ObservableCollection<WorklistServer> worklistServerTable = new ObservableCollection<WorklistServer>();
        public ObservableCollection<WorklistServer> WorklistServerTableProperty
        {
            set
            {
               table. worklistServerTable = value;
            }
            get
            {
                return table. worklistServerTable;
            }
        }
        #endregion
    }


    #region data
    class General 
    {
        public LanguageEnum Language { set; get; }
        public ToothNoNotationEnum ToothNoNotation { get; set; }
        public DoseUnitEnum DoseUnit { set; get; }
        public string LocalStoragePath { set; get; }
        public string InstitutionName { set; get; }
        public string Telephone { get; set; } //= "test";
        public string Fax { get; set; }
        public string Address { get; set; }
        public string Homepage { get; set; }
        public string Logo { get; set; }
        public ImageTypeEnum ImageType 
        {
            set;
            get; 
        }
        public double DefaultBrightness { get; set; }
        public double DefaultContrast { get; set; }
        public int WindowCenter { get; set; }
        public int WindowWidth { get; set; }
        public DeviceTypeEnum DeviceType { get; set; }
        public int ResolutionWidth { get; set; }
        public int ResolutionHeight { get; set; }
        public string CalibrationDataFilePath { get; set; }

    }

    class StorageServer
    {
        public string Alias { get; set; }
        public string CallingAeTitle { get; set; }
        public string CalledAeTitle { get; set; }
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public string CharacterSet { get; set; }

    }

    class WorklistServer
    {
        public string Alias { get; set; }
        public string CallingAeTitle { get; set; }
        public string CalledAeTitle { get; set; }
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public string CharacterSet { get; set; }
    }


    public enum LanguageEnum
    {
        English,
        Korean,

    }

    public enum ToothNoNotationEnum
    {
        FDI,
        Universal
    }

    public enum DoseUnitEnum
    {
        MGym2,
        Gycm2,
        DGycm2,
        UGym2,
        MGycm2
    }

    public enum ImageTypeEnum
    {
        Raw,
        EightBit
    }

    public enum DeviceTypeEnum
    {
        Fos,
        Gos


    }

    #endregion
}
