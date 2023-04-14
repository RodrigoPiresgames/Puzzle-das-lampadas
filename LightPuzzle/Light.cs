using System;

public class Light
{
	public bool turnOn { get; set; }
	public override string ToString()
        {
            return this.turnOn ? "ON" : "OFF";
        }
	public string ToImage()
        {
            return this.turnOn ? "(:)" : "( )";
        }
	public string ToImage2()
        {
            return this.turnOn ? " = " : " = ";
        }
}
