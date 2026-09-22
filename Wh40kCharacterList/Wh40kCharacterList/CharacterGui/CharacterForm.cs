namespace Wh40kCharacterList.CharacterGui;

public partial class CharacterForm : Form
{
    private readonly CharacterFormManager _manager;

    public CharacterForm()
    {
        _manager = new();

        InitializeComponent();
    }
}
