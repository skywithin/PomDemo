using Microsoft.EntityFrameworkCore;
using PomDemo.Components.Pages.Servers;
using PomDemo.Data;

namespace PomDemo.Models;

public class ServersEfCoreRepository(IDbContextFactory<ServersDbContext> factory)
{
    public void AddServer(Server server)
	{
		using var db = factory.CreateDbContext();

		db.Servers.Add(server);

		db.SaveChanges();
	}

	public List<Server> GetServers()
	{
		using var db = factory.CreateDbContext();

		return db.Servers.ToList();
	}

	public List<Server> GetServersByCity(string cityName)
	{
		using var db = factory.CreateDbContext();

		return db.Servers
				.Where(s => s.City == cityName)
				.ToList();
	}

	public Server? GetServerById(int serverId)
	{
		using var db = factory.CreateDbContext();

		return db.Servers.Find(serverId);
	}

	public void UpdateServer(int serverId, Server server)
	{
		if (server is null)
			throw new ArgumentNullException(nameof(server));

		if (serverId != server.Id)
			return;

		using var db = factory.CreateDbContext();

		var serverToUpdate = db.Servers.Find(serverId);

		if (serverToUpdate != null)
		{
			serverToUpdate.IsOnline = server.IsOnline;
			serverToUpdate.Name = server.Name;
			serverToUpdate.City = server.City;

			db.SaveChanges();
		}
	}

	public void DeleteServer(int serverId)
	{
		using var db = factory.CreateDbContext();

		var serverToDelete = db.Servers.Find(serverId);

		if (serverToDelete is null)
		{
			return;
		}

		db.Servers.Remove(serverToDelete);
		db.SaveChanges();
	}

	public List<Server> SearchServers(string searchFilter)
	{
		using var db = factory.CreateDbContext();

		return db.Servers
				.Where(s => EF.Functions.Like(s.Name, $"%{searchFilter}%"))
				.ToList();
	}
}