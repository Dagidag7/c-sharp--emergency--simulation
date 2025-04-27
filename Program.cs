using System;
using System.Collections.Generic;
using System.Linq;

public abstract class EmergencyUnit
{
    public string Name { get; protected set; }
    public int Speed { get; protected set; }

    public abstract bool CanHandle(string incidentType);
    public abstract void RespondToIncident(Incident incident);

    public EmergencyUnit(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
}

public class Police : EmergencyUnit
{
    public Police(string name, int speed) : base(name, speed) { }

    public override bool CanHandle(string incidentType)
    {
        return incidentType.Equals("Crime", StringComparison.OrdinalIgnoreCase);
    }

    public override void RespondToIncident(Incident incident)
    {
        Console.WriteLine($"{Name} is investigating the crime at {incident.Location}.");
    }
}

public class Firefighter : EmergencyUnit
{
    public Firefighter(string name, int speed) : base(name, speed) { }

    public override bool CanHandle(string incidentType)
    {
        return incidentType.Equals("Fire", StringComparison.OrdinalIgnoreCase);
    }

    public override void RespondToIncident(Incident incident)
    {
        Console.WriteLine($"{Name} is putting out the fire at {incident.Location}.");
    }
}

public class Ambulance : EmergencyUnit
{
    public Ambulance(string name, int speed) : base(name, speed) { }

    public override bool CanHandle(string incidentType)
    {
        return incidentType.Equals("Medical", StringComparison.OrdinalIgnoreCase);
    }

    public override void RespondToIncident(Incident incident)
    {
        Console.WriteLine($"{Name} is treating patients at {incident.Location}.");
    }
}

public class HazmatTeam : EmergencyUnit
{
    public HazmatTeam(string name, int speed) : base(name, speed) { }

    public override bool CanHandle(string incidentType)
    {
        return incidentType.Equals("Chemical Spill", StringComparison.OrdinalIgnoreCase);
    }

    public override void RespondToIncident(Incident incident)
    {
        Console.WriteLine($"{Name} is containing the {incident.Type} at {incident.Location}.");
    }
}

public class Incident
{
    public string Type { get; }
    public string Location { get; }

    public Incident(string type, string location)
    {
        Type = type;
        Location = location;
    }

    public override string ToString()
    {
        return $"Type: {Type}, Location: {Location}";
    }
}

public class EmergencyResponseSimulation
{
    private static EmergencyUnit FindAppropriateUnit(List<EmergencyUnit> units, Incident incident)
    {
        foreach (var unit in units)
        {
            if (unit.CanHandle(incident.Type))
            {
                return unit;
            }
        }
        return null;
    }

    public static void Main(string[] args)
    {
        List<EmergencyUnit> units = new List<EmergencyUnit>
        {
            new Police("Police Unit 1", 90),
            new Police("Police Unit 2", 80),
            new Firefighter("Firefighter Unit 1", 70),
            new Firefighter("Firefighter Unit 2", 75),
            new Ambulance("Ambulance Unit 1", 100),
            new Ambulance("Ambulance Unit 2", 95),
            new HazmatTeam("Hazmat Unit 1", 60),
            new HazmatTeam("Hazmat Unit 2", 55)
        };

        int score = 0;
        string[] incidentTypes = { "Fire", "Crime", "Medical", "Chemical Spill", "Radiation Leak" };
        string[] locations = { "City Hall", "Main Street", "Central Park", "Hospital", "School", "Industrial Area", "Research Lab" };
        Random random = new Random();

        Console.WriteLine("- - - Simulation Starting - - -");

        foreach (string incidentType in incidentTypes)
        {
            Console.WriteLine($"- - - New Incident - - -");

            string location = locations[random.Next(locations.Length)];
            Incident incident = new Incident(incidentType, location);
            Console.WriteLine($"Incident: {incident.Type} at {incident.Location}");

            EmergencyUnit respondingUnit = FindAppropriateUnit(units, incident);

            if (respondingUnit != null)
            {
                respondingUnit.RespondToIncident(incident);
                score += 10;
                Console.WriteLine("+10 points");
            }
            else
            {
                Console.WriteLine("No suitable unit available to handle this incident.");
                score -= 5;
                Console.WriteLine("-5 points");
            }

            Console.WriteLine($"Current Score: {score}");
            Console.WriteLine();
        }

        Console.WriteLine("- - - Simulation Over - - -");
        Console.WriteLine($"Final Score: {score}");
        Console.ReadKey();
    }
}
