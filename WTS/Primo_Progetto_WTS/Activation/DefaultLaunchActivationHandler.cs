using Meteo.Helpers;
using Meteo.Services;
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace Meteo.Activation
{
    internal class DefaultLaunchActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
    {
        private readonly Type _navElement;

        public DefaultLaunchActivationHandler(Type navElement)
        {
            _navElement = navElement;
        }

        protected override async Task HandleInternalAsync(LaunchActivatedEventArgs args)
        {
            /* quando lo stack di navigazione non è ripristinato, passare alla prima pagina e
             * la nuova pagina passando le informazioni richieste nel parametro di navigazione */
            NavigationService.Navigate(_navElement, args.Arguments);
            /* rimuovere o modificare questo esempio che mostra una notifica
             * di tipo avviso popup quando è  avviata l'app, puoi usare questo esempio
             * per creare notifiche di tipo avviso popup dove necessario nella tua app  */
            Singleton<ToastNotificationsService>.Instance.ShowToastNotificationSample();
            await Task.CompletedTask;
        }

        protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
        {
            // nessuno dei ActivationHandlers ha gestito l'attivazione dell'app
            return NavigationService.Frame.Content == null;
        }
    }
}
