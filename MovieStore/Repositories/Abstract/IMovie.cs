﻿using MovieStore.Models.Domain;
using MovieStore.Models.DTO;

namespace MovieStore.Repositories.Abstract
{
    public interface IMovie
    {
        bool Add(Movie model);
        bool Update(Movie model);
        Movie GetById(int id);
        bool Delete(int id);
        MovieListVm List(string term = "", bool paging = false, int currentPage = 0);
        List<int> GetGenreByMovieId(int movieId);
    }
}
