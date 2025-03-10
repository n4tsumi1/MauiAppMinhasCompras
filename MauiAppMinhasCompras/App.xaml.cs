﻿using MauiAppMinhasCompras.Helpers;

namespace MauiAppMinhasCompras
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper? _db;

        public static SQLiteDatabaseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "banco_sqlite_compras.db3");

                    _db = new SQLiteDatabaseHelper(path);
                }

                return _db;
            }
        }

        public App()
        {
            InitializeComponent();
            // Removemos a linha MainPage = ... para evitar o warning.
        }

        // Método moderno que substitui o uso de MainPage
        protected override Window CreateWindow(IActivationState activationState) => new Window(new NavigationPage(new Views.ListaProduto()));
    }
}
