// See https://aka.ms/new-console-template for more information
using EntityFramework.Contexts;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");

using var db = new EventContext();

var evt = db.Events
    .Include(evt => evt.ParentSportEvents)
    .Include(evt => evt.ChildSportEvents)
    .Include(evt => evt.RelatedSportsEvents)
    .Single(evt => evt.Id.Equals("GN09X0E1W3HSJD7"));

Console.WriteLine(evt.Id);
Console.WriteLine(evt.ParentSportEvents.Count);
Console.WriteLine(evt.RelatedSportsEvents.Count);
