namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Run_current_document : PluginDynamicCommand
    {
        public Run_current_document()
        : base(displayName: "Run current document", description: "Run current document", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Run current document", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyR, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
