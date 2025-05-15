﻿using System.ComponentModel.DataAnnotations;

namespace PomDemo.Models;

public class Server
{
    public Server()
    {
        var random = new Random();
        var randomNumber = random.Next(0, 2);

        IsOnline = randomNumber != 0;
    }

    public int Id { get; set; }
    public bool IsOnline { get; set; }
        
    [Required]
    public string? Name { get; set; }

    [Required]
    public string? City { get; set; }
}
