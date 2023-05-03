namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Reformat_Selection : PluginDynamicCommand
    {
        public Reformat_Selection()
        : base(displayName: "Reformat Selection", description: "Reformat Selection", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Reformat Selection", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyA, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
