using System;
using System.Collections.Generic;
using System.Text;

namespace DoorShop
{
    public class Door
    {
        DoorType doorType { get; set; }
        DoorColor doorColor { get; set; }
        FrameColor frameColor { get; set; }
        FireproofLevel fireproofLevel { get; set; }
        AccesoriesColor accesoriesColor { get; set; }
        bool antiSmoke { get; set; }
        float height { get; set; }
        float width { get; set; }
        float price { get; set; }
        int quantity { get; set; }

        
        
    }
}
public enum DoorType
{
    Alpha = 1,
    Beta = 2,
    Gamen = 3
}
public enum DoorColor
{
    White = 1,
    Black = 2,
    Brown = 3,
    Crimson = 4,
    NavyBlue = 5,
    Gray = 6
}
public enum FireproofLevel
{
    M30 = 1,
    M60 = 2,
    M90 = 3
}
enum FrameColor
{
    White = 1,
    Black = 2,
    Brown = 3,
    Crimson = 4,
    NavyBlue = 5,
    Gray = 6
}
enum AccesoriesColor
{
    Silver = 1,
    Bronze = 2
}
