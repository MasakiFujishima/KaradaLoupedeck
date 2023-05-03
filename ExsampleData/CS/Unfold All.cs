namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Unfold_All : PluginDynamicCommand
    {
        public Unfold_All()
        : base(displayName: "Unfold All", description: "Unfold All", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Unfold All", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyO, ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
