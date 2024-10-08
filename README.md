# Zapper Software Developer Assessment

This repository contains my solution to the Zapper Software Developer Assessment, where I designed a database schema and implemented user settings management using C#.

## Problem Description

### 1. **Database Design**

Zapper facilitates transactions between customers and merchants. The goal was to create a database schema that tracks transactions between these parties.

### 2. **User Settings**

The user profile consists of 8 boolean settings that determine the functionality a user has enabled:
1. SMS Notifications Enabled
2. Push Notifications Enabled
3. Biometrics Enabled
4. Camera Enabled
5. Location Enabled
6. NFC Enabled
7. Vouchers Enabled
8. Loyalty Enabled

Two tasks were required:
- **Check if a feature is enabled** given a string representing user settings.
- **Store and retrieve settings** in the least amount of space.

## Solution Overview

### 1. **Database Design**

I designed three tables: `Customers`, `Merchants`, and `Transactions`. These allow the tracking of customer and merchant details and their associated transactions. 


I created 3 c# functions
  IsFeatureEnabled - returns bool to check if a feature is set

  SaveSettingsToFile - Saves the setting to a file

  LoadSettingsFromFile - Loads settings froma file

