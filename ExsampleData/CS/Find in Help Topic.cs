namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Find_in_Help_Topic : PluginDynamicCommand
    {
        public Find_in_Help_Topic()
        : base(displayName: "Find in Help Topic", description: "Find in Help Topic", groupName: "Help")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Help.png")));
                bitmapBuilder.DrawText("Find in Help Topic", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyF, ModifierKey.Ctrl);
        }
    }
}
