namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Switch_to_tab : PluginDynamicCommand
    {
        public Switch_to_tab()
        : base(displayName: "Switch to tab", description: "Switch to tab", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Switch to tab", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Period, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
