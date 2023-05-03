namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Shrink_selection : PluginDynamicCommand
    {
        public Shrink_selection()
        : base(displayName: "Shrink selection", description: "Shrink selection", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Shrink selection", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowdown, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
