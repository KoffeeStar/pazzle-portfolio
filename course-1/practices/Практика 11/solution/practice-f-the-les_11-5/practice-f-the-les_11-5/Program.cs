using System;

class Thermometer
{
    private int temperatureCelsius;

    public int TemperatureCelsius
    {
        get { return temperatureCelsius; }
        set
        {
            if (value < -273)
                throw new ArgumentException("Температура не может быть ниже -273.");
            temperatureCelsius = value;
        }
    }

    public int TemperatureFahrenheit
    {
        get { return (temperatureCelsius * 9 / 5) + 32; }
    }
}