namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Sync_Editor___PDF_Preview : PluginDynamicCommand
    {
        public Sync_Editor___PDF_Preview()
        : base(displayName: "Sync Editor   PDF Preview", description: "Sync Editor   PDF Preview", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Sync Editor   PDF Preview", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F8, ModifierKey.Ctrl);
        }
    }
}
