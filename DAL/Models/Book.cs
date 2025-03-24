﻿namespace DAL.Models;

public class Book
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public string ISBN { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime? BorrowedAt { get; set; }
    public DateTime? ReturnBy { get; set; }
    public bool IsBorrowed { get; set; }
    public string ImageURL { get; set; } = string.Empty;
}
