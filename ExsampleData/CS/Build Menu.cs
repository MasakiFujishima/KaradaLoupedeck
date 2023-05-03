namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Build_Menu : PluginDynamicCommand
    {
        public Build_Menu()
        : base(displayName: "Build Menu", description: "Build Menu", groupName: "Main Menu (Server)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Main Menu (Server).png")));
                bitmapBuilder.DrawText("Build Menu", color: new BitmapColor(247,249,230));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyB, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
