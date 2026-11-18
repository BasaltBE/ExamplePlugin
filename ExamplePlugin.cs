using BasaltBE.Plugins;

namespace Example;

public sealed class ExamplePlugin : Plugin {
    public override void OnEnable() {
        Logger.Info("Plugin enabled.");
    }
}