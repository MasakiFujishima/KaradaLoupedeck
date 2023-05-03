namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Reflow_Comment : PluginDynamicCommand
    {
        public Reflow_Comment()
        : base(displayName: "Reflow Comment", description: "Reflow Comment", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Reflow Comment", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Oem2, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
