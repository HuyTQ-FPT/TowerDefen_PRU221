using Newtonsoft.Json.Linq;
using System;
using System.IO;
using UnityEngine;

public class ConfigurationData
{
	// Start is called before the first frame update
	const string ConfigurationDataFileName = "C:\\Users\\HUY\\Documents\\GitHub\\TowerDefen_PRU221\\Assets\\StreamingAssets\\Setting.txt";


	public String[] getValues()
	{
        String[] datas = null;
        String[] values = null;
        // read file
        StreamReader output = null;
        try
        {
            output = File.OpenText(ConfigurationDataFileName);
            String line = output.ReadLine();
            String data = null;
            while (line != null)
            {
                data += line;
                line=output.ReadLine();
            }
             datas=data.Split(":");
            for(int i=0; i<datas.Length; i++)
            {
                if (i % 2 == 1)
                {
                    values[i/2] = datas[i];
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (output != null)
            {
                output.Close();
            }
        }
        return values;

    }
}
