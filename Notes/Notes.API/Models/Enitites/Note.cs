﻿namespace Notes.API.Models.Enitites
{
    public class Note
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsVisible { get; set; }
    }
}
