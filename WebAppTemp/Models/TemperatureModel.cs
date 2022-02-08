using System;
using Temperature;

namespace WebAppTemp.Models
{
    public class TemperatureModel
    {

        public string TempFrom { get; set; }
        public string TempTo { get; set; }
        public int InitalValue { get; set; }
        public double? ConversionResult { get; set; }


        public TemperatureModel(string tempFrom, string tempTo, int initialValue)
        {
            TempFrom = tempFrom;
            TempTo = tempTo;
            InitalValue = initialValue;

            Conversion conversion = new Conversion();
            var ConvertMode = GetConvertType();
            ConversionResult = conversion.Convert(ConvertMode, initialValue);
        }

        public Conversion.ConversionMode GetConvertType()
        {
            if (TempFrom == TempTo)
            {
                return Conversion.ConversionMode.none;
            }
            else if (TempFrom.Equals("Celcius") && TempTo.Equals("Fahrenheit"))
            {
                return Conversion.ConversionMode.Celsius_to_Fahrenheit;
            }
            else if (TempFrom.Equals("Celcius") && TempTo.Equals("Kelvin"))
            {
                return Conversion.ConversionMode.Celsius_to_Kelvin;
            }
            else if (TempFrom.Equals("Fahrenheit") && TempTo.Equals("Celcius"))
            {
                return Conversion.ConversionMode.Fahrenheit_to_Celsius;
            }
            else if (TempFrom.Equals("Fahrenheit") && TempTo.Equals("Kelvin"))
            {
                return Conversion.ConversionMode.Fahrenheit_to_Kelvin;
            }
            else if (TempFrom.Equals("Kelvin") && TempTo.Equals("Celcius"))
            {
                return Conversion.ConversionMode.Kelvin_to_Celsius;
            }
            else if (TempFrom.Equals("Kelvin") && TempTo.Equals("Fahrenheit"))
            {
                return Conversion.ConversionMode.Kelvin_to_Fahrenheit;
            }
            else
            {
                return Conversion.ConversionMode.none;
            }
        }
    }
}

