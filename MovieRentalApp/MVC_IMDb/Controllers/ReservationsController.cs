using MVC_IMDb.Models;
using MVC_IMDb.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_IMDb.Controllers
{
    public class ReservationsController
    {
        private ReservationsView view;
        private readonly UserModel model;
        private List<ReservationDAO> reservations;
        private ReservationModel reservationModel;


        public ReservationsController(UserModel _model,List<MovieDAO> movies)
        {

            model = _model;
            view = new ReservationsView();
            reservationModel = new ReservationModel(model,movies);


            reservations = reservationModel.GetReservations();


        }
        public void IniciarFormDeReservaDeFilme()
        {
            view.IniciarFormDeReservaDeFilme();
        }
    }
}
