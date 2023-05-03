namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Select_to_Line_Start : PluginDynamicCommand
    {
        public Select_to_Line_Start()
        : base(displayName: "Select to Line Start", description: "Select to Line Start", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Select to Line Start", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowleft, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
