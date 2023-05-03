namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Execute_Next_Line : PluginDynamicCommand
    {
        public Execute_Next_Line()
        : base(displayName: "Execute Next Line", description: "Execute Next Line", groupName: "Debug")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Debug.png")));
                bitmapBuilder.DrawText("Execute Next Line", color: new BitmapColor(211,223,242));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F10, );
        }
    }
}
