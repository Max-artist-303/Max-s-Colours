using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using MiraAPI.PluginLoading;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;

namespace MiraColourMod;

[BepInAutoPlugin("max.miracolours", "Max's Colours")]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[ReactorModFlags(ModFlags.RequireOnAllClients)]
public partial class ColourPlugin : BasePlugin, IMiraPlugin
{
    public string OptionsTitleText => "Max's Colours";

    public ConfigFile GetConfigFile() => Config;

    public override void Load()
    {
    }
}