namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Next_tab_desktop : PluginDynamicCommand
    {
        public Next_tab_desktop()
        : base(displayName: "Next tab desktop", description: "Next tab desktop", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Next tab desktop", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Tab, ModifierKey.Ctrl);
        }
    }
}
