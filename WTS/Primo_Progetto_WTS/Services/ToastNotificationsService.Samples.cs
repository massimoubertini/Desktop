using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;

namespace Meteo.Services
{
    internal partial class ToastNotificationsService
    {
        public void ShowToastNotificationSample()
        {
            // creare il contenuto di toast
            var content = new ToastContent()
            {
                Launch = "ToastContentActivationParams",
                Visual = new ToastVisual()
                {
                    BindingGeneric = new ToastBindingGeneric()
                    {
                        Children =
                        {
                            new AdaptiveText()
                            {
                                Text = "Esempio di notifica toast"
                            },
                            new AdaptiveText()
                            {
                                 Text = @"Clic OK per vedere come l'attivazione da una notifica di toast può essere gestita in ToastNotificationService."
                            }
                        }
                    }
                },
                Actions = new ToastActionsCustom()
                {
                    Buttons =
                    {
                        new ToastButton("OK", "ToastButtonActivationArguments")
                        {
                            ActivationType = ToastActivationType.Foreground
                        },

                        new ToastButtonDismiss("Cancel")
                    }
                }
            };

            // aggiunge il contenuto al toast
            var toast = new ToastNotification(content.GetXml())
            {
                // imposta un identificatore univoco per questa notifica all'interno del gruppo di notifiche (opzionale)
                Tag = "ToastTag"
            };
            // visualizza il toast
            ShowToastNotification(toast);
        }
    }
}
