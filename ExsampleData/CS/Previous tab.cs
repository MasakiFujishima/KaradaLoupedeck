namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Previous_tab : PluginDynamicCommand
    {
        public Previous_tab()
        : base(displayName: "Previous tab", description: "Previous tab", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Previous tab", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F11, ModifierKey.Ctrl);
        }
    }
}
