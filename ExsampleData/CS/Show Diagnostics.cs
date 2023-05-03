namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Show_Diagnostics : PluginDynamicCommand
    {
        public Show_Diagnostics()
        : base(displayName: "Show Diagnostics", description: "Show Diagnostics", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Show Diagnostics", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyD, ModifierKey.Ctrl | ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
