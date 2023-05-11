# Banker's Algorithm with GUI
This is an implementation of the banker's algorithm, a deadlock avoidance algorithm used in operating systems, with a graphical user interface (GUI) built in C#. The program allows users to specify the number of processes and resources, and the maximum and available resources for each process. It then calculates whether the system is in a safe state and displays the result on the GUI.
# Installation
To use this program, you will need to have Visual Studio installed on your computer. Once you have [Visual Studio](https://visualstudio.microsoft.com/) installed, you can download or clone the repository from GitHub. <br /><br />
**Open the solution file Banker's Algorithm.sln in Visual Studio and build the project.**
# Usage
 <span style="color:green;font-weight:700;font-size:20px">
When you run the program, you will see:
 </span>
- a GUI that allows you to specify the number of processes and resources<br />
![setup system](/Screenshots/setup_system.png)<br/>
- Input **Maximum** need for each process, **current allocation**, and **Total resources** and press *Calculate*<br/>
![Data1](/Screenshots/Data1.png)<br/>
- The Available resources will be calculated in the **Available** table<br/>
![Data2](/Screenshots/Data2.png)<br/>
- Select process number, resource number, and number of the selected resource from the drop down menu<br/>
![Request](/Screenshots/Request.png)<br/>
- If the **Request** is valid the safe sequence will be displayed<br/>
![Result](/Screenshots/Result.png)<br/>
