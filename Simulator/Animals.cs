using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator;

public class Animals
{
    // Private field for Description
    private string _description = "Unknown";

    public required string Description
    {
        get => _description;
        init
        {
            // Trim spaces and ensure at least 3 characters
            var valueTrimmed = value.Trim();
            if (valueTrimmed.Length < 3)
            {
                valueTrimmed = valueTrimmed.PadRight(3, '#');
            }

            // Limit to 15 characters and recheck minimum length
            valueTrimmed = valueTrimmed.Length > 15 ? valueTrimmed.Substring(0, 15).TrimEnd() : valueTrimmed;
            if (valueTrimmed.Length < 3)
            {
                valueTrimmed = valueTrimmed.PadRight(3, '#');
            }

            // Capitalize first letter if necessary
            if (char.IsLower(valueTrimmed[0]))
            {
                valueTrimmed = char.ToUpper(valueTrimmed[0]) + valueTrimmed.Substring(1);
            }

            _description = valueTrimmed;
        }
    }

    public uint Size { get; set; } = 3;

    // Read-only property Info
    public string Info => $"{Description} <{Size}>";
}
