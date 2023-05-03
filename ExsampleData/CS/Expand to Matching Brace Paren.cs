namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Expand_to_Matching_Brace_Paren : PluginDynamicCommand
    {
        public Expand_to_Matching_Brace_Paren()
        : base(displayName: "Expand to Matching Brace Paren", description: "Expand to Matching Brace Paren", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Expand to Matching Brace Paren", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyE, ModifierKey.Ctrl | ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
