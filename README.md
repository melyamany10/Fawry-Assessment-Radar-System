This project is buit for Fawry internship challange. It is a OOP system for a traffic radar. The system do many things to catch cars that break the law and make tickets for them.

## Main Classes and functions

*   **Physical_Radar_Info**: This class just hold informashun about the car coming from the physical radar (like plate number, speed, what type of car).
*   **Violations**: This class is like the ticket. It have the discription of what rule is broken and the fine value (how much money).
*   **TrafficRules (Interface)**: Every rule must use this. It have one function called `Evaluate` that look at the car and return a Violation if bad or null if good.
*   **Seat_Belt_Rule & Speed_Limit_Rule**: These are the specific rules. They inherit the TrafficRules and do the actual check. If truck speed > 60 it make a Violation.
*   **QuRadar**: This is the main brain of teh system! 
    *   `ProcessObservation()`: Check the car against all rules and save the fines. It print the ticket immediately.
    *   `getAllPossibleFines()`: Print all cars and there total fine money.
    *   `reportAllViolationCount()`: Show how many times each rule was breaked.
    *   It have dictionaries `Vehicle_History` and `Violations_Count` to remember all the things.
*   **Program**: This have the super loop (while true) to let the user enter data or test mock cars.

## Handwritten Notes
(https://drive.google.com/drive/folders/1R5roXn5rKXNSXfpM-F-dOy3nAKfNex4w?usp=sharing)
