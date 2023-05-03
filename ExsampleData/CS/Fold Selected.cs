namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Fold_Selected : PluginDynamicCommand
    {
        public Fold_Selected()
        : base(displayName: "Fold Selected", description: "Fold Selected", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Fold Selected", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyL, ModifierKey.Alt);
        }
    }
}
