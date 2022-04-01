using Gem.Bindings;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WalletAPP.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WalletAPP.Views.Parts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationView : ContentView
    {
        public NotificationView()
        {
            InitializeComponent();
        }
    }

    public class NotificationViewModel : ViewModelBase
    {
        public NotificationViewModel(ViewModelBaseServices viewModelBaseServices) : base(viewModelBaseServices)
        {
        }

        public override async Task Load(INavigationParameters parameters = null)
        {
            Notifications = new List<Notification>
            {
                new Notification
                {
                    Title = "Notificacao 1",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "1",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 2",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "2",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 3",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "3",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 4",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "4",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 5",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "5",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 6",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "6",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 7",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "7",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 8",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "8",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 9",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "9",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 10",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "10",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 11",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "11",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 12",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "12",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
                new Notification
                {
                    Title = "Notificacao 13",
                    Content = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao",
                    Date = DateTimeOffset.Now,
                    IconUri = "https://ps.w.org/wp-notification-bell/assets/icon-256x256.png?rev=2439614",
                    Id = "13",
                    Resume = "NotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacaoNotificacao"
                },
            };
        }

        #region Bindings

        private List<Notification> _notifications;
        public List<Notification> Notifications
        {
            get { return _notifications; }
            set { SetProperty(ref _notifications, value); }
        }

        #endregion

    }
}