using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public static class ConfigurationUtils
{
	static ConfigurationData configurationData;

    public static int getMaxAlive
	{
		get { return configurationData.maxAlive; }
	}
	public static int getPriceTurret
	{
		get { return configurationData.priceTurret; }
	}
	public static int getPriceRocket
	{
		get { return configurationData.priceRocket; }
	}
    public static int getMaxhealthTurret
    {
        get { return configurationData.maxhealthTurret; }
    }
    public static int getMoneyTurret
    {
        get { return configurationData.moneyTurret; }
    }
    public static int getMaxhealthTank
    {
        get { return configurationData.maxhealthTank; }
    }
    public static int getMoneyTank
    {
        get { return configurationData.moneyTank; }
    }
    public static int getSpeedTurret
    {
        get { return configurationData.speedTurret; }
    }
    public static int getSpeedTank
    {
        get { return configurationData.speedTank; }
    }
    public static int getMoneyInit
    {
        get { return configurationData.moneyInit; }
    }
    public static int getPriceAddTurret
    {
        get { return configurationData.priceAddTurret; }
    }
    public static int getPriceAddTank
    {
        get { return configurationData.priceAddTank; }
    }
 //   public static void updateTeddy(float speed, float cooldown)
	//{
	//	StringBuilder output = new StringBuilder();
 //       String[] Header = { "MaxAlive", "PriceTurret","PriceRocket", "MaxhealthTurret", "MoneyTurret", "MaxhealthTank"
 //       , "MoneyTank", "SpeedTurret", "SpeedTank", "MoneyInit", "PriceAddTurret", "PriceAddTank"};
	//	output.AppendLine(string.Join(",", Header));

	//	String[] values = { speed.ToString(), cooldown.ToString() };
	//	output.AppendLine(string.Join(",", values));
	//	//File.AppendAllText("Assets/StreamingAssets/ConfigurationData.csv", output.ToString());
	//	File.WriteAllText("Assets/StreamingAssets/Setting.csv", output.ToString());
	//}
	public static void Initialize()
	{
		configurationData = new ConfigurationData();
	}
}
