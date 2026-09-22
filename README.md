# Portfolio

A personal developer portfolio built with **ASP.NET Core and C#**.

The purpose of this project is to create a personal portfolio where I can showcase my development projects, skills and experience while continuously improving the application as I learn more about .NET and web development.

This project is also being used as a learning project to explore **ASP.NET Core, Razor Pages, C#, application architecture and database-driven applications**.

> 🚧 This project is currently under development and new features will be added over time.

---

## 🚀 Current Features

The portfolio currently includes:

* Personal hero section with name and developer role
* Project showcase section
* Dynamic project cards
* Project information including:

  * Title
  * Description
  * Technologies used
  * GitHub repository link
* Reusable Razor Partial for project cards
* Responsive layout
* Custom styling and portfolio design

Projects are currently defined in the application's code and passed to the Razor Page through the PageModel.

---

## 🛠️ Tech Stack

### Backend

* **C#**
* **.NET 10**
* **ASP.NET Core**
* **Razor Pages**

### Frontend

* **HTML**
* **CSS**
* **Razor**
* **Bootstrap**

### Development Tools

* **Visual Studio 2026**
* **Git**
* **GitHub**

---

## 🏗️ Project Structure

The project is built using the Razor Pages architecture provided by ASP.NET Core.

A simplified version of the structure looks like this:

```text
DeveloperPortfolio/
│
├── Portfolio/
│   │
│   ├── Models/
│   │   └── Project.cs
│   │
│   ├── Pages/
│   │   ├── Index.cshtml
│   │   ├── Index.cshtml.cs
│   │   └── Shared/
│   │       └── ...
│   │
│   ├── wwwroot/
│   │   ├── css/
│   │   ├── js/
│   │   └── ...
│   │
│   └── Program.cs
│
├── Portfolio.slnx
└── README.md
```

The project structure will evolve as new functionality is introduced.

---

## 📦 Project Model

Projects are currently represented using a `Project` model.

Each project contains information such as:

```csharp
public class Project
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Technologies { get; set; } = "";
    public Uri? GitHubUrl { get; set; }
}
```

The portfolio uses a collection of these projects and loops through them using Razor to generate the project cards dynamically.

This makes it possible to add multiple projects without having to manually duplicate the HTML markup for every project.

---

## 🧩 Reusable Components

The project uses Razor Partials to separate reusable UI components from the main page.

The project card markup has been moved into a Partial so that the main `Index.cshtml` page is responsible primarily for displaying the collection of projects, while the Partial is responsible for rendering an individual project card.

This makes the application easier to maintain and provides a foundation for adding more reusable components in the future.

---

## 💻 Running the Project Locally

### Prerequisites

Make sure you have the following installed:

* [.NET 10 SDK](https://dotnet.microsoft.com/)
* Visual Studio 2026 or another compatible .NET development environment
* Git

### Clone the repository

```bash
git clone https://github.com/VictorJaque91/DeveloperPortfolio.git
```

Navigate into the project:

```bash
cd DeveloperPortfolio
```

### Run the application

From the project directory:

```bash
dotnet run
```

Alternatively, open the solution in Visual Studio and run the project using the built-in development server.

---

## 🗺️ Roadmap

The portfolio is planned to become a more complete database-driven web application.

### 🔐 Admin Authentication

Add an admin login system that allows the portfolio owner to securely manage the content.

The goal is to be able to:

* Log in as an administrator
* Add new projects
* Edit existing projects
* Delete projects
* Manage project information without modifying the source code

This will eventually provide a simple administration interface for managing the portfolio.

---

### 🗄️ Database Integration

Replace the current in-code project data with a database.

The database will eventually contain the portfolio's data, including projects and potentially other content.

Planned functionality includes:

* Store projects in a database
* Retrieve projects dynamically
* Add projects through the admin interface
* Edit projects
* Delete projects
* Persist changes between application restarts

This will also provide experience with database-driven applications and **Entity Framework Core**.

---

### 🧱 Expand the Portfolio

Additional sections are planned as the project develops.

Potential future sections include:

* About Me
* Skills
* Experience
* Education
* Contact
* More detailed project pages

---

### 🎨 UI Improvements

Continue improving the visual design and user experience.

Possible improvements include:

* Improved animations
* Better mobile experience
* More interactive project cards
* Project detail pages
* Dark/light theme
* Improved navigation

---

## 🎯 Project Goals

This project is more than just a portfolio website.

It is also a learning project where I am applying concepts learned while studying .NET development.

The main goals are to gain practical experience with:

* C#
* ASP.NET Core
* Razor Pages
* Object-oriented programming
* Reusable components
* Application architecture
* Entity Framework Core
* SQL databases
* Authentication and authorization
* CRUD operations
* Git and GitHub
* Web development

The project will evolve as my knowledge and experience with .NET grows.

---

## 📈 Development Status

| Feature                       | Status     |
| ----------------------------- | ---------- |
| Portfolio layout              | ✅ Complete |
| Hero section                  | ✅ Complete |
| Project cards                 | ✅ Complete |
| Dynamic project rendering     | ✅ Complete |
| Reusable project card Partial | ✅ Complete |
| Custom styling                | 🚧 Ongoing |
| Database                      | 📋 Planned |
| Entity Framework Core         | 📋 Planned |
| Admin authentication          | 📋 Planned |
| Project management UI         | 📋 Planned |
| Create projects               | 📋 Planned |
| Edit projects                 | 📋 Planned |
| Delete projects               | 📋 Planned |
| Project detail pages          | 📋 Planned |
| Additional portfolio sections | 📋 Planned |

---

## 👨‍💻 About the Project

This portfolio is being developed as part of my journey towards becoming a **.NET System Developer**.

Rather than building the entire application at once, the project is being developed incrementally. Each new feature is an opportunity to learn and apply another part of the .NET ecosystem.

The long-term goal is to have a fully functional portfolio where the content can be managed through an authenticated administration interface instead of requiring changes directly in the source code.

---

## 📄 License

This project is intended as a personal portfolio and learning project.
