namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Delete_to_Line_End : PluginDynamicCommand
    {
        public Delete_to_Line_End()
        : base(displayName: "Delete to Line End", description: "Delete to Line End", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Delete to Line End", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(No Shortcut, );
        }
    }
}
