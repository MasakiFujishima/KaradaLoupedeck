namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Stop_Debugging : PluginDynamicCommand
    {
        public Stop_Debugging()
        : base(displayName: "Stop Debugging", description: "Stop Debugging", groupName: "Debug")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Debug.png")));
                bitmapBuilder.DrawText("Stop Debugging", color: new BitmapColor(211,223,242));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F8, ModifierKey.Shift);
        }
    }
}
