namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Delete_Word_Right : PluginDynamicCommand
    {
        public Delete_Word_Right()
        : base(displayName: "Delete Word Right", description: "Delete Word Right", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Delete Word Right", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(No Shortcut, );
        }
    }
}
