namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Move_Lines_Down : PluginDynamicCommand
    {
        public Move_Lines_Down()
        : base(displayName: "Move Lines Down", description: "Move Lines Down", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Move Lines Down", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowdown, ModifierKey.Alt);
        }
    }
}
