namespace Types
{
    public class Role
    {
        public string? Guild { get; set; }
        public object? Icon { get; set; }
        public object? UnicodeEmoji { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int? Color { get; set; }
        public bool? Hoist { get; set; }
        public int? RawPosition { get; set; }
        public string? Permissions { get; set; }
        public bool? Managed { get; set; }
        public bool? Mentionable { get; set; }
        public int? Flags { get; set; }
        public Dictionary<string, object>? Tags { get; set; }
        public long? CreatedTimestamp { get; set; }
    }

    public class Channel
    {
        public int? Type { get; set; }
        public string? Guild { get; set; }
        public string? GuildId { get; set; }
        public List<string>? PermissionOverwrites { get; set; }
        public List<object>? Messages { get; set; }
        public List<object>? Threads { get; set; }
        public bool? Nsfw { get; set; }
        public int? Flags { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public int? RawPosition { get; set; }
        public string? ParentId { get; set; }
        public string? Topic { get; set; }
        public string? LastMessageId { get; set; }
        public long? RateLimitPerUser { get; set; }
        public long? CreatedTimestamp { get; set; }
        public long? LastPinTimestamp { get; set; }
    }

    public class Category
    {
        public int? type { get; set; }
        public string? guild { get; set; }
        public string? guildId { get; set; }
        public List<string>? PermissionOverwrites { get; set; }
        public int? flags { get; set; }
        public string? id { get; set; }
        public string? name { get; set; }
        public int? RawPosition { get; set; }
        public string? parentId { get; set; }
        public long? createdTimestamp { get; set; }
    }

    public class Statics
    {
        public Server? server { get; set; }
        public Tickets? tickets { get; set; }
    }

    public class Server
    {
        public Owner? Owner { get; set; }
        public List<Role>? Roles { get; set; }
        public List<Channel>? Channels { get; set; }
        public List<Category>? Categories { get; set; }
    }

    public class Owner
    {
        public string? Id { get; set; }
        public string? Username { get; set; }
    }

    public class Tickets
    {
        public int? total { get; set; }
        public int? Closed { get; set; }
    }

    public class Root
    {
        public string? username { get; set; }
        public string? serverName { get; set; }
        public string? serverImage { get; set; }
        public string? botImage { get; set; }
        public string? userImage { get; set; }
        public Statics? statics { get; set; }
    }
}
