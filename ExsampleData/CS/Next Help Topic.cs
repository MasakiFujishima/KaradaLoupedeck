namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Next_Help_Topic : PluginDynamicCommand
    {
        public Next_Help_Topic()
        : base(displayName: "Next Help Topic", description: "Next Help Topic", groupName: "Help")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Help.png")));
                bitmapBuilder.DrawText("Next Help Topic", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F3, ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
