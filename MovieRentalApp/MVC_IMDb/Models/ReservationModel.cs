using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;

namespace MVC_IMDb.Models
{
    public class ReservationModel //: IRequest
    {
        private List<ReservationDAO> reservations;

        private List<MovieDAO> movies;

        private UserModel user;
        //private string movieID;
        public ReservationModel(UserModel _user, List<MovieDAO> movies)
        {
            //movieID = _movieId;
            user = _user;


            reservations = new List<ReservationDAO>();


            ///ler de json
            string jsonFile = System.IO.Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + @"\BaseDeDados\filmesrequisitados.json";
            string json = File.ReadAllText(jsonFile);
            List<ReservationDAO> tempreservations = JsonConvert.DeserializeObject<List<ReservationDAO>>(json);

            reservations = new List<ReservationDAO>();
            if (tempreservations != null)
            {

                foreach (ReservationDAO reservation in tempreservations)
                {
                    if (reservation.userID == user.GetUserId())
                        reservations.Add(reservation);
                }
            }

            this.movies = movies;

        }

        /*public List<Tuple<string, string>> GetRequestById(int RequestId)
        {
            List<Tuple<string, string>> result = new List<Tuple<string, string>>();

            Request request = requests.FirstOrDefault(r => r.Id == RequestId);
            if (request != null)
            {
                result.Add(new Tuple<string, string>("MovieId", request.MovieId.ToString()));
                result.Add(new Tuple<string, string>("UserId", request.UserId.ToString()));
                result.Add(new Tuple<string, string>("StartDate", request.StartDate.ToString()));
                result.Add(new Tuple<string, string>("EndDate", request.EndDate.ToString()));
                result.Add(new Tuple<string, string>("IsActive", request.IsActive.ToString()));
            }

            return result;
        }*/

        public List<ReservationDAO> GetReservations()
        {
            return reservations;
        }

        
    }
}
