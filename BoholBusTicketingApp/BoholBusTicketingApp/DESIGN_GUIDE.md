# Bohol Bus Ticketing System - Design Guide

## 🎨 Design Philosophy
**Minimalist + Professional**
- Clean, modern interface with ample whitespace
- Consistent color scheme and typography
- Focus on functionality and user experience
- Professional yet approachable

## 🎯 Color Palette

### Primary Colors
- **Primary Blue**: `#1967D2` - Main action color, buttons, highlights
- **Light Blue**: `#4FC3F7` - Hover states, secondary elements
- **Dark Blue**: `#0D47A1` - Active states, emphasis

### Accent Colors
- **Success Green**: `#388E3C` - Positive actions, success messages
- **Warning Orange**: `#FB8C00` - Warnings, caution messages
- **Danger Red**: `#D32F2F` - Errors, destructive actions

### Neutral Colors
- **Background**: `#FAFAFA` - Off-white, reduces eye strain
- **Surface**: `#FFFFFF` - Cards, inputs, surfaces
- **Text Primary**: `#212121` - Main text
- **Text Secondary**: `#757575` - Secondary information
- **Border**: `#E0E0E0` - Subtle borders
- **Disabled**: `#BDBDBD` - Disabled states

## 🔤 Typography

- **Font Family**: Segoe UI (Windows native, clean, professional)
- **Heading**: 18pt Bold - Page titles
- **Sub-Heading**: 14pt Bold - Section titles
- **Body**: 9pt Regular - Default text
- **Button**: 11pt Bold - Action buttons
- **Label**: 10pt Regular - Form labels

## 🎮 Component Styles

### Buttons
- Flat design with no borders
- 40px height for easy clicking
- Primary: Blue background, white text
- Secondary: Gray background, dark text
- Hover: Slightly darker shade
- Cursor changes to hand on hover

### Text Inputs
- 35px height for touch-friendly interface
- White background with subtle border
- Clear placeholder text
- Consistent padding

### Dropdowns
- Same height as text inputs (35px)
- Dropdown list style
- Clear options list

### Forms
- Centered on screen
- Ample padding (30px minimum)
- Maximum width: 550px for single column, 1200px for dashboards
- Consistent spacing between elements

### Data Tables
- Light header background with white text
- Alternating row colors (very subtle)
- Readable font sizes
- Right-aligned numbers

## 📐 Layout Patterns

### Login Form
```
┌─────────────────────────────┐
│         Title               │
│      Subtitle               │
│                             │
│  Username Input             │
│  Password Input             │
│                             │
│  [Login] [Exit]             │
└─────────────────────────────┘
```

### Ticket Creation Form
```
┌─────────────────────────────┐
│         Create Ticket       │
│                             │
│  Passenger Name             │
│  [Input]                    │
│                             │
│  From Location              │
│  [Dropdown]                 │
│                             │
│  To Location                │
│  [Dropdown]                 │
│                             │
│  Distance: 25.5 km          │
│  Fare: ₱87.50               │
│                             │
│  [Create] [Cancel]          │
└─────────────────────────────┘
```

### Conductor Dashboard
```
┌──────────────────────────────────────┐
│  Welcome, Name                       │
│  ID: 12345                           │
│                                      │
│  Today's Tickets                     │
│  ┌────────────────────────────────┐  │
│  │ Ticket | Passenger | From | To │  │
│  │ ...                             │  │
│  └────────────────────────────────┘  │
│                                      │
│  [Create Ticket] [Logout]            │
└──────────────────────────────────────┘
```

### Admin Dashboard
```
┌──────────────────────────────────────┐
│  Admin Dashboard                     │
│                                      │
│  Select Date: [Picker] [View]        │
│                                      │
│  Daily Report                        │
│  ┌────────────────────────────────┐  │
│  │ Detailed ticket information   │  │
│  └────────────────────────────────┘  │
│                                      │
│  Summary                             │
│  Total Tickets: 45                   │
│  Total Fare: ₱2,340.50               │
│                                      │
│  [View Report] [Export] [Logout]     │
└──────────────────────────────────────┘
```

## ✨ User Experience Features

### Validation
- Real-time distance and fare calculation
- Clear error messages in warnings
- Required field validation
- Confirmation dialogs for destructive actions

### Feedback
- Success messages after actions
- Loading states for operations
- Clear status indicators
- Disabled states for unavailable actions

### Navigation
- Consistent button placement
- Logical flow between screens
- Easy logout option always visible
- Clear back/cancel options

## 📱 Responsive Design
- Desktop-first approach (1000-1200px minimum)
- Generous touch targets (40px minimum for buttons)
- Clear visual hierarchy
- Readable font sizes (9pt minimum)

## 🔐 Professional Details
- All currency displayed as ₱
- Dates in YYYY-MM-DD format
- Times in HH:MM:SS format
- IDs clearly labeled
- Professional error messages
- No technical jargon in UI

## 🎯 Usage of ThemeManager
Use the `ThemeManager` class to apply consistent styling:

```csharp
// Apply theme to form
ThemeManager.StyleForm(this);

// Style controls
ThemeManager.StyleButton(myButton, isPrimary: true);
ThemeManager.StyleTextBox(myTextBox);
ThemeManager.StyleComboBox(myComboBox);
ThemeManager.StyleLabel(myLabel, isHeading: false);

// Access colors directly
this.BackColor = ThemeManager.BackgroundColor;
myLabel.ForeColor = ThemeManager.TextPrimary;
```

## 🚀 Future Enhancements
- Dark mode toggle
- Custom themes
- Accessibility improvements (WCAG compliance)
- Print-friendly report layouts
- Mobile app version
