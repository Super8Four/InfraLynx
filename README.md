# Infralynx - Infrastructure Resource Modeling (IRM) Tool

Infralynx is an Infrastructure Resource Modeling (IRM) tool built with ASP.NET Core and SQL Server. It provides a comprehensive solution for managing network infrastructure resources including devices, IP addresses, circuits, and sites.

## Features

### Device Management
- Track network devices with detailed attributes
- Manage device types, roles, and status
- Rack and position management
- Site association

### IP Address Management (IPAM)
- IP address tracking and assignment
- Subnet management
- VLAN support
- Interface assignment

### Circuit Management
- Circuit tracking
- Provider management
- Circuit type definitions
- Termination tracking

### Site Management
- Site inventory
- Region and facility tracking
- Status management

### Authentication & Authorization
- Local authentication
- Role-based access control
- API token authentication
- Active Directory integration (optional)

### Reporting
- Device inventory reports
- IP utilization reports
- Circuit status reports
- Export to CSV/HTML

## Technical Stack

- **Backend**: ASP.NET Core with Razor Pages
- **Database**: Microsoft SQL Server
- **Hosting**: IIS
- **API**: Swagger/OpenAPI documentation
- **Authentication**: ASP.NET Identity with optional AD integration

## Getting Started

### Prerequisites

- .NET 9.0 SDK
- SQL Server (Express edition is sufficient)
- Visual Studio 2022 or Visual Studio Code

### Installation

1. Clone the repository
2. Update the connection string in `appsettings.json`
3. Run the following commands:

```bash
dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```

### Development

The solution is organized into three main projects:

- **Infralynx.Core**: Contains domain models and business logic
- **Infralynx.Data**: Contains data access layer and Entity Framework Core configuration
- **Infralynx.Web**: Contains the web application, Razor Pages, and API controllers

## API Documentation

The API documentation is available at `/swagger` when running the application in development mode.

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details. 