using Basalt;
using Basalt.Core.Plugins;

[assembly: Plugin("ExamplePlugin", "1.0.0", Authors = ["BasaltBE", "AnyBananaGAME"], EntryTypeName = "ExamplePlugin.ExamplePlugin")]

namespace ExamplePlugin;

public sealed class ExamplePlugin : Plugin
{
  public override void OnLoad()
  {
    Logger.Info($"{Description.Name} loaded.");
  }

  public override void OnStart()
  {
    Logger.Info($"{Description.Name} started.");
  }

  public override void OnDisable()
  {
    Logger.Info($"{Description.Name} disabled.");
  }
}
