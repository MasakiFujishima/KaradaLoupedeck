namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Copy_Lines_Down : PluginDynamicCommand
    {
        public Copy_Lines_Down()
        : base(displayName: "Copy Lines Down", description: "Copy Lines Down", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Copy Lines Down", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowdown, ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
