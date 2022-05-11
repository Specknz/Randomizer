using System.Windows;
using Caliburn.Micro;
using Randomizer.Models;


namespace Randomizer.ViewModels
{
    public class ShellViewModel : Screen
    {
        public BindableCollection<ListDataModel> ListData { get; }
        public string TestText = "Hello";

        public ShellViewModel()
        {
            ListData = new BindableCollection<ListDataModel>(DataAccess.GetListDataModelCollecton());
        }

        public void GenerateData()
        {
            MessageBox.Show("Hello");
        }

    }   
}
