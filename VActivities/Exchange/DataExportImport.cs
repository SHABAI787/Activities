using System;
using System.Collections.Generic;

namespace VActivities.Exchange
{
    [Serializable]
    public class DataExportImport
    {
        public List<Row> Rows = new List<Row>();
    }

    [Serializable]
    public class Row
    {
        public List<Cell> Cells = new List<Cell>();
    }

    [Serializable]
    public class Cell
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Value == null ? string.Empty : Value;
        }

        public static List<Cell> CreateList(params string[] values)
        {
            List<Cell> cells = new List<Cell>();
            foreach (var value in values)
            {
                cells.Add(new Cell() { Value = value });
            }
            return cells;
        }
    }
}
