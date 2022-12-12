namespace Restrnt;

public partial class AddCart : ContentPage
{
	String cText;
	int cVal;

    public AddCart(String Text, int val)
	{
		
		InitializeComponent();
		this.cText = Text;
		this.cVal = val;
	}
}
