using Microsoft.Extensions.DependencyInjection;
using Phonebook.Application.Interfaces.Contexts;
using Phonebook.Application.Services.AddNewContact;
using Phonebook.Application.Services.DeleteContact;
using Phonebook.Application.Services.EditContact;
using Phonebook.Application.Services.GetContactDetail;
using Phonebook.Application.Services.GetListContact;
using Phonebook.Endpoint.Forms;
using Phonebook.Persistence.Context;

namespace Phonebook.Endpoint
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var service = new ServiceCollection();
            service.AddScoped<IDatabaseContext, DatabaseContext>();
            service.AddScoped<IAddNewContactService, AddNewContactService>();
            service.AddScoped<IGetContactListService, GetContactListService>();
            service.AddScoped<IDeleteContactService, DeleteContactService>();
            service.AddScoped<IGetContactDetailService, GetContactDetailService>();
            service.AddScoped<IEditContactService, EditContactService>();

            service.AddDbContext<DatabaseContext>();

            ServiceProvider = service.BuildServiceProvider();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureServices();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);

            var getContactListService = (IGetContactListService) ServiceProvider.GetService(typeof(IGetContactListService));
            var deleteContactService = (IDeleteContactService) ServiceProvider.GetService(typeof(IDeleteContactService));
            var getContactDetailService = (IGetContactDetailService) ServiceProvider.GetService(typeof(IGetContactDetailService));
            var editContactService = (IEditContactService) ServiceProvider.GetService(typeof(IEditContactService));

            System.Windows.Forms.Application.Run(new MainForm(getContactListService, deleteContactService, getContactDetailService, editContactService));
        }
    }
}