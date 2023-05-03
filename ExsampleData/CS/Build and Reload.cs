namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Build_and_Reload : PluginDynamicCommand
    {
        public Build_and_Reload()
        : base(displayName: "Build and Reload", description: "Build and Reload", groupName: "Build")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Build.png")));
                bitmapBuilder.DrawText("Build and Reload", color: new BitmapColor(4,0,0));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyB, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
