namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Jump_to_Matching_Brace_Paren : PluginDynamicCommand
    {
        public Jump_to_Matching_Brace_Paren()
        : base(displayName: "Jump to Matching Brace Paren", description: "Jump to Matching Brace Paren", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Jump to Matching Brace Paren", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyP, ModifierKey.Ctrl);
        }
    }
}
