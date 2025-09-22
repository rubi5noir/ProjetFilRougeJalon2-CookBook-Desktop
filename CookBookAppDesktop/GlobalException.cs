using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBookAppDesktop
{
    /// <summary>
    /// Classe statique pour centraliser la gestion des exceptions non gérées dans une application WinForms.
    /// Le branchement de ces gestionnaires d'exceptions doit être effectué dans Program.cs avant Application.Run().
    ///     - Application.ThreadException pour les exceptions dans le thread principal (UI).
    ///     - AppDomain.CurrentDomain.UnhandledException pour les exceptions dans les threads en arrière-plan (background threads).
    /// </summary>
    internal class GlobalException
    {


        /// <summary>
        /// Méthode appelée lorsqu'une exception non gérée survient dans le thread principal de l'interface utilisateur (UI).
        /// </summary>
        /// <param name="sender">L'objet source de l'événement.</param>
        /// <param name="e">Les arguments contenant l'exception.</param>
        public static void HandleThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Affiche un message d'erreur à l'utilisateur
            MessageBox.Show(
                $"Une erreur est survenue dans l'application :\n\n{e.Exception?.Message}",
                "Erreur d'application",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        /// <summary>
        /// Méthode appelée lorsqu'une exception non gérée survient dans un thread autre que le thread principal (background thread).
        /// </summary>
        /// <param name="sender">L'objet source de l'événement.</param>
        /// <param name="e">Les arguments contenant l'exception.</param>
        public static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            // Récupère l'exception
            Exception ex = e.ExceptionObject as Exception;

            // Affiche un message d'erreur à l'utilisateur
            MessageBox.Show(
                $"Une erreur critique est survenue :\n\n{ex?.Message}",
                "Erreur critique",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}

