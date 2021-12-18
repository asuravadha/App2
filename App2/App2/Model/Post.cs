using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace App2.Model
{
    public class Post
    {
    [PrimaryKey,AutoIncrement]
    public int Id { get; set; }

    [MaxLength(100)]
    public string Title { get; set; }
    }
}
