using System;

namespace IPluginDLL
{
    public interface IPlugin
    {
        public string Name { get; set; }
        void Action();
    }
}
