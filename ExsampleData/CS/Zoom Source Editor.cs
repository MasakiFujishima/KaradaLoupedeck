namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Source_Editor : PluginDynamicCommand
    {
        public Zoom_Source_Editor()
        : base(displayName: "Zoom Source Editor", description: "Zoom Source Editor", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Source Editor", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad1, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
