using EntityFramework.Contexts;
using EntityFramework.Models;
using SeedData.models;
using System.Text.Json;
using SeedData;

using var db = new EventContext();

HttpClient httpClient = new HttpClient();

Console.WriteLine("Retriving data from api");
try
{
    // Retireve events json from provided endpoint.
    using HttpResponseMessage response = await httpClient.GetAsync("https://myth.fra1.digitaloceanspaces.com/misc/528%20%281%29.json");
    response.EnsureSuccessStatusCode();
    string responseBody = await response.Content.ReadAsStringAsync();
    var suppliedEvents = JsonSerializer.Deserialize<List<SuppliedJson>>(responseBody);
    Console.WriteLine($"Events length: {suppliedEvents.Count}");

    // Insert data into database
    List<EventData> eventData = new List<EventData>();
    List<ParentChildRelation> parentRelations = new List<ParentChildRelation>();
    List<RelatedSportsEvents> relatedEvents = new List<RelatedSportsEvents>();

    foreach ( var evt in suppliedEvents)
    {
        eventData.Add(Helpers.MapEventData(evt));
        parentRelations.AddRange(Helpers.MapParentChildRelation(evt.id, evt.parent_sports_event_ids));
        relatedEvents.AddRange(Helpers.MapRelatedEvents(evt.id, evt.related_sports_events));
    }

    Console.WriteLine(eventData.Count );
    Console.WriteLine(parentRelations.Count );
    Console.WriteLine(relatedEvents.Count );

    // Filter to only add related events that actually exist within the db otherwise there are errors trying to insert with foreign key that doesn't exist. 
    var eventIds = eventData.Select(evt => evt.Id).ToList();
    parentRelations = parentRelations.Where(relation => eventIds.Contains(relation.ChildId) && eventIds.Contains(relation.ParentId)).ToList();
    relatedEvents = relatedEvents.Where(relation => eventIds.Contains(relation.RelatedEventId)).ToList();
    Console.WriteLine(parentRelations.Count);
    Console.WriteLine(relatedEvents.Count);
    
    db.Events.AddRange( eventData );
    db.ParentRelations.AddRange( parentRelations );
    db.Relations.AddRange( relatedEvents );

    db.SaveChanges();



}
catch (HttpRequestException e)
{
    Console.WriteLine("\nException Caught!");
    Console.WriteLine("Message :{0} ", e.Message);
}