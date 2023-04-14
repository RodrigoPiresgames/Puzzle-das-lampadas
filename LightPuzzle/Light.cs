using System;

public class Light
{
	public bool turnOn { get; set; }
	public override string ToString()
        {
            return this.turnOn ? "ON" : "OFF";
        }
}
