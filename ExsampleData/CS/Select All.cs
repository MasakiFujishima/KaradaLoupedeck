namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Select_All : PluginDynamicCommand
    {
        public Select_All()
        : base(displayName: "Select All", description: "Select All", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Select All", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyA, ModifierKey.Ctrl);
        }
    }
}
