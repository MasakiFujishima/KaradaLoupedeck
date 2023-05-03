namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Insert_pipe_operator : PluginDynamicCommand
    {
        public Insert_pipe_operator()
        : base(displayName: "Insert pipe operator", description: "Insert pipe operator", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Insert pipe operator", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyM, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
