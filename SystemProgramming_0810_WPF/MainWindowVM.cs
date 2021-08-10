using IPluginDLL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using PropertyChanged;

namespace SystemProgramming_0810_WPF
{
    [AddINotifyPropertyChangedInterface]
    class MainWindowVM
    {
        public ObservableCollection<IPlugin> Plugins { get; set; } = new ObservableCollection<IPlugin>();
        public IPlugin SelectedPlugin { get; set; }
        public MainWindowVM()
        {
            LoadAllPlugins();
        }

        void LoadAllPlugins()
        {
            var files = Directory.GetFiles("Extensions");
            var assemblies = new ObservableCollection<Assembly>();
            foreach (var f in files.Where(x => x.EndsWith(".dll")))
            {
                var assembly = Assembly.LoadFile(Directory.GetCurrentDirectory() + "\\" + f);
                foreach (var type in assembly.GetTypes().Where(x => x.GetInterface("IPlugin") != null))
                {
                    Plugins.Add(Activator.CreateInstance(type) as IPlugin);
                }
            }
        }
    }
}
