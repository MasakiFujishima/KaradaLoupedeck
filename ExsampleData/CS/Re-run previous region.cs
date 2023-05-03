namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Re-run_previous_region : PluginDynamicCommand
    {
        public Re-run_previous_region()
        : base(displayName: "Re-run previous region", description: "Re-run previous region", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Re-run previous region", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyP, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
