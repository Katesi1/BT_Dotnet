using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; } // Chứa danh sách các thể loại
    public string? MovieGenre { get; set; } // Thể loại đã chọn
    public string? SearchString { get; set; } // Chưa văn bản người dùng nhập vào hộp văn bản tìm kiếm
}