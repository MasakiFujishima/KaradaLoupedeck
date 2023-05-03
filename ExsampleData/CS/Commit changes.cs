namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Commit_changes : PluginDynamicCommand
    {
        public Commit_changes()
        : base(displayName: "Commit changes", description: "Commit changes", groupName: "Git/SVN")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Git/SVN.png")));
                bitmapBuilder.DrawText("Commit changes", color: new BitmapColor(181,56,34));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyM, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
