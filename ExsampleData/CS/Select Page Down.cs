namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Select_Page_Down : PluginDynamicCommand
    {
        public Select_Page_Down()
        : base(displayName: "Select Page Down", description: "Select Page Down", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Select Page Down", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Pagearrowdown, ModifierKey.Shift);
        }
    }
}
