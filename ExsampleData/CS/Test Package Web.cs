namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Test_Package_Web : PluginDynamicCommand
    {
        public Test_Package_Web()
        : base(displayName: "Test Package Web", description: "Test Package Web", groupName: "Build")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Build.png")));
                bitmapBuilder.DrawText("Test Package Web", color: new BitmapColor(4,0,0));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F7, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
