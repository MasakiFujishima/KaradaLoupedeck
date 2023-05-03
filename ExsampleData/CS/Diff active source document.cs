namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Diff_active_source_document : PluginDynamicCommand
    {
        public Diff_active_source_document()
        : base(displayName: "Diff active source document", description: "Diff active source document", groupName: "Git/SVN")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Git/SVN.png")));
                bitmapBuilder.DrawText("Diff active source document", color: new BitmapColor(181,56,34));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyD, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
