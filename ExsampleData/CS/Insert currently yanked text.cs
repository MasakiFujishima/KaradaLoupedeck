namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Insert_currently_yanked_text : PluginDynamicCommand
    {
        public Insert_currently_yanked_text()
        : base(displayName: "Insert currently yanked text", description: "Insert currently yanked text", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Insert currently yanked text", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyY, ModifierKey.Ctrl);
        }
    }
}
