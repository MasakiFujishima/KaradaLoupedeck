namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Next_tab : PluginDynamicCommand
    {
        public Next_tab()
        : base(displayName: "Next tab", description: "Next tab", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Next tab", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F12, ModifierKey.Ctrl);
        }
    }
}
