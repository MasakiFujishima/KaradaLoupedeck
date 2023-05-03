namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Scroll_diff_view_Up : PluginDynamicCommand
    {
        public Scroll_diff_view_Up()
        : base(displayName: "Scroll diff view Up", description: "Scroll diff view Up", groupName: "Git/SVN")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Git/SVN.png")));
                bitmapBuilder.DrawText("Scroll diff view Up", color: new BitmapColor(181,56,34));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowup, ModifierKey.Ctrl);
        }
    }
}
