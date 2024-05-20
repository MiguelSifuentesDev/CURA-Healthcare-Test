# CURA Healthcare Service Automation Project

This project aims to automate the testing of the CURA Healthcare Service website (https://katalon-demo-cura.herokuapp.com/) using Selenium and C#. The automation covers various functionalities of the website, including login, appointment booking, and navigation.

## Table of Contents
- [Project Structure](#project-structure)
- [Prerequisites](#prerequisites)
- [Setup Instructions](#setup-instructions)
- [Running Tests](#running-tests)
- [Test Cases](#test-cases)
- [Contributing](#contributing)
- [License](#license)

## Project Structure
```markdown
CURA-Healthcare-Test/
├── Tests/
│   ├── HomePageTests.cs
│   ├── LoginTests.cs
│   ├── AppointmentTests.cs
│   └── HistoryTests.cs
├── Utils/
│   └── TestBase.cs
├── .gitignore
├── README.md
├── cura-automation.csproj
└── packages.config


## Prerequisites

- Visual Studio 2019 or later
- .NET Core SDK
- Chrome Browser
- NuGet packages:
  - NUnit
  - Selenium.WebDriver
  - Selenium.WebDriver.ChromeDriver
  - Selenium.Support

## Setup Instructions

1. **Clone the Repository**:
    ```bash
    git clone https://github.com/MiguelSifuentesDev/CURA-Healthcare-Test.git
    cd CURA-Healthcare-Test
    ```

2. **Open the Project**:
    Open `CURA-Healthcare-Test.sln` in Visual Studio.

3. **Restore NuGet Packages**:
    Visual Studio should automatically restore the NuGet packages. If not, restore them manually:
    ```bash
    dotnet restore
    ```

   ## Running Tests

1. **Run All Tests**:
    - Open Test Explorer in Visual Studio (`Test > Windows > Test Explorer`).
    - Click on `Run All` to execute all the tests.

2. **Run Specific Test**:
    - In Test Explorer, right-click on the test you want to run and select `Run Selected Tests`.

## Test Cases

### 1. Verify Home Page Title
- **Description**: Verify that the home page title is "CURA Healthcare Service".
- **File**: `HomePageTests.cs`

### 2. Navigate to Login Page
- **Description**: Check if clicking the "Make Appointment" button redirects to the login page.
- **File**: `HomePageTests.cs`

### 3. Successful Login
- **Description**: Ensure that a user can log in with valid credentials.
- **File**: `LoginTests.cs`

### 4. Unsuccessful Login
- **Description**: Verify that an error message is displayed when login with invalid credentials.
- **File**: `LoginTests.cs`

### 5. Make an Appointment
- **Description**: Verify that a logged-in user can make an appointment.
- **File**: `AppointmentTests.cs`

### 6. Verify Appointment History
- **Description**: Check if the user can view their appointment history.
- **File**: `HistoryTests.cs`

### 7. Logout from Application
- **Description**: Ensure that a logged-in user can log out.
- **File**: `LoginTests.cs`

### 8. Verify Facilities Dropdown Options
- **Description**: Check the options available in the facilities dropdown on the appointment page.
- **File**: `AppointmentTests.cs`

### 9. Verify Page Footer Content
- **Description**: Verify the content of the footer on the home page.
- **File**: `HomePageTests.cs`

### 10. Verify Appointment Date Format Validation
- **Description**: Check the validation for the appointment date field.
- **File**: `AppointmentTests.cs`

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Create a new Pull Request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
