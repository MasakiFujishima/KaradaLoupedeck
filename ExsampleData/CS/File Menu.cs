namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class File_Menu : PluginDynamicCommand
    {
        public File_Menu()
        : base(displayName: "File Menu", description: "File Menu", groupName: "Main Menu (Server)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Main Menu (Server).png")));
                bitmapBuilder.DrawText("File Menu", color: new BitmapColor(247,249,230));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyF, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
