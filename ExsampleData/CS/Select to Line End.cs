namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Select_to_Line_End : PluginDynamicCommand
    {
        public Select_to_Line_End()
        : base(displayName: "Select to Line End", description: "Select to Line End", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Select to Line End", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowright, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
