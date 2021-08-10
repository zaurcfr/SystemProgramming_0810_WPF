using IPluginDLL;
using System;

namespace PluginTwoDLL
{
    public class PluginTwo : IPlugin
    {
        public string Name { get; set; } = "Plugin Two";

        public void Action()
        {
            Console.WriteLine("Plugin Two");
        }
    }
}
