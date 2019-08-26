using Meteo.Activation;
using Meteo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Meteo.Services
{
    internal class ActivationService
    {
        private readonly App _app;
        private readonly Lazy<UIElement> _shell;
        private readonly Type _defaultNavItem;

        public ActivationService(App app, Type defaultNavItem, Lazy<UIElement> shell = null)
        {
            _app = app;
            _shell = shell;
            _defaultNavItem = defaultNavItem;
        }

        public async Task ActivateAsync(object activationArgs)
        {
            if (IsInteractive(activationArgs))
            {
                /* inizializzare elementi come la registrazione dell'attività
                 * in background prima del caricamento dell'app */
                await InitializeAsync();
                /* non ripetere l'inizializzazione dell'app quando la finestra ha già contenuto,
                 * basta assicurarsi che la finestra è attiva */
                if (Window.Current.Content == null)
                {
                    // crea un frame che funge da contesto di navigazione e passa alla prima pagina
                    Window.Current.Content = _shell?.Value ?? new Frame();
                }
            }
            var activationHandler = GetActivationHandlers()
                                                .FirstOrDefault(h => h.CanHandle(activationArgs));
            if (activationHandler != null)
                await activationHandler.HandleAsync(activationArgs);
            if (IsInteractive(activationArgs))
            {
                var defaultHandler = new DefaultLaunchActivationHandler(_defaultNavItem);
                if (defaultHandler.CanHandle(activationArgs))
                    await defaultHandler.HandleAsync(activationArgs);
                // assicurarsi che la finestra corrente sia attiva
                Window.Current.Activate();
                // tasks dopo l'attivazione
                await StartupAsync();
            }
        }

        private async Task InitializeAsync()
        {
            await ThemeSelectorService.InitializeAsync();
        }

        private async Task StartupAsync()
        {
            await ThemeSelectorService.SetRequestedThemeAsync();
        }

        private IEnumerable<ActivationHandler> GetActivationHandlers()
        {
            yield return Singleton<ToastNotificationsService>.Instance;
        }

        private bool IsInteractive(object args)
        {
            return args is IActivatedEventArgs;
        }
    }
}
