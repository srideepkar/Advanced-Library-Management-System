# Advanced Library Management Application
This is an advanced library management system application which will allow you to manage advance library management operations like adding new books, replacing old books, changing the availability status etc. for library managers & and searching books, filtering books by category, viewing book status and as per the status issue the book for a time period.

Technology I'm going to use here: (As per the planning)
Mostly the project will be based on Dot Net 6.0 along with C# 10.0 and for few the cases which need client-side rendering for better SEO management & and UI interaction, I'm going to use React JS. For user authentication, Ihave used Entity Framework Core Identity UI. Rest will update soon!

# What is done?
1. Created a base CRUD structure for the application which allows you to perform add/edit/delete books operations with Dot Net Core MVC.
2. Added authentication support using Entity Framework Core Identity UI.
3. Added authorization with role management (Roles are Admin: Who has the power of god, Manager who manages books & members and the Members.)
4. modified the UI besed on the roles. (eg. Member doesent have permission to modify books so the edit & delete buttons are hidden for members)
   

# Whats I'm working on?
1. Modify the UI
2. Add the book issuing part for users

# System Design:
**Functional Requirements:**
- Admin can do anything that can Managers & Members do
- Managers can add books
- Managers can remove books
- Managers can manage (Add/Remove/Update) members
- Members can borrow books
- Members can submit books
- Members can pay fines
- Members & admin both can search/filter books

**High level Design**

![Library management System](https://github.com/srideepkar/Advanced-Library-Management-System/assets/54681888/bd346e36-7ecb-4a90-ba05-0f4a348f4efd)


