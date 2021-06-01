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
        Antismoke antismoke { get; set; }
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
    Magen = 3
}
public enum DoorColor
{
    ChooseFromBelow = 0,
    White = 1,
    Black = 2,
    Brown = 3,
    Crimson = 4,
    NavyBlue = 5,
    Gray = 6
}
public enum FireproofLevel
{
    ChooseFromBelow = 0,
    M30 = 1,
    M60 = 2,
    M90 = 3
}
enum FrameColor
{
    ChooseFromBelow = 0,
    White = 1,
    Black = 2,
    Brown = 3,
    Crimson = 4,
    NavyBlue = 5,
    Gray = 6
}
enum AccesoriesColor
{
    ChooseFromBelow = 0,
    Silver = 1,
    Bronze = 2
}

enum Antismoke
{
    ChooseFromBelow = 0,
    Yes = 1,
    No = 2
}
