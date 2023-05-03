namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Move_Lines_Up : PluginDynamicCommand
    {
        public Move_Lines_Up()
        : base(displayName: "Move Lines Up", description: "Move Lines Up", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Move Lines Up", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowup, ModifierKey.Alt);
        }
    }
}
