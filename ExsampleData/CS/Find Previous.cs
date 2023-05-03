namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Find_Previous : PluginDynamicCommand
    {
        public Find_Previous()
        : base(displayName: "Find Previous", description: "Find Previous", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Find Previous", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F3, ModifierKey.Shift);
        }
    }
}
