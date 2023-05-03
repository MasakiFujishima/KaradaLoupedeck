namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class New_document_except_on_Chrome_Windows : PluginDynamicCommand
    {
        public New_document_except_on_Chrome_Windows()
        : base(displayName: "New document except on Chrome Windows", description: "New document except on Chrome Windows", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("New document except on Chrome Windows", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyN, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
