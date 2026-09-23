using Wh40kCharacterList.Core.IngameEntities;
using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

namespace Wh40kCharacterList.CharacterGui;

internal class LogPanelGuiManagment
{
    public required CharacterFormManager CharacterFormManager { get; init; }


    public void AddText(string text)
    {
        CharacterFormManager.Form.LogLabel.Text += text + '\n';
        ScrollLogToBottom();
    }

    private void ScrollLogToBottom()
    {
        CharacterFormManager.Form.LogPanel.PerformLayout();
        CharacterFormManager.Form.LogPanel.AutoScrollPosition = new Point(
            0, 
            CharacterFormManager.Form.LogPanel.DisplayRectangle.Height
            );
    }

}