# Barangay-Cases-Management-System-Desktop-App

Desktop application for Barangay Cases Management System

## Prerequisites

- [XAMPP](https://www.apachefriends.org/index.html): Ensure you have XAMPP installed on your system.
- [MongoDB Server](https://fastdl.mongodb.org/windows/mongodb-windows-x86_64-7.0.3-signed.msi)
- [Visual Studio 2022](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false)

## Installation

1. Clone or download the project files to your local machine.

## PHPMyAdmin

### User Account Setup

1. Open your favorite web browser and type `http://localhost/phpmyadmin/` to locate your phpMyAdmin Page. 

2. Click `User Accounts` tab, then click `Add user account`. Input the corresponding details:
   - User name: `all_system_user`
   - Host name: `%`
   - Password: `admin123`
   - Re-type: `admin123`

3. On the `Global privileges`, click `Check all`, then click `Go`.

### Database Setup

1. Create a database named `all_system_database`.

2. Click `Import` tab, then on the `Choose File` input, select the [all_system_database.sql](all_system_database.sql) and click `Import` on the very bottom part.

## Usage

1. Open the [Barangay Cases Management System.sln](Barangay Cases Management System.sln) to your Visual Studio 2022.

2. Start the XAMPP Control Panel and launch the Apache and MySQL service.

3. Click the `Start Button`, the green triangle button.

## License

This project is open-source and available under the [MIT License](LICENSE).