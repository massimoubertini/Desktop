using Meteo.Activation;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Notifications;

namespace Meteo.Services
{
    internal partial class ToastNotificationsService : ActivationHandler<ToastNotificationActivatedEventArgs>
    {
        public void ShowToastNotification(ToastNotification toastNotification)
        {
            try
            {
                ToastNotificationManager.CreateToastNotifier().Show(toastNotification);
            }
            catch (Exception)
            {
                /* l'aggiunta di ToastNotification può avere esito negativo in condizioni
                 * rare, gestire le eccezioni in base allo scenario */
            }
        }

        protected override async Task HandleInternalAsync(ToastNotificationActivatedEventArgs args)
        {
            /* gestire l'attivazione dalla notifica di tipo avviso popup, maggiori dettagli a
             *  https://docs.microsoft.com/windows/uwp/design/shell/tiles-and-notifications/send-local-toast */
            await Task.CompletedTask;
        }
    }
}
