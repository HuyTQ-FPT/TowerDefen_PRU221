using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public static class ConfigurationUtils
{
	static ConfigurationData configurationData;

    static String[] Values = configurationData.getValues();
 
    public static int getMaxAlive
	{
		get { return int.Parse(Values[0]); }
	}
	public static int getPriceTurret
	{
		get { return int.Parse(Values[1]); }
	}
	public static int getPriceRocket
	{
		get { return int.Parse(Values[2]); }
	}
	public static int getMaxhealthTurret
	{
		get { return int.Parse(Values[3]); }
	}
	public static int getMoneyTurret
	{
		get { return int.Parse(Values[4]); }
	}
	public static int getMaxhealthTank
	{
		get { return int.Parse(Values[5]); }
	}
	public static int getMoneyTank
	{
		get { return int.Parse(Values[6]); }
	}
	public static int getSpeedTurret
	{
		get { return int.Parse(Values[7]); }
	}
	public static int getSpeedTank
	{
		get { return int.Parse(Values[8]); }
	}
	public static int getMoneyInit
	{
		get { return int.Parse(Values[9]); }
	}
	public static int getPriceAddTurret
	{
		get { return int.Parse(Values[10]); }
	}
	public static int getPriceAddTank
	{
		get { return int.Parse(Values[11]); }
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
	//public static void Initialize()
	//{
	//	configurationData = new ConfigurationData();
	//}
}
