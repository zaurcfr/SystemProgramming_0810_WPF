using IPluginDLL;
using System;

namespace PluginOneDLL
{
    public class PluginOne : IPlugin
    {
        public string Name { get; set; } = "Plugin One";

        public void Action()
        {
            Console.WriteLine("Plugin One");
        }
    }
}
