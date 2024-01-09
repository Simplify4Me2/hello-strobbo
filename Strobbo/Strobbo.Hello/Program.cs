﻿using Strobbo.Hello;

string[] Karts =
[
    "Moon Unit",
    "Exa Dark Sideræl",
    "Hellzel",
    "Cyanide",
    "$helly",
    "Shanda Lear",
    "Marijuana",
    "Portabella",
    "Phelony",
    "Maybelline",
    "Talula Does The Hula From Hawaii",
    "Cinnamon",
    "Fanny",
    "Maim",
    "Fifi Trixibelle",
    "Vanity",
    "Blue Ivy",
    "Tu Morrow",
];

KartingCircuit circuit = new(Karts);

circuit.RandomizeKarts();
var groups = circuit.AssignGroups();
Console.WriteLine("Strobbo");
KartingCircuit.PrintGroup(groups);