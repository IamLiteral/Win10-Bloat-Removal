# 🚀 Win 10 Bloat Removal — By Literal

**Win 10 Bloat Removal** is a tool designed to **debloat**, **despy**, and **de-Microsoft** your Windows 10 system with a single click. It provides a GUI-based, modular interface to remove telemetry, disable unnecessary features, and regain control of your PC — all while logging every action.

---
<img width="846" height="497" alt="image" src="https://github.com/user-attachments/assets/5d4c46ae-52d0-4f3f-8e3d-92a0f6672144" />
## 🧠 Features

### ✅ Privacy Fixes
- **Remove Telemetry Services**
  - Disables `DiagTrack`, stops related services, and disables telemetry collection.
- **Disable Cortana**
  - Shuts down Cortana permanently via registry policies.
- **Block Microsoft IPs**
  - Adds known telemetry IPs to firewall and `hosts` file.
- **Disable Feedback Prompts**
  - Prevents Windows from requesting user feedback periodically.
- **Disable Advertising ID**
  - Opts out of personalized ads by setting registry values.
- **Disable Defender Cloud Features**
  - Disables cloud-based virus sample submissions and telemetry in Microsoft Defender.
- **Disable Windows Updates**
  - Stops and disables the `wuauserv` service and enforces update-blocking registry entries.

---
 
### 🗑️ Bloatware Removal
- **Remove OneDrive**
  - Terminates OneDrive and forcibly deletes its setup files.
- **Remove Suggested Apps**
  - Removes preinstalled Appx packages and disables silent app installs.
- **Remove Xbox Bloat**
  - Uninstalls all Xbox-related UWP applications (Game Bar, Xbox Console, etc).

---

### 🛠️ GUI Features
- Modern Windows Forms UI with grouped buttons by category (Privacy, Services, Bloatware)
- Built-in **Logger Console** for real-time execution output
- **🔥 "Run All Privacy Fixes"** one-click batch action
- System Stats Panel displaying:
  - OS Version
  - CPU Info
  - RAM Amount
  - Disk Size

---

## 🛡️ How It Works

Each module is a C# class that runs a specific PowerShell script or system command. These include:

- `PowerShell` calls using `ExecutionHelper.RunPowerShell(...)`
- `Registry edits` for policy enforcement
- `Firewall rule creation` via PowerShell
- `Appx removal` using `Get-AppxPackage` and `Remove-AppxPackage`
- `Service control` using `Stop-Service` and `Set-Service`

Every executed command is **logged** into the embedded GUI console for transparency.

---

## 🧪 Requirements

- Windows 10 (21H2 or newer recommended)
- Admin rights (automatically checked)
- .NET Framework 4.7+

---

## ⚙️ Build Instructions

1. Clone the repo:
   ```bash
   git clone https://github.com/IamLiteral/Win10-Bloat-Removal.git
