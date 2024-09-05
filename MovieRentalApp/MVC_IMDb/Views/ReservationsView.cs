using MVC_IMDb.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_IMDb.Views
{
    public class ReservationsView
    {
        private FormReservations form;
        public ReservationsView() {

            form = new FormReservations(this);
        }
        public void IniciarFormDeReservaDeFilme()
        {
            form.ShowDialog();
        }
    }
}
