using Syncfusion.ListView.XForms;
using Xamarin.Forms;

namespace WalletAPP.Utils
{
    public class SfSelectionController<TItem> : SelectionController where TItem : class
    {
        private readonly SfListView listView;
        private readonly Command<TItem> tapCommand;

        public SfSelectionController(SfListView listView, Command<TItem> tapCommand) : base(listView)
        {
            this.listView = listView;

            this.tapCommand = tapCommand;

        }

        protected override async void AnimateSelectedItem(ListViewItem selectedListViewItem)
        {
            var c = selectedListViewItem.Content;

            var q = c.BindingContext as TItem;

            listView.SelectedItems.Clear();

            tapCommand?.Execute(q);

        }

    }

    public static class SfSelectionControllerExtensions
    {
        public static void TapSelection<TItem>(this SfListView sfListView, Command<TItem> selectedCommand) where TItem : class
        {

            sfListView.SelectionMode = Syncfusion.ListView.XForms.SelectionMode.Single;
            sfListView.SelectionController = new SfSelectionController<TItem>(sfListView, selectedCommand);

        }
    }
}
