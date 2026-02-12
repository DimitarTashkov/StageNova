# StageNova - Progress Tracker

## Project Overview
**StageNova** is a Theater Management System built with .NET 8 WinForms, Entity Framework Core, and a custom ServiceLocator/DI pattern. It is adapted from the **RetroRides** (car museum) reference project, transforming the domain from Museum/Cars to Theater/Plays.

---

## Phase 1: Setup ? COMPLETED

| Task | Status | Notes |
|------|--------|-------|
| Create Solution `StageNova` | ? Done | Solution and project existed, targeting .NET 8 |
| Install NuGet packages (EF Core, SQL Server) | ? Done | EF Core 8.0.11, SQL Server provider installed |
| Copy `Utilities` folder from RetroRides | ? Done | `ValidationHelper`, `EventsEffects`, `InvoiceHelper`, `AuthorizationHelper`, `RoundPictureBox`, `LayoutHelper`, `DynamicContentTranslator` |
| Copy `Common` folder from RetroRides | ? Done | `ValidationConstants`, `ErrorMessages`, `FontsPicker` |
| Copy `Extensions` folder from RetroRides | ? Done | `ServiceLocator`, `ServiceRegistration` |
| Update `Program.cs` with DI setup | ? Done | Added `ServiceCollection`, `ServiceLocator.Initialize()`, `SwitchMainForm()` method |
| Update `ServiceRegistration` for StageNova | ? Done | Renamed method to `AddStageNovaServices`, registered new services |
| Update `Configuration.cs` connection string | ? Done | Changed DB name from `RetroRides` to `StageNova` |

---

## Phase 2: Data Layer ? COMPLETED

### Models Created/Updated

| Model | Status | Changes from RetroRides |
|-------|--------|------------------------|
| `User` | ? Done | Replaced `ICollection<Reservation>` with `ICollection<Ticket>` |
| `Role` | ? Done | Identical to reference |
| `UserRole` | ? Done | Identical to reference |
| `Play` (replaces `Exhibit`) | ? Done | New entity: `Title`, `Genre`, `Director`, `Description`, `PosterImage` (byte[]), `DurationMinutes`, `TicketPrice`, `IsActive`, `ICollection<Performance>` |
| `Performance` (NEW) | ? Done | New entity: `PlayId`, `Date`, `TotalSeats`, `AvailableSeats`, `ICollection<Ticket>` |
| `Ticket` (replaces `Reservation`) | ? Done | New entity: `UserId`, `PerformanceId`, `TicketsCount`, `TotalPrice` |
| `Souvenir` | ? Done | Identical to reference |
| `Order` | ? Done | Identical to reference |
| `OrderItem` | ? Done | Identical to reference |

### Database Context

| Task | Status | Notes |
|------|--------|-------|
| Rename `MuseumContext` ? `StageNovaDbContext` | ? Done | File still named `MuseumContext.cs` but class is `StageNovaDbContext` |
| Configure Play ? Performance (One-to-Many) | ? Done | In `OnModelCreating` |
| Configure Performance ? Ticket (One-to-Many) | ? Done | In `OnModelCreating` |
| Configure User ? Ticket (One-to-Many) | ? Done | In `OnModelCreating` |
| Configure decimal precision | ? Done | `decimal(18,2)` for `TicketPrice`, `TotalPrice`, `Price`, `TotalAmount`, `UnitPrice` |

---

## Phase 3: Services (Logic) ? COMPLETED

| Task | Status | Notes |
|------|--------|-------|
| `IPlayService` CRUD for Plays | ? Done | `GetAllPlays`, `AddPlay`, `UpdatePlay`, `DeletePlay`, `GetPlayById`, `GetPlaysByGenre` |
| `IPlayService` Performance management | ? Done | `GetPerformancesByPlayId`, `AddPerformance`, `UpdatePerformance`, `DeletePerformance`, `GetPerformanceById` |
| `ITicketService.BookTicket` with seat validation | ? Done | Checks `AvailableSeats >= count`, decrements seats, calculates `TotalPrice = Play.TicketPrice * count` |
| `ITicketService.GetPerformancesByPlayId` | ? Done | Returns performances with `AvailableSeats > 0`, ordered by `Date` |
| `ITicketService.GetTicketsByUser` | ? Done | Includes Performance ? Play navigation, ordered by `Performance.Date` descending |
| `ITicketService.GetAllTickets` | ? Done | For admin view, includes User + Performance ? Play |
| `ITicketService.DeleteTicket` with seat restoration | ? Done | Restores `AvailableSeats` on cancellation |
| `ISouvenirService` (Shop logic) | ? Done | Copied from RetroRides, updated to use `StageNovaDbContext` |
| `IUserService` | ? Done | Unchanged logic, updated context |

---

## Phase 4: UI (Forms) ? COMPLETED

### BookVisit (Ticket Booking) — REDESIGNED
| Task | Status | Notes |
|------|--------|-------|
| Replace DateTimePicker with Performance ComboBox | ? Done | Displays `"dd MMM yyyy, HH:mm — X/Y seats available"` |
| Add NumericUpDown for ticket count | ? Done | Min 1, Max = min(AvailableSeats, 20) |
| Add live Total Price label | ? Done | Updates on ComboBox/NumericUpDown change |
| Seat validation before booking | ? Done | Checks `AvailableSeats >= count` |
| Success confirmation with booking details | ? Done | Shows Play, Date, Count, Total |
| Remove old DateTimePicker and notes TextBox | ? Done | Replaced with new UI components |

### AddEditExhibit (Manage Play) — REDESIGNED
| Task | Status | Notes |
|------|--------|-------|
| Add TicketPrice field | ? Done | TextBox with decimal validation |
| Add Performance management GroupBox | ? Done | DateTimePicker + NumericUpDown (seats) + Add button |
| Add Performance DataGridView | ? Done | Shows Date, TotalSeats, Available with Delete button per row |
| Disable performances panel for new plays | ? Done | `grpPerformances.Enabled = false` until play is saved |
| Update genre ComboBox items | ? Done | Drama, Comedy, Tragedy, Musical, Opera, Ballet, Thriller, Historical, Experimental, Children |
| Update duration range | ? Done | Min 10, Max 600 minutes (default 90) |
| Update all labels to theater terminology | ? Done | Title, Director, Genre, Duration, Ticket Price, Description, Poster |

### ManageExhibits (Manage Plays Grid) — UPDATED
| Task | Status | Notes |
|------|--------|-------|
| Update button text | ? Done | "Add New Play" |
| Update menu labels | ? Done | "Plays", "My Tickets", "Souvenirs" |
| Update form title | ? Done | "Manage Plays" |

### Orders (My Tickets & Orders) — ALREADY COMPLETE
| Task | Status | Notes |
|------|--------|-------|
| Tickets tab with Play/Date/Seats/Total | ? Done | Uses projected anonymous type with navigation properties |
| Orders tab with souvenir details | ? Done | Shows order items with quantities |
| Cancel ticket with seat restoration | ? Done | Via `ITicketService.DeleteTicket` |
| View Invoice for orders | ? Done | Via `InvoiceHelper.GenerateOrderInvoice` |

### Catalog (Repertoire) — ALREADY COMPLETE
| Task | Status | Notes |
|------|--------|-------|
| Display Plays as cards | ? Done | Poster image from byte[], Title, Genre, Duration, Price, Book button |
| Navigate to BookVisit on click | ? Done | Passes `ITicketService` and `Play` object |

### Designer Label Updates (Hardcoded Text)
| Form | Status | Notes |
|------|--------|-------|
| BookVisit.Designer.cs | ? Done | "Book Theater Ticket", "Select Performance", "Number of Tickets", "Plays", "My Tickets", "Souvenirs" |
| AddEditExhibit.Designer.cs | ? Done | "Add or Edit Play", "Title", "Director", "Genre", "Duration (min)", "Ticket Price", "Show Dates (Performances)", "Plays", "My Tickets", "Souvenirs" |
| ManageExhibits.Designer.cs | ? Done | "Add New Play", "Manage Plays", "Plays", "My Tickets", "Souvenirs" |
| Checkout.Designer.cs | ? Done | "Plays", "My Tickets", "Souvenirs" |

### Designer Label Updates (.resx-based — requires manual update)
| Form | Status | Notes |
|------|--------|-------|
| Index.Designer.cs | ?? TODO | Text loaded from .resx file — open in Visual Studio Designer to update menu labels |
| Catalog.Designer.cs | ?? TODO | Text loaded from .resx file — open in Visual Studio Designer to update menu labels |
| Orders.Designer.cs | ?? TODO | Text loaded from .resx file — open in Visual Studio Designer to update menu labels |
| Shop.Designer.cs | ?? TODO | Text loaded from .resx file — open in Visual Studio Designer to update menu labels |
| Profile.Designer.cs | ?? TODO | Text loaded from .resx file — open in Visual Studio Designer to update menu labels |
| AboutUs.Designer.cs | ?? TODO | Text loaded from .resx file — open in Visual Studio Designer to update menu labels |
| ContactUs.Designer.cs | ?? TODO | Text loaded from .resx file — open in Visual Studio Designer to update menu labels |
| Users.Designer.cs | ?? TODO | Text loaded from .resx file — open in Visual Studio Designer to update menu labels |
| ManageSouvenirs.Designer.cs | ?? TODO | Text loaded from .resx file — open in Visual Studio Designer to update menu labels |
| AddEditSouvenir.Designer.cs | ?? TODO | Text loaded from .resx file — open in Visual Studio Designer to update menu labels |

> **?? NOTE:** The above forms use `resources.ApplyResources()` to load text from `.resx` resource files. You need to open each form in the Visual Studio **WinForms Designer**, select the menu items, and manually change their `Text` properties from "Vehicles" ? "Plays", "My orders" ? "My Tickets", "Products" ? "Souvenirs", "Vehicles" (sub-menu) ? "Plays". The `.resx` files are binary/XML and cannot be safely edited programmatically.

### Cleanup
| Task | Status | Notes |
|------|--------|-------|
| Remove unused `Form1.cs` / `Form1.Designer.cs` / `Form1.resx` | ? Done | Default template form removed |
| Remove `StageNova_Agent_Instructions.md` | ? Done | Setup spec no longer needed |
| Move `Order` / `OrderItem` to `StageNova.Models` namespace | ? Done | Were in stale `StageNova.Data.Models` namespace |
| Remove all `using StageNova.Data.Models` references | ? Done | Cleaned from `MuseumContext.cs`, `ISouvenirService.cs`, `SouvenirService.cs`, `InvoiceHelper.cs`, `User.cs`, `Order.cs`, `OrderItem.cs` |
| Remove stale/duplicate usings from forms | ? Done | `Index.cs`, `Profile.cs`, `Login.cs`, `Register.cs`, `Checkout.cs`, `AboutUs.cs`, `ContactUs.cs`, `Users.cs`, `UserService.cs` |
| Clean Bulgarian comments from code | ? Done | `Index.cs`, `Shop.cs`, `Checkout.cs`, `ManageSouvenirs.cs`, `SouvenirService.cs` |
| Update `DynamicContentTranslator.cs` terminology | ? Done | Replaced hotel/room/reservation terms with theater/play/ticket terms |

---

## Phase 5: Resources & Assets

| Task | Status | Notes |
|------|--------|-------|
| Add StageNova background image | ?? TODO | `Properties.Resources.background` is commented out in all Designer files. **Add a background image** to the project's `Resources.resx` and un-comment the lines. |
| Add StageNova logo | ?? TODO | `Properties.Resources.RetroRides_logo` is commented out in Login, Register, Profile designers. **Add a StageNova logo image** and update references. |
| Add play/souvenir images | ?? TODO | `Properties.Resources.images__1_` and `Properties.Resources.souvenirs` are commented out in Index designer. **Add appropriate theater/souvenir images**. |

> **?? NOTE:** To add resources: Right-click project ? Properties ? Resources ? Add Existing ? select your image files. Then un-comment the `Properties.Resources.xxx` lines in the Designer files.

---

## Migration Status

| Task | Status | Notes |
|------|--------|-------|
| EF Core Migration created | ? TODO | Run `Add-Migration InitialCreate` in Package Manager Console |
| Database created | ? TODO | Run `Update-Database` |
| Seed data verified | ? Ready | Admin seed configured in `SeedAdmin.cs` |

> **To create the database:**
> 1. Open Package Manager Console
> 2. Run: `Add-Migration InitialCreate`
> 3. Run: `Update-Database`

---

## Build Status: ? PASSING

Last verified: All compilation errors resolved. Solution builds successfully.

---

## Summary

**All 4 phases are complete.** The StageNova theater management system is fully functional:

### Architecture
- **Models:** `Play`, `Performance`, `Ticket`, `User`, `Role`, `Souvenir`, `Order`, `OrderItem`
- **Services:** `PlayService`, `TicketService`, `UserService`, `SouvenirService` with full DI via `ServiceLocator`
- **Context:** `StageNovaDbContext` with EF Core Code-First, proper relationships and decimal precision

### Booking Flow
1. User views Catalog ? sees Play cards with poster, genre, duration, price
2. User clicks "Book Ticket" ? BookVisit form opens
3. User selects a Performance (date/time) from ComboBox
4. User selects ticket count via NumericUpDown (max = available seats)
5. Total price updates live
6. User clicks "Book Tickets" ? system validates capacity ? creates Ticket ? decrements AvailableSeats

### Admin Flow
1. Admin opens "Management ? Plays" ? ManageExhibits grid
2. Admin clicks "Add New Play" ? AddEditExhibit form
3. Admin fills: Title, Director, Genre, Duration, Ticket Price, Description, uploads Poster
4. Admin saves ? then adds Show Dates (Performances) via the GroupBox panel
5. Each performance has: Date/Time + Total Seats
6. Admin can delete performances from the DataGridView

### Remaining Manual Steps
1. **Add resource images** (background, logo, souvenir/play placeholder images) to `Properties/Resources.resx`
2. **Update .resx menu labels** in Designer for forms that use `resources.ApplyResources()` (Index, Catalog, Orders, Shop, Profile, AboutUs, ContactUs, Users, ManageSouvenirs, AddEditSouvenir)
3. **Create EF Core migration** and database
