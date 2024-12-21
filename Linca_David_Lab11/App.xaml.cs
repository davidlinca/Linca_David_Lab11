namespace Linca_David_Lab11;
using Linca_David_Lab11.Data;

    public partial class App : Application
{
    public static ShoppingListDatabase Database { get; private set; }
    public App()
    {
        Database = new ShoppingListDatabase(new RestService());
        MainPage = new NavigationPage(new ListEntryPage());
    }
}
