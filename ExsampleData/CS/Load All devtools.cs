namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Load_All_devtools : PluginDynamicCommand
    {
        public Load_All_devtools()
        : base(displayName: "Load All devtools", description: "Load All devtools", groupName: "Build")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Build.png")));
                bitmapBuilder.DrawText("Load All devtools", color: new BitmapColor(4,0,0));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyL, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
