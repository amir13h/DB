using First.API.DB;
using First.API.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FirstDB>(options=>
{
    options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=FirstDB; Trusted_Connection=True");
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.MapPost("/Books/add",(FirstDB db,Book book)=>
{
    db.Books.Add(book);
    db.SaveChanges();
});
app.MapPost("/Books/list",(FirstDB db)=>
{
    return db.Books.ToList();
});
app.MapPost("/Books/update",(FirstDB db,Book book)=>
{
    db.Books.Update(book);
    db.SaveChanges();
});
app.MapPost("/Books/remove/{{id}}",(FirstDB db,int id)=>
{
    var book=db.Books.Find(id);
    if (book!=null)
    {
        db.Books.Remove(book);
        db.SaveChanges();
    }
});
app.MapPost("/Members/add",(FirstDB db,Member member)=>
{
    db.Members.Add(member);
    db.SaveChanges();
});
app.MapPost("/Members/list",(FirstDB db)=>
{
    return db.Members.ToList();
});
app.MapPost("/Members/update",(FirstDB db,Member member)=>
{
    db.Members.Update(member);
    db.SaveChanges();
});
app.MapPost("/Members/remove/{{id}}",(FirstDB db,int id)=>
{
    var member=db.Members.Find(id);
    if (member!=null)
    {
        db.Members.Remove(member);
        db.SaveChanges();
    }
});
app.Run();
 