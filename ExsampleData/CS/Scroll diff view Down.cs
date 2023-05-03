namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Scroll_diff_view_Down : PluginDynamicCommand
    {
        public Scroll_diff_view_Down()
        : base(displayName: "Scroll diff view Down", description: "Scroll diff view Down", groupName: "Git/SVN")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Git/SVN.png")));
                bitmapBuilder.DrawText("Scroll diff view Down", color: new BitmapColor(181,56,34));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowdown, ModifierKey.Ctrl);
        }
    }
}
