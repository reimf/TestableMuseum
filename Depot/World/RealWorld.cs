﻿namespace Depot;

public class RealWorld : IWorld
{
    public DateTime Now
    {
        get => DateTime.Now;
    }

    public void WriteLine(string line)
    {
        Console.WriteLine(line);
    }

    public string ReadLine()
    {
        return Console.ReadLine();
    }

    public string ReadAllText(string path)
    {
        return File.ReadAllText(path);
    }

    public bool Exists(string path)
    {
        return File.Exists(path);
    }

    public void WriteAllText(string path, string contents)
    {
        File.WriteAllText(path, contents);
    }
}