public class Map
{
    // map variables
    public string[] Field = new string[16];
    public int[,] HouseStreets = new int[16,60]; // streets ID from 1 to 10

    public Map()
    {
        Field[0] =  "############################################################";
        Field[1] =  "#  * * * * * *    friendly houses                          #";
        Field[2] =  "#  |---------| *                                           #";
        Field[3] =  "#  |* * * * *| *         |--------------| city hall        #";
        Field[4] =  "#  |* * * * *| *         |  *         * |----------|       #";
        Field[5] =  "#  |---------| *         |              |          |       #";
        Field[6] =  "#  |* * * * *| * * * *   |              |       *  |       #";
        Field[7] =  "#  |* * * * *|-----------|  *         * |        * |       #";
        Field[8] =  "#  |---------| *   * *   |              |       *  |       #";
        Field[9] =  "#  |* * * * *| *         |              |          |       #";
        Field[10] = "#  |* * * * *| *         |  *         * |----------|       #";
        Field[11] = "#  |---------| *         |--------------|                  #";
        Field[12] = "#  |* * * * *| *             downtown                      #";
        Field[13] = "#  |* * * * *| *                                           #";
        Field[14] = "#  |---------| *                                           #";
        Field[15] = "############################################################";

        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 60; j++)
            {
                if (Field[i][j] == '*') // kostyl street recognition
                {
                    if (j >= 48 && j <= 49) // city hall street
                        HouseStreets[i, j] = 1;
                    else if (j == 38) // right side downtown
                        HouseStreets[i, j] = 2;
                    else if (j == 28) // left side downtown
                        HouseStreets[i, j] = 3;
                    else if (j >= 17 && j <= 21) // road to friendly houses
                        HouseStreets[i, j] = 4;
                    else if (j >= 13 && j <= 16) // right main friendly houses road
                        HouseStreets[i, j] = 5;
                    else if (i == 1 || i == 3) // top fh road
                        HouseStreets[i, j] = 6;
                    else if (i == 4 || i == 6) // 2nd fh road
                        HouseStreets[i, j] = 7;
                    else if (i == 7 || i == 9) // 3rd fh road
                        HouseStreets[i, j] = 8;
                    else if (i == 10 || i == 12) // 4th fh road
                        HouseStreets[i, j] = 9;
                    else if (i == 13) // bottom fh road
                        HouseStreets[i, j] = 10;
                }
                else
                    HouseStreets[i, j] = 0; // not a house
            }
        }
    }
    public string[] GetField()
    {
        return Field;
    }
    
}
