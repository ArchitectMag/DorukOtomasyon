using System;
using SimpleInjector;
using System.Windows.Forms;
using SimpleInjector.Diagnostics;
using JobOrderStatusReport.Utilities.SimpleInjection;

namespace JobOrderStatusReport
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RegisterWindowsForms();
            Application.Run(DependencyContainer.Container.GetInstance<Main>());
        }

        private static void RegisterWindowsForms()
        {
            var types = DependencyContainer.Container.GetTypesToRegister<Form>(typeof(Program).Assembly);

            foreach (var type in types)
            {
                var registration = Lifestyle.Transient.CreateRegistration(type, DependencyContainer.Container);

                registration.SuppressDiagnosticWarning(DiagnosticType.DisposableTransientComponent,
                    "Formu dispot etmeyi unutma");

                DependencyContainer.Container.AddRegistration(type, registration);
            }
        }
    }
}