namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Select_Word_Right : PluginDynamicCommand
    {
        public Select_Word_Right()
        : base(displayName: "Select Word Right", description: "Select Word Right", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Select Word Right", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowright, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
