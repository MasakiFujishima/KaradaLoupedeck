namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Previous_tab_desktop : PluginDynamicCommand
    {
        public Previous_tab_desktop()
        : base(displayName: "Previous tab desktop", description: "Previous tab desktop", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Previous tab desktop", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Tab, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
