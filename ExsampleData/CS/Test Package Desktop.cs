namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Test_Package_Desktop : PluginDynamicCommand
    {
        public Test_Package_Desktop()
        : base(displayName: "Test Package Desktop", description: "Test Package Desktop", groupName: "Build")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Build.png")));
                bitmapBuilder.DrawText("Test Package Desktop", color: new BitmapColor(4,0,0));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyT, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
