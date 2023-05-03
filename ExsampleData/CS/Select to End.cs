namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Select_to_End : PluginDynamicCommand
    {
        public Select_to_End()
        : base(displayName: "Select to End", description: "Select to End", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Select to End", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(End, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
