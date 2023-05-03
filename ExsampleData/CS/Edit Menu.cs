namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Edit_Menu : PluginDynamicCommand
    {
        public Edit_Menu()
        : base(displayName: "Edit Menu", description: "Edit Menu", groupName: "Main Menu (Server)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Main Menu (Server).png")));
                bitmapBuilder.DrawText("Edit Menu", color: new BitmapColor(247,249,230));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyE, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
