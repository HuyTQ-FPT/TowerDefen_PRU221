using System;
using System.IO;
using UnityEngine;

public class ConfigurationData
{
	// Start is called before the first frame update
	const string ConfigurationDataFileName = "Setting.csv";

	// configuration data with default values
	static int MaxAlive;
	static int PriceTurret;
	static int PriceRocket;
	static int MaxhealthTurret;
	static int MoneyTurret;
	static int MaxhealthTank;
	static int MoneyTank;
	static int SpeedTurret;
	static int SpeedTank;
	static int MoneyInit;
	static int PriceAddTurret;
	static int PriceAddTank;


	public int maxAlive
	{
		get
		{
			return MaxAlive;
		}
	}
	public String getFileName
	{
		get
		{
			return ConfigurationDataFileName;

		}
	}

	public int priceTurret
	{
		get { return PriceTurret; }
	}
	public int priceRocket
	{
		get { return PriceRocket; }
	}
    public int maxhealthTurret
    {
        get { return MaxhealthTurret; }
    }
    public int moneyTurret
    {
        get { return MoneyTurret; }
    }
    public int maxhealthTank
    {
        get { return MaxhealthTank; }
    }
    public int moneyTank
    {
        get { return MoneyTank; }
    }
    public int speedTurret
    {
        get { return SpeedTurret; }
    }
    public int speedTank
    {
        get { return SpeedTank; }
    }
    public int moneyInit
    {
        get { return MoneyInit; }
    }
    public int priceAddTurret
    {
        get { return PriceAddTurret; }
    }
    public int priceAddTank
    {
        get { return PriceAddTank; }
    }


    #region Constructor

    public ConfigurationData()
	{
		// read and save configuration data from file
		StreamReader input = null;
		try
		{
			// create stream reader object
			input = File.OpenText(System.IO.Path.Combine(
				Application.streamingAssetsPath, ConfigurationDataFileName));

            // read in names and values
            string names = input.ReadLine();
			string values = input.ReadLine();

			// set configuration data fields
			SetConfigurationDataFields(values);
		}
		catch (Exception e)
		{
		}
		finally
		{
			// always close input file
			if (input != null)
			{
				input.Close();
			}
		}
	}

	static void SetConfigurationDataFields(string csvValues)
	{

		string[] values = csvValues.Split(',');
		MaxAlive = int.Parse(values[0]);
		PriceTurret = int.Parse(values[1]);
		PriceRocket = int.Parse(values[2]);
        MaxhealthTurret = int.Parse(values[3]);
        MoneyTurret = int.Parse(values[4]);
        MaxhealthTank = int.Parse(values[5]);
        MoneyTank = int.Parse(values[6]);
        SpeedTurret = int.Parse(values[7]);
        SpeedTank = int.Parse(values[8]);
        MoneyInit = int.Parse(values[9]);
        PriceAddTurret = int.Parse(values[10]);
        PriceAddTank = int.Parse(values[11]);
	}
	#endregion
}
