using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
