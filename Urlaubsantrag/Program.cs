using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using Urlaubsantrag;

JsonSerializerOptions options = new JsonSerializerOptions
{
    WriteIndented = true
};


Boolean proceed = true;

Console.WriteLine("Befehle:\ncreate <path>\ncontinue <path>\n\n");
while (proceed) {
    Console.WriteLine("geben sie einen Befehl ein:");
    string command = "";
    command = Console.ReadLine();
    string[] parts = command.Split(" ");
    proceed = processCommand(parts);
}



Boolean processCommand(String[] p) {
    BusinessProcess businessProcess;
    string json = string.Empty;
    string path = string.Empty;
    Boolean proceed = true;
    switch (p[0]) {
        case "create":
            if (p.Length > 1)
            {
                path = p[1];
                json = File.ReadAllText(path);
                businessProcess = JsonSerializer.Deserialize<BusinessProcess>(json);
                File.WriteAllText(path,JsonSerializer.Serialize(businessProcess,options));
            }
            else 
            {
                Console.WriteLine("Falscher Pfad");
            }
            break;
        case "continue":
            if (p.Length > 1)
            {
                path = p[1];
                json = File.ReadAllText(path);
                businessProcess = JsonSerializer.Deserialize<BusinessProcess>(json);
                businessProcess.continueBusinessProcess();
                File.WriteAllText(path, JsonSerializer.Serialize(businessProcess, options));
            }
            else
            {
                Console.WriteLine("Falscher Pfad");
            }
            break;
        case "exit":
                proceed = false;
            break;
        default:
            Console.WriteLine("Unknown command");
            break;
    }
    return proceed;
}