using System.Windows;

namespace LAXApp.Commands
{
    internal class CreateMovieCommand : BaseCommand
    {
        public override void Execute(object? parameter)
        {
            MessageBox.Show("YAY");
        }
    }
}
