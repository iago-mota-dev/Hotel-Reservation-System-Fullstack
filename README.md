<h1>Project Title: Hotel Reservation System Challenge Fullstack</h1>

<h2>Overview:</h2>
<p>This project aims to build a Hotel Reservation System that allows guests to make reservations, hotels to manage reservations, and generate reports for revenue tracking. The system consists of a backend API developed in .NET and a frontend user interface developed in Angular.</p>

<h2>Technologies used:</h2>
<p>
  Backend: .NET Framework (version 4.8 or later), C#, Entity Framework, SQL Server, Git<br>
  Frontend: Angular, TypeScript, HTML, CSS, Bootstrap, Git
</p>

<h2>Entities:</h2>
<ul>
  <li>Hotel: represents a hotel and its properties including name, address, phone number, email, image URL, rating, and status (active/inactive).</li>
  <li>Room: represents a room in a hotel and its properties including hotel (FK to hotel), number, type (single, double, suite, etc.), price, image URL, and status (available/unavailable).</li>
  <li>Guest: represents a guest and their properties including name, email, address, phone number, image URL, and status (active/inactive).</li>
  <li>Reservation: represents a guest's reservation and its properties including date, guest (FK to guest), total amount, and status (pending/confirmed/canceled).</li>
  <li>ReservationRoom: represents a room that is reserved in a reservation and its properties including reservation (FK to reservation), room (FK to room), check-in date, check-out date, and the number of guests.</li>
  <li>Payment: represents a payment made for a reservation and its properties including reservation (FK to reservation), date, amount, and status (pending/paid).</li>
</ul>

<h2>Business rules:</h2>
<ul>
  <li>A guest can make multiple reservations and have multiple phone numbers.</li>
  <li>A reservation can have multiple reservation rooms.</li>
  <li>The total amount of a reservation is calculated as the sum of the prices of all reservation rooms.</li>
  <li>The status of a room must be updated to "unavailable" when a reservation room is added.</li>
  <li>The status of a room must be updated to "available" when a reservation is canceled.</li>
  <li>The status of a reservation must be updated to "confirmed" when a payment is made.</li>
  <li>The status of a reservation must be updated to "canceled" when a reservation is canceled.</li>
</ul>

<h2>API:</h2>
<p>The backend API provides CRUD operations for hotels, rooms, guests, reservations, reservation rooms, and payments. In addition, it provides the following endpoints for generating reports:</p>
<ul>
  <li>Total revenue per hotel.</li>
  <li>Total revenue per room type.</li>
  <li>Total revenue per guest.</li>
  <li>Reservation status (pending/confirmed/canceled) per guest.</li>
</ul>

<h2>Unit tests:</h2>
<p>The project includes unit tests for all the entities and business rules, including updates to room and reservation statuses.</p>

<h2>Background job:</h2>
<p>The system includes a background job that runs every day and updates the availability of rooms based on the check-in and check-out dates of reservations.</p>

<h2>Frontend:</h2>
<p>The frontend interface is built using Angular and provides a user-friendly interface for managing hotels, rooms, guests, reservations, and payments.
