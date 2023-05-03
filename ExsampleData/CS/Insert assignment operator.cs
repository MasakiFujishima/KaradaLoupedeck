namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Insert_assignment_operator : PluginDynamicCommand
    {
        public Insert_assignment_operator()
        : base(displayName: "Insert assignment operator", description: "Insert assignment operator", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Insert assignment operator", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Minus, ModifierKey.Alt);
        }
    }
}
