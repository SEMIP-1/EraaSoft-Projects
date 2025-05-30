using System;
using System.Security.Cryptography.X509Certificates;

public class Player
{
	public string? Name { get; set; }
	public int? Health { get; set; }
	public int? EXP { get; set; }

	public string Over() 
	{
		return $"The {Name} is overing the ball";
    }
    public string Shooting()
    {
        return $"The {Name} is Shooting the ball";
    }
    public string Passing(Player SecondPlayer)
    {
        return $"The {Name} is passing the ball to the {SecondPlayer.Name}";
    }
}
