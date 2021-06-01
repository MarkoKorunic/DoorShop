using System;
using System.Collections.Generic;
using System.Text;

namespace DoorShop
{
    public class Door
    {
        public DoorType doorType { get; set; }
        public DoorColor doorColor { get; set; }
        public FrameColor frameColor { get; set; }
        public FireproofLevel fireproofLevel { get; set; }
        public AccesoriesColor accesoriesColor { get; set; }
        public Antismoke antismoke { get; set; }
        public float height { get; set; }
        public float width { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }


       
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
public enum FrameColor
{
    ChooseFromBelow = 0,
    White = 1,
    Black = 2,
    Brown = 3,
    Crimson = 4,
    NavyBlue = 5,
    Gray = 6
}
public enum AccesoriesColor
{
    ChooseFromBelow = 0,
    Silver = 1,
    Bronze = 2
}

public enum Antismoke
{
    ChooseFromBelow = 0,
    Yes = 1,
    No = 2
}
