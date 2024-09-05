using System.Collections.Generic;
using System;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System.Net;
using MVC_IMDb.Exceptions;

namespace MVC_IMDb.Models
{
    public class MovieModel : IMovie
    {
        private List<MovieDAO> movies;

        private string[] APIDetails;
        public MovieModel()
        {
            movies = new List<MovieDAO>();

            APIDetails = new string[]{ "0ab08e0c67mshffb3b06c602a751p121aa2jsn3a6320e01f63", "online-movie-database.p.rapidapi.com" };
        }

        // Busca um filme da lista de strings por id
        public MovieDAO? GetMovieByIndex(int indice)
        {
            if(indice >= movies.Count)
                return null;

            return movies[indice];
        }
        // Busca um filme da lista de strings por id
        public MovieDAO? GetMovieById(string MovieId)
        {
            return movies.FirstOrDefault(m => m.Id == MovieId);
        }
        // Busca uma lista de 20 filmes
        public void CarregarFilmes()
        {
            using (var client = new HttpClient())
            {
                int filmesCount = 0;
                string[]? titles = null;

                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://online-movie-database.p.rapidapi.com/title/get-most-popular-movies?currentCountry=PT"),
                    Headers =
                    {
                        { "X-RapidAPI-Key", APIDetails[0] },
                        { "X-RapidAPI-Host", APIDetails[1] },
                    },
                };

                using (var response = client.SendAsync(request).GetAwaiter().GetResult())
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                        if (!string.IsNullOrEmpty(responseBody))
                            titles = JsonConvert.DeserializeObject<string[]>(responseBody);
                    }
                    else
                    {
                        ExceptionAPI.ThrowGetMoviesListException((int)response.StatusCode);
                    }
                }

                if (titles != null)
                {
                    foreach (var title in titles)
                    {
                        if (filmesCount >= 1)
                            break;

                        var newRequest = new HttpRequestMessage
                        {
                            Method = HttpMethod.Get,
                            RequestUri = new Uri("https://online-movie-database.p.rapidapi.com/title/get-details?tconst=" + title.Remove(0, 7)),
                            Headers =
                            {
                                { "X-RapidAPI-Key", APIDetails[0] },
                                { "X-RapidAPI-Host", APIDetails[1] },
                            },
                        };

                        using (var newResponse = client.SendAsync(newRequest).GetAwaiter().GetResult())
                        {
                            if (newResponse.IsSuccessStatusCode)
                            {
                                var body = newResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                                MovieDAO? filme = JsonConvert.DeserializeObject<MovieDAO>(body);
                                if (filme != null && filme.TitleType != null && filme.TitleType.Equals("movie"))
                                {
                                    movies.Add(filme);
                                    filmesCount++;
                                }
                            }
                        }
                    }
                }
            }
        }


        // Busca detalhes de um filme
        public MovieDAO? MovieDetails(string titulo)
        {
            var clientDetail = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://online-movie-database.p.rapidapi.com/title/get-details?tconst=" + titulo),
                Headers =
                {
                    { "X-RapidAPI-Key", APIDetails[0] },
                    { "X-RapidAPI-Host", APIDetails[1] },
                },
            };
            using (var response = clientDetail.SendAsync(request).GetAwaiter().GetResult())
            {
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                    if (!string.IsNullOrEmpty(responseBody))
                        return JsonConvert.DeserializeObject<MovieDAO>(responseBody);

                }
            }
            return null;
        }
        // Procura um filme
        public void SearchMovie(string nome)
        {
            //var clientSearch = new HttpClient();
            //var request = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri("https://online-movie-database.p.rapidapi.com/auto-complete?q=" + nome),
            //    Headers =
            //    {
            //        { "X-RapidAPI-Key", "4f927a2bdfmsh7aeab4b45cc241ap1778e9jsnd9c38ab56ef9" },
            //        { "X-RapidAPI-Host", "online-movie-database.p.rapidapi.com" },
            //    },
            //};

            //using (var response = clientSearch.SendAsync(request).GetAwaiter().GetResult())
            //{
            //    response.EnsureSuccessStatusCode();
            //    var body = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            //    string respostaJson = body;
            //    var result = JsonConvert.DeserializeObject<RootSearchObject>(respostaJson);
            //    return result;
            //}
        }


        // Tramsforma o ImageDAO numa imagem
        public static Image CreateImage(ImageDAO img)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] imageData = webClient.DownloadData(img.Url);

                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(memoryStream);

                    // Resize the image to the specified width and height
                    image = new Bitmap(image, img.Width, img.Height);

                    return image;
                }
            }
        }
        public List<MovieDAO> GetFilmes()
        {
            return movies;
        }
    }
}
