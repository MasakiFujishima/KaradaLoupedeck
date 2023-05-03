namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Previous_Help_Topic : PluginDynamicCommand
    {
        public Previous_Help_Topic()
        : base(displayName: "Previous Help Topic", description: "Previous Help Topic", groupName: "Help")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Help.png")));
                bitmapBuilder.DrawText("Previous Help Topic", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F2, ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
