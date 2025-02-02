// Written by Kapil
// Feb 1 2025

using System;

namespace HomeWork1
{
    public class HomeWork1
    {
        // Class variables or member variables
        private double baseLength = 0.0;
        private double height = 0.0;
        private int chocolateEggs = -1;
        private int provinces = -1;
        private int duchies = -1;
        private int estates = -1;
        private int targetRow = -1;
        private int targetColumn = -1;
        private int number = -1;

        // Gets and Sets

        public double BaseLength
        {
            get { return this.baseLength; }
            set { this.baseLength = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int ChocolateEggs
        {
            get { return this.chocolateEggs; }
            set { this.chocolateEggs = value; }
        }

        public int Provinces
        {
            get { return this.provinces; }
            set { this.provinces = value; }
        }

        public int Duchies
        {
            get { return this.duchies; }
            set { this.duchies = value; }
        }

        public int Estates
        {
            get { return this.estates; }
            set { this.estates = value; }
        }

        public int TargetRow
        {
            get { return this.targetRow; }
            set { this.targetRow = value; }
        }

        public int TargetColumn
        {
            get { return this.targetColumn; }
            set { this.targetColumn = value; }
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        // Constructors

        public HomeWork1() : this(0.0, 0.0, -1, -1, -1, -1, -1, -1, -1)
        {
            // Empty constructor
        }

        public HomeWork1(double aBaseLength, double aHeight) : this(aBaseLength, aHeight, -1, -1, -1, -1, -1, -1, -1)
        {
            // Constructor for Triangle Farmer
        }

        public HomeWork1(int aChocolateEggs) : this(0.0, 0.0, aChocolateEggs, -1, -1, -1, -1, -1, -1)
        {
            // Constructor for Four Sisters and the Duckbear
        }

        public HomeWork1(int aProvinces, int aDuchies, int aEstates) : this(0.0, 0.0, -1, aProvinces, aDuchies, aEstates, -1, -1, -1)
        {
            // Constructor for Dominion of Kings
        }

        public HomeWork1(int aTargetRow, int aTargetColumn) : this(0.0, 0.0, -1, -1, -1, -1, aTargetRow, aTargetColumn, -1)
        {
            // Constructor for Defense of Consolas
        }

        /*public HomeWork1(int aNumber) : this(0.0, 0.0, -1, -1, -1, -1, -1, -1, aNumber)
        {
            // Constructor for Repairing the Clocktower
        }*/

        public HomeWork1(double aBaseLength, double aHeight, int aChocolateEggs, int aProvinces, int aDuchies, int aEstates, int aTargetRow, int aTargetColumn, int aNumber)
        {
            // Full constructor
            this.BaseLength = aBaseLength;
            this.Height = aHeight;
            this.ChocolateEggs = aChocolateEggs;
            this.Provinces = aProvinces;
            this.Duchies = aDuchies;
            this.Estates = aEstates;
            this.TargetRow = aTargetRow;
            this.TargetColumn = aTargetColumn;
            this.Number = aNumber;
        }

        // Methods

        public double GetTriangleArea()
        {
            return (this.BaseLength * this.Height) / 2;
        }

        public int GetSistersEggs()
        {
            return this.ChocolateEggs / 4;
        }

        public int GetDuckbearEggs()
        {
            return this.ChocolateEggs % 4;
        }

        public int GetTotalScore()
        {
            return (this.Provinces * 6) + (this.Duchies * 3) + (this.Estates * 1);
        }

        public string GetDeploymentLocations()
        {
            return $"Deploy to:\n" +
                   $"({this.TargetRow}, {this.TargetColumn - 1})\n" + // Left
                   $"({this.TargetRow - 1}, {this.TargetColumn})\n" + // Up
                   $"({this.TargetRow}, {this.TargetColumn + 1})\n" + // Right
                   $"({this.TargetRow + 1}, {this.TargetColumn})";    // Down
        }

        public string GetTickOrTock()
        {
            return (this.Number % 2 == 0) ? "Tick" : "Tock";
        }

        // Override ToString method
        public override string ToString()
        {
            string message = "";
            message += "Base Length: " + this.BaseLength + "\n";
            message += "Height: " + this.Height + "\n";
            message += "Eggs: " + this.ChocolateEggs + "\n";
            message += "Provinces: " + this.Provinces + "\n";
            message += "Duchies: " + this.Duchies + "\n";
            message += "Estates: " + this.Estates + "\n";
            message += "Target Row: " + this.TargetRow + "\n";
            message += "Target Column: " + this.TargetColumn + "\n";
            message += "Number: " + this.Number + "\n";
            return message;
        }
    }
}