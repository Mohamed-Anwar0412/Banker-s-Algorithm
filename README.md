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

## 1. The first form in the Banker's Algorithm implementation is a GUI form that allows the user to input the number of processes and resources. <br />
### The form includes the following controls:
- Two labels that prompt the user to enter the number of processes and resources. <br/>
- Two textboxes that allow the user to enter the number of processes and resources. <br/>
- A button labeled "Enter" that the user can click to proceed to the next form. <br/>
![setup system](/Screenshots/setup_system.png)<br />
2. Input **Maximum** need for each process, **current allocation**, and **Total resources** and press *Calculate*<br/>
![Data1](/Screenshots/Data1.png)<br />
3. The Available resources will be calculated in the **Available** table<br />
![Data2](/Screenshots/Data2.png)<br />
4. Select process number, resource number, and number of the selected resource from the drop down menu<br />
![Request](/Screenshots/Request.png)<br />
5. If the **Request** is valid the safe sequence will be displayed<br />
![Result](/Screenshots/Result.png)<br />

# Contributing
Contributions to this project are welcome! If you would like to contribute, please fork the repository and make your changes in a separate branch. Once you have made your changes, submit a pull request with a description of the changes you made.
