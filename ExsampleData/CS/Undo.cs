namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Undo : PluginDynamicCommand
    {
        public Undo()
        : base(displayName: "Undo", description: "Undo", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Undo", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyZ, ModifierKey.Ctrl);
        }
    }
}
