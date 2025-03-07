using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting; 

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MvcMovieContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public MoviesController(MvcMovieContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment; // Initialize _hostEnvironment
        }

        // GET: Movies
        public async Task<IActionResult> Index(string movieGenre, string searchString, string sortOrder)
        {
            if (_context.Movie == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie' is null.");
            }

            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;
            var movies = from m in _context.Movie
                         select m;

            // Apply search filter
            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title!.ToUpper().Contains(searchString.ToUpper()));
            }

            // Apply genre filter
            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            // Default sorting 
            if (string.IsNullOrEmpty(sortOrder) || sortOrder == "alphabetical")
            {
                movies = movies.OrderBy(m => m.Title);
            }
            else if (sortOrder == "release_date")
            {
                movies = movies.OrderBy(m => m.ReleaseDate);
            }
            else if (sortOrder == "release_date_desc")
            {
                movies = movies.OrderByDescending(m => m.ReleaseDate);
            }

            var movieGenreVM = new MovieGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Movies = await movies.ToListAsync()
            };

            // Store the sort order
            ViewData["SortOrder"] = sortOrder;

            return View(movieGenreVM);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            var genres = new List<string>
            {
                "Action", "Comedy", "Drama", "Documentary", "Romance"
            };

            ViewBag.Genres = new SelectList(genres);

            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,ReleaseDate,Genre,Price,Rating,Image")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                // Handle the image saving
                if (movie.Image != null)
                {
                    var fileName = Path.GetFileName(movie.Image.FileName);
                    var filePath = Path.Combine(_hostEnvironment.WebRootPath, "images", fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await movie.Image.CopyToAsync(stream);
                    }
                    movie.ImageName = fileName;  // Save the image name to the database
                }

                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));  // Redirect back to the list of movies
            }

            return View(movie);  // Return to the Create view if validation fails
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            var genres = new List<string>
            {
                "Action", "Comedy", "Drama", "Documentary", "Romance"
            };
            ViewBag.Genres = new SelectList(genres, movie.Genre);

            return View(movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price,Rating,ImageName")] Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound(); // If the movie ID doesn't match, return 404
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingMovie = await _context.Movie.FindAsync(id);
                    if (existingMovie == null)
                    {
                        return NotFound(); // If the movie doesn't exist anymore, return 404
                    }

                    // Handle the image upload here if it's not null
                    if (movie.Image != null)
                    {
                        // Save the image file
                        var fileName = Path.GetFileName(movie.Image.FileName);
                        var filePath = Path.Combine(_hostEnvironment.WebRootPath, "images", fileName); // Get the web root path
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await movie.Image.CopyToAsync(stream);
                        }
                        existingMovie.ImageName = fileName; // Save the image name to the database
                    }

                    // Update the movie properties
                    existingMovie.Title = movie.Title;
                    existingMovie.ReleaseDate = movie.ReleaseDate;
                    existingMovie.Genre = movie.Genre;
                    existingMovie.Price = movie.Price;
                    existingMovie.Rating = movie.Rating;

                    _context.Update(existingMovie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return StatusCode(500, "Internal server error. Try again later.");
                }
                return RedirectToAction(nameof(Index));
            }

            return View(movie); // Return to the edit view if validation fails
        }


        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            if (movie != null)
            {
                _context.Movie.Remove(movie);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
