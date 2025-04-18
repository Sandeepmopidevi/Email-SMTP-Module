# Email-SMTP-Module

This repository contains an **Email SMTP Module** designed using **C# .NET** for the backend and **Angular** for the frontend. It provides a robust solution for sending emails via SMTP, demonstrating clean architecture, seamless integration, and efficient email delivery.

---

## 🚀 Features

- **Backend**:
  - Developed with **C# .NET**.
  - Implements **SMTP protocol** for sending emails.
  - Follows a clean and modular architecture.
  - Provides RESTful APIs for email operations (e.g., sending emails).

- **Frontend**:
  - Built with **Angular** for a responsive and dynamic user experience.
  - Includes a user-friendly form for sending emails.
  - Validates user inputs.
  - Displays success or error messages dynamically.

- **Cross-Origin Support**:
  - Configured **CORS (Cross-Origin Resource Sharing)** for seamless communication between the frontend and backend.

---

## 🛠️ Technologies Used

### Backend:
- **C#**
- **.NET**
- **SMTP**

### Frontend:
- **Angular** (TypeScript)
- **CSS**
- **HTML**

---

## 📂 Project Structure

### Backend (`/`)
The backend is built with **C# .NET** and provides API endpoints for email operations.

Key files:
- `Program.cs`: Configures middleware, services, and the CORS policy.
- `EmailController.cs`: Handles email-related API requests.
- `EmailService.cs`: Contains the logic for sending emails via SMTP.

### Frontend (`/src/app`)
The frontend is built with **Angular** and includes components and services for email functionality.

Key files:
- `email.service.ts`: Angular service to interact with the backend API.
- `email-form.component.ts`: Standalone component for the email form.
- `app.routes.ts`: Angular routes configuration.

---

## ⚙️ Setup Instructions

### Prerequisites
- **.NET SDK** (v6.0 or higher)
- **Node.js** (v18 or higher)
- **Angular CLI** (v15 or higher)

### Steps to Run the Application

#### Backend:
1. Clone the repository:
   ```bash
   git clone https://github.com/Sandeepmopidevi/Email-SMTP-Module.git
   cd Email-SMTP-Module
   ```
2. Navigate to the backend directory and start the API:
   ```bash
   dotnet run
   ```
3. The API will be available at:
   ```
   https://localhost:7160
   ```

#### Frontend:
1. Navigate to the `frontend` directory:
   ```bash
   cd Email-SMTP-Module/frontend
   ```
2. Install dependencies:
   ```bash
   npm install
   ```
3. Start the Angular development server:
   ```bash
   ng serve
   ```
4. Open your browser and navigate to:
   ```
   http://localhost:4200
   ```

---

## 🧪 Testing the Module

1. Fill in the **To**, **Subject**, and **Body** fields in the email form on the Angular frontend.
2. Click the **Send Email** button.
3. Observe the success or error message displayed dynamically.
4. Check your email inbox to confirm delivery.

---

## 📦 API Endpoints

### **POST /api/Email/send**
Sends an email to the specified recipient.

**Request Body**:
```json
{
  "to": "recipient@example.com",
  "subject": "Email Subject",
  "body": "Email Body Content"
}
```

**Response**:
- `200 OK`: Email sent successfully.
- `400 Bad Request`: Validation error.

---

## 🌐 CORS Configuration

The backend (`Program.cs`) includes a CORS policy to allow requests from the Angular development server (`http://localhost:4200`).

```csharp
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
```

---

## 🤝 Contributing

Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-name
   ```
3. Make your changes and commit:
   ```bash
   git commit -m "Add new feature"
   ```
4. Push to your branch:
   ```bash
   git push origin feature-name
   ```
5. Create a pull request.


## 📧 Contact

For any inquiries, please reach out to **[Sandeep Mopidevi](mailto:asksandeepsd@gmail.com)**.

---