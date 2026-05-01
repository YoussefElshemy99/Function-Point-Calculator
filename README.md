# Function Point Calculator

## Introduction
This is a C# Windows Forms application developed to estimate software size and effort using the **Function Point (FP)** methodology. By inputting specific software characteristics and technical complexity factors, this tool calculates the Unadjusted Function Points (UFP), Total Complexity Factor (TCF), Function Points (FP), and the estimated Lines of Code (LOC) based on the target programming language.

## Problem Statement
Software estimation is a critical phase in project management. Manual calculation of Function Points is prone to human error and can be time-consuming. This application automates the process by adhering to standard FP counting rules, applying hardcoded complexity weights, and utilizing standard Language Average Source Code (AVC) metrics to deliver accurate sizing estimates.

## Features
* **UFP Calculation:** Inputs for External Interface Files, Internal Logical Files, External Inputs, External Outputs, and External Inquiries.
* **TCF Calculation:** Ability to enter the Degree of Influence (DI) directly or calculate it by rating 14 General System Characteristics on a 0-5 scale.
* **LOC Estimation:** A dropdown list containing industry-standard AVC values for various programming languages (e.g., C++, C#, Java, Assembly) to convert FP into estimated Lines of Code.
* **Intuitive GUI:** A clean, user-friendly interface designed for rapid data entry during practical assessments.

## Technologies Used
* **Language:** C#
* **Framework:** .NET / Windows Forms
* **IDE:** Visual Studio

## How to Run
1. Clone this repository to your local machine.
2. Open `FunctionPointCalculator.sln` in Visual Studio.
3. Build the solution (`Ctrl + Shift + B`) to restore any dependencies.
4. Press `F5` to run the application.

## Repository Structure
* `/UI`: Contains the main Windows Forms and graphical layout logic.
* `/Logic`: Contains the core mathematical engine for FP calculation.
* `/Data`: Stores the static/hardcoded matrices for complexity weights and Language AVCs.