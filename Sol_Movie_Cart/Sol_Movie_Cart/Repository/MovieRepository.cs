using Sol_Movie_Cart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Movie_Cart.Repository
{

    public interface IMovieRepository
    {
        Task<IEnumerable<MovieModel>> GetListOfMoviesAsync();
    }


    public class MovieRepository : IMovieRepository
    {
        public async Task<IEnumerable<MovieModel>> GetListOfMoviesAsync()
        {
            return await Task.Run(() => {

                var listOfMovie = new List<MovieModel>()
                {
                    new MovieModel()
                    {
                        id=1,
                        title="Mardaani 2",
                        details="Shivani Shivaji Roy locks horns with the devil incarnate, a young and remorseless serial killer who is raping and murdering young women.",
                        url="https://m.media-amazon.com/images/M/MV5BNWZhYTc4M2ItNDc3NS00NjIxLWEzNWMtZWIyNDgzMmUwZWM3XkEyXkFqcGdeQXVyMTkzOTcxOTg@._V1_.jpg"
                    },

                    new MovieModel()
                    {
                        id=2,
                        title="Dabangg 3",
                        details="Dabangg 3 is a 2019 Indian Hindi-language action comedy film directed by Prabhu Deva, and produced by Salman Khan and Arbaaz Khan under their respective banners of Salman Khan Films and Arbaaz Khan Productions. The film is a sequel to the 2012 film Dabangg 2 and the third installment of Dabangg film series.",
                        url="https://cdn.pinkvilla.com/files/styles/contentpreview/public/dabangg-3-new-poster-salman-khan-aka-chulbul-pandey-goes-shirtless-and-flaunts-his-chiselled-body.jpg?itok=yaYdn-7r"
                    },
                    new MovieModel()
                    {
                        id=3,
                        title="Jumanji: The Next Level",
                        details="When Spencer goes back into the fantastical world of Jumanji, pals Martha, Fridge and Bethany re-enter the game to bring him home. But the game is now broken -- and fighting back. Everything the friends know about Jumanji is about to change, as they soon discover there's more obstacles and more danger to overcome.",
                        url="https://specials-images.forbesimg.com/imageserve/5deeed7d25ab5d000700adf2/0x800.jpg?cropX1=0&cropX2=566&cropY1=0&cropY2=755"
                    },
                    new MovieModel()
                    {
                        id=4,
                        title="Bala",
                        details="The film tells the story of Bala (Ayushmann Khurrana), a man who is balding prematurely and how he copes with the situation. The film also narrates Bala's relationship with two women played by Yami Gautam and Bhumi Pednekar respectively.",
                        url="https://in.bookmyshow.com/entertainment/wp-content/uploads/2019/11/Bala-Movie-Review-By-Rajeev-Masand_Horizontal-image-with-no-text_-759-x-597_75.jpg"
                    },

                    new MovieModel()
                    {
                        id=5,
                        title="Kabir Singh",
                        details="A house surgeon goes into a self-destructive spiral after his girlfriend is forced to marry another man.",
                        url="http://t1.gstatic.com/images?q=tbn:ANd9GcSSBjgn6nmJttwcTh0nmdTxJLyomVapLaColnlJZ9dXLjf-Y1tP"
                    },

                     new MovieModel()
                    {
                         id=6,
                        title="Uri: The Surgical Strike",
                        details="Major Vihaan Singh Shergill of the Indian Army leads a covert operation against a group of militants who attacked a base in Uri, Kashmir, in 2016 and killed many soldiers.",
                        url="http://t2.gstatic.com/images?q=tbn:ANd9GcSHvgulsbkwf4qzDU4E_ofYWYBVXuKW16sw70QAp8iITBXB56Ee"
                    },
                };

                return listOfMovie;

            });
        }
    }
}
