namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Jump_to_Word_Left : PluginDynamicCommand
    {
        public Jump_to_Word_Left()
        : base(displayName: "Jump to Word Left", description: "Jump to Word Left", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Jump to Word Left", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowleft, ModifierKey.Ctrl);
        }
    }
}
