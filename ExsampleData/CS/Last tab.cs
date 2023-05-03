namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Last_tab : PluginDynamicCommand
    {
        public Last_tab()
        : base(displayName: "Last tab", description: "Last tab", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Last tab", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F12, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
