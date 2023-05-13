# Banker's Algorithm with GUI
This is an implementation of the banker's algorithm, a deadlock avoidance algorithm used in operating systems, with a graphical user interface (GUI) built in C#. The program allows users to specify the number of processes and resources, and the maximum and available resources for each process. It then calculates whether the system is in a safe state and displays the result on the GUI.
# Installation
To use this program, you will need to have Visual Studio installed on your computer. Once you have [Visual Studio](https://visualstudio.microsoft.com/) installed, you can download or clone the repository from GitHub. <br /><br />
**Open the solution file Banker's Algorithm.sln in Visual Studio and build the project.**
# Usage
When you run the program, you will see a GUI that allows you to specify the number of processes and resources, and the maximum and available resources for each process. You can enter the values in the text boxes provided and click the "Calculate" button to check if the system is in a safe state.

If the system is in a safe state, you will see a message indicating that the system is safe and the order in which the processes can be executed. If the system is not in a safe state, you will see a message indicating that the system is not safe.

# How it works

The Banker's algorithm is used to prevent deadlocks in resource allocation. The algorithm works by examining the available resources, the maximum resources each process may need, and the resources already allocated to each process. Based on this information, the algorithm determines whether the system is in a safe state (i.e., there is no deadlock) and calculates the order in which the processes can be executed.

This implementation of the algorithm uses the following steps:

## 1. Setup System form
The first form in the Banker's Algorithm implementation is a GUI form that allows the user to input the number of processes and resources. <br />
### The form includes the following controls:
- Two labels that prompt the user to enter the number of processes and resources. <br/>
- Two textboxes that allow the user to enter the number of processes and resources. <br/>
- A button labeled "Enter" that the user can click to proceed to the next form. <br/>
![setup system](/Screenshots/setup_system.png)<br />
## 2. Data Form<br/>
This form is used to gather data for the Banker's algorithm simulation. It allows the user to enter information about the current state of the system, including the current allocation, maximum need, total resources available.

## Components
The form consists of the following components:

- currentAllocation: a DataGridView object that allows the user to enter the current resource allocation for each process.
- totalView: a DataGridView object that allows the user to enter the total number of resources available for each resource type.
- maxNeed: a DataGridView object that allows the user to enter the maximum need of each process for each resource type.
- available: a DataGridView object that displays the available resources after the user has entered the current allocation.
- Calculate: a button that calculates the available resources.
- Next: a button that allows the user to proceed to the next form.
## Implementation
The form is implemented as a C# class that extends the Form class. It has a constructor that takes two parameters: numProc and numRes, which specify the number of processes and resources, respectively. The constructor initializes the form by setting the numProc and numRes fields and hiding button2.

The setTables() method is used to set up the currentAllocation, totalView, maxNeed, and available DataGridView objects. It adds columns for each resource type and rows for each process.

The button1_Click() method is called when the user clicks on button1. It calculates the available resources by subtracting the used resources from the total resources for each resource type. If the user enters an incorrect value, an error message is displayed.

The button2_Click() method is called when the user clicks on button2. It creates a new Query form and passes it the necessary information to perform the Banker's algorithm simulation. The Data form is then hidden and closed.

## Usage
To use the form, the user must enter the current allocation, maximum need, and total resources available for each resource type. Once the user has entered all the data, they can click on **Calculate** to calculate the available resources. If there are no errors, **Next** will become visible, and the user can click on it to proceed to the next form.

![Data1](/Screenshots/Data1.png)<br />

3. The Available resources will be calculated in the **Available** table<br />
![Data2](/Screenshots/Data2.png)<br />
4. Select process number, resource number, and number of the selected resource from the drop down menu<br />
![Request](/Screenshots/Request.png)<br />
5. If the **Request** is valid the safe sequence will be displayed<br />
![Result](/Screenshots/Result.png)<br />

# Contributing
Contributions to this project are welcome! If you would like to contribute, please fork the repository and make your changes in a separate branch. Once you have made your changes, submit a pull request with a description of the changes you made.
