# Welcome to GlamWire: Case Cracked
## Project/Game Overview:
GlamWire is a fictional investigative game that immerses players in a 
cryptic Y2K chat-room full of mystery and intrigue. 
Players take on the role of a detective tasked with solving
cases by gathering kooky clues, interviewing comedic suspects, and piecing 
together glittery evidence.
The game combines elements of puzzle-solving, narrative storytelling,
and strategic decision-making to create an engaging experience.

### Features (Coming Soon!): 
- **Interactive Chat-Room Interface**: Navigate through 
a retro-themed chat-room where players
can interact with various characters and uncover clues.
- **Retro Styling**: Those nostalgic Y2K aesthetics with
vibrant colors(Pink, Grey Sparkles, Leopard Print), pixel art.
- **Upgrades** — Buy investigative tools to help you solve cases.

### Tech Stack: 
- Built with **C# WinForms**  
- **SQL Server** database for storing progress, 
NPCs, and conversations  
- *Coming Soon* - Supports multiple save files  
- *Coming Soon* -Flexible schema for branching dialogue
and replayable content 

- ## Database Schema

The database is called **`GlamWireDb`**.  
And here are the main tables and their purposes:

### Tables
| Table | Purpose |
|--------|----------|
| **SaveFile** | Tracks player saves, wallet, and stats |
| **Cases** | Stores each mystery with difficulty, rewards, and progress |
| **NPC** | Clients, suspects, and witnesses; roles can change dynamically |
| **Clues** | Tracks clues found during cases |
| **Prompts** | Dialogue lines and selectable chat prompts |
| **InboxMessages** | Emails or documents sent by NPCs |
| **Upgrades** | Store inventory of all available upgrades |
| **UserUpgrades** | Tracks player-owned upgrades (inventory) |
| **ChatLogs** | Stores chat transcripts and timestamps |

## Getting Set Up: 
1. Clone this repository from GitHub onto your local machine
2. Open the solution in Visual Studio
3. Set up the SQL Server database using the provided scripts in the `Data` folder
4. Build and run the project


## Author(s) in Alphabetical Order: 
- Kendall Dawson ([@Kenny-42])
- Kourtnie Moore ([@VacaSama])

