namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Unfold_Selected : PluginDynamicCommand
    {
        public Unfold_Selected()
        : base(displayName: "Unfold Selected", description: "Unfold Selected", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Unfold Selected", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyL, ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
