# c-sharp--emergency--simulation
# Emergency Response Simulation in C#

## Project Description

This C# project simulates a basic emergency response system. It models different types of emergency units (Police, Firefighters, Ambulances, and Hazmat Teams) and their responses to various incidents (Fire, Crime, Medical emergencies, and Chemical Spills). The simulation dispatches the appropriate unit to handle each incident and calculates a simple score based on the system's response.

**Key Features**

* **Emergency Units:** The simulation includes different types of emergency units, each with specific capabilities:
    * Police: Handle crime incidents.
    * Firefighters: Handle fire incidents.
    * Ambulances: Handle medical emergencies.
    * Hazmat Teams: Handle chemical spills.
* **Incidents:** The simulation generates random incidents of different types at various locations.
* **Incident Handling:** The system determines the appropriate emergency unit to respond to each incident.
* **Scoring:** The simulation calculates a score based on the system's ability to handle incidents.
* **Simulation Loop:** The simulation runs through a series of incidents, providing a basic overview of emergency response operations.

## How it Works

1.  **Initialization:**
    * The program initializes a list of emergency units.
    * It defines arrays of possible incident types and locations.
    * A random number generator is created to simulate incidents.
2.  **Incident Generation:**
    * The simulation loops through a predefined set of incident types.
    * For each incident type, a random location is selected.
    * An `Incident` object is created with the type and location.
3.  **Unit Dispatch:**
    * The `FindAppropriateUnit` method iterates through the list of emergency units to find one that can handle the incident type.
    * If a suitable unit is found, it is dispatched to the incident.
    * If no suitable unit is found, the incident is marked as unhandled.
4.  **Response and Scoring:**
    * The dispatched unit "responds" to the incident (in this case, by writing to the console).
    * The score is updated based on whether the incident was handled successfully.
5.  **Output:**
    * The simulation displays the details of each incident, the responding unit (if any), and the current score.
    * At the end of the simulation, the final score is displayed.

## Intended Use

This simulation provides a basic framework for understanding how an emergency response system might work. It can be used as a starting point for more complex simulations that include factors such as:

* Unit availability and location
* Response times
* Resource management
* Different incident priorities
* More detailed incident response logic

## Further Development

This simulation could be expanded in several ways, including:

* Implementing a more realistic mapping and dispatching system.
* Adding a graphical user interface.
* Simulating the movement of emergency units.
* Modeling the interaction between different types of units.
* Incorporating real-world data on incident frequencies and response times.
# My C# Project

## Short Report: OOP Concepts and Lessons Learned

### 1. OOP Concepts Used

�   **Inheritance:** I used inheritance to create specialized emergency unit classes (Police, Firefighter, Ambulance) that inherit from a common `EmergencyIncident` base class. This allowed me to reuse common properties and methods while defining unique behaviors for each unit type.
�   **Polymorphism:** Polymorphism was implemented through the `CanHandle` and `RespondToIncident` methods. Each subclass overrides these methods to handle incidents in its specific way.
�   **Abstraction:** The `EmergencyIncident` class is an abstract class, providing a common interface for all incident types. This hides the complexity of the specific incident handling from the main simulation loop.
�   **Encapsulation:** I encapsulated the incident type and location within the `Incident` class, ensuring that these properties are accessed and modified through controlled methods.

### 2. Simple Text-Based Structure (Class Diagram)

Here's a simplified text-based representation of the class structure:
```
EmergencyIncident (Abstract)
  |
  +-- Police
  |
  +-- Firefighter
  |
  +-- Ambulance

Incident
```
### 3. Lessons Learned and Challenges Faced

�   **Challenge:** Modeling realistic behavior was a challenge. Determining how to accurately simulate the response time of the emergency units and the impact of factors like traffic congestion. I simplified this for the sake of the assignment, but I recognize it's a complex area.
�   **Lesson Learned:** I learned the importance of planning the class hierarchy and method signatures *before* writing the code. This helped me to avoid significant refactoring later.
�   **Challenge:** I realized that the current design would not scale well to a larger city with many more units and incidents. I would need to consider different architectural patterns to handle the increased complexity.
�   **Lesson Learned:** I discovered that using a simple `List` for the emergency units was inefficient for quickly finding a suitable responder. In a more complex simulation, I would explore using a dictionary or other data structure to optimize the search process.
�   **Challenge:** Debugging the simulation logic, especially when dealing with random events, was challenging. I found that carefully tracing the code execution and adding logging statements was helpful.
�   **Lesson Learned:** The initial design did not fully account for the different speeds of the units, making the simulator feel less realistic. I improved it by adding a `Speed` property to the units.
�   **Challenge:** It was challenging to do and I was not sure where to look for all my files, especially where to save the README.MD file
�   **Lesson Learned:** - Working with Github was easier than anticipated and the file structure. I finally found where it was supposed to go with the use of your help"

