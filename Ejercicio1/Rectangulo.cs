using System;

public class Rect
{
	public int x1;
	public int x2;
	public int y1;
	public int y2;

	public Rect(string line)
	{
		string[] valores = line.Split(",");
		x1 = Convert.ToInt32(valores[0]);
		y1 = Convert.ToInt32(valores[1]);
		x2 = Convert.ToInt32(valores[2]);
		y2 = Convert.ToInt32(valores[3]);
	}


	public int Area()
    {
	int r_base = Math.Abs(x2 - x1);
	int r_altura = Math.Abs(y2 - y1);
		return r_altura * r_base;
	}

	public int Area_Dif(Rect rect)
    {
	      int dif_x = 0;
			int dif_y = 0;
		if (!(x1 == rect.x1 && x2 == rect.x2 && y1 == rect.y1 && y2 == rect.y2))
			{
			if (rect.x1 <= x1 && x1 <= rect.x2)
			{
				if (x2 <= rect.x2)
				{
					dif_x = x2 - x1;
				}
				else
				{
					dif_x = rect.x2 - x1;
				}
				if (rect.y1 <= y1 && y1 <= rect.y2)
				{
					if (y2 <= rect.y2)
					{
						dif_y = y2 - y1;
					}
					else
					{
						dif_y = rect.y2 - y1;
					}
				}
			}
		}
		return dif_x  * dif_y;
    }


}
