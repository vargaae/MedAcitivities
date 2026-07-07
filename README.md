# 🏥 EgészségÚt / MedActivities

**Healthcare Activity and Patient Management System**

## Leírás

Az **EgészségÚt (MedActivities)** egy többplatformos egészségügyi eseménykezelő és pácienskezelő rendszer.

A rendszer célja, hogy segítse a páciensek és az egészségügyi dolgozók közötti kommunikációt, valamint nyomon kövesse a betegút eseményeit, vizsgálatait, kezeléseit és dokumentumait.

A projekt a BMSZC szoftverfejlesztő képzés vizsgaremeke.

---

# Fő funkciók

## Páciens felület (React)

- Regisztráció
- Bejelentkezés
- Időpontfoglalás
- Egészségügyi események megtekintése
- Dokumentumok kezelése
- Saját profil
- Betegút követése

---

## Egészségügyi dolgozói felület (Windows Forms)

- Páciensek kezelése
- Egészségügyi események kezelése
- Időpontok kezelése
- Dokumentumok kezelése
- Megjegyzések kezelése
- Adminisztráció

---

# Technológiák

## Backend

- ASP.NET Core Web API (.NET 10)
- Entity Framework Core
- PostgreSQL
- ASP.NET Identity
- AutoMapper
- SignalR

## Frontend

- React 19
- TypeScript
- React Query
- React Router
- React Hook Form
- Zod
- Material UI

## Desktop

- Windows Forms (.NET)

---

# Architektúra

A projekt RESTful architektúrát alkalmaz.

```
React
        \
         \
          ASP.NET Core Web API
         /
Windows Forms

            │

      PostgreSQL
```

A backend biztosítja:

- autentikáció
- jogosultságkezelés
- CRUD műveletek
- üzleti logika

---

# Projekt struktúra

```
api/
application/
domain/
infrastructure/
persistence/
client/
desktop/
```

---

# Fejlesztői környezet

Szükséges:

- .NET 10 SDK
- Node.js
- PostgreSQL
- Docker Desktop (opcionális)
- Visual Studio 2022
- Visual Studio Code

---

# Indítás

Backend

```bash
dotnet watch run
```

Frontend

```bash
npm install
npm run dev
```

Desktop

Visual Studio → Start

---

# Branch stratégia

```
main
develop

feature/JIRA-XX-login
feature/JIRA-XX-patient-crud
feature/JIRA-XX-react-login
feature/JIRA-XX-desktop-admin

bugfix/JIRA-XX

hotfix/JIRA-XX
```

---

# Commit szabály

Formátum

```
JIRA-XX type: rövid leírás
```

Példák

```
MED-12 feat: implement JWT authentication

MED-18 feat: add patient CRUD endpoints

MED-25 fix: resolve appointment validation

MED-30 refactor: simplify activity query

MED-42 docs: update README
```

---

# Commit típusok

- feat
- fix
- refactor
- docs
- style
- test
- chore

---

# Pull Request

Minden feature külön branch-ben készül.

```
feature → develop

develop → main
```

A merge előtt:

- build sikeres
- tesztek lefutnak
- code review megtörtént

---

# Fejlesztők

**Varga András Ernő**

- Backend
- Database
- Windows Forms
- REST API

**Maloschik Erik**

- React frontend
- UI/UX
- API integráció
- Tesztelés

---

# Projekt állapot

🚧 Fejlesztés alatt
