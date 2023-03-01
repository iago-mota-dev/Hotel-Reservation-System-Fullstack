DROP SCHEMA IF EXISTS hotel_reservation_system;

CREATE SCHEMA hotel_reservation_system;

USE hotel_reservation_system;

CREATE TABLE Hotel (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  address VARCHAR(255) NOT NULL,
  phone_number VARCHAR(20) NOT NULL,
  email VARCHAR(255) NOT NULL,
  image_url VARCHAR(255) NOT NULL,
  rating DECIMAL(3,2) NOT NULL,
  hotelstatus ENUM('active', 'inactive') NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE Room (
  id INT NOT NULL AUTO_INCREMENT,
  hotel_id INT NOT NULL,
  room_number INT NOT NULL,
  room_type VARCHAR(50) NOT NULL,
  price DECIMAL(8,2) NOT NULL,
  image_url VARCHAR(255) NOT NULL,
  roomstatus ENUM('available', 'unavailable') NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (hotel_id) REFERENCES Hotel(id)
);

CREATE TABLE Guest (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  address VARCHAR(255) NOT NULL,
  image_url VARCHAR(255) NOT NULL,
  gueststatus ENUM('active', 'inactive') NOT NULL,
  PRIMARY KEY (id)
);

CREATE TABLE Phones (
  id INT NOT NULL AUTO_INCREMENT,
  phone_number VARCHAR(20) NOT NULL,
  guest_id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (guest_id) REFERENCES Guest(id)
);

CREATE TABLE Reservation (
  id INT NOT NULL AUTO_INCREMENT,
  reservation_date DATE NOT NULL,
  guest_id INT NOT NULL,
  total_amount DECIMAL(8,2) NOT NULL,
  reservationstatus ENUM('pending', 'confirmed', 'canceled') NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (guest_id) REFERENCES Guest(id)
);

CREATE TABLE ReservationRoom (
  id INT NOT NULL AUTO_INCREMENT,
  reservation_id INT NOT NULL,
  room_id INT NOT NULL,
  check_in_date DATE NOT NULL,
  check_out_date DATE NOT NULL,
  number_of_guests INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (reservation_id) REFERENCES Reservation(id),
  FOREIGN KEY (room_id) REFERENCES Room(id)
);

CREATE TABLE Payment (
  id INT NOT NULL AUTO_INCREMENT,
  reservation_id INT NOT NULL,
  payment_date DATE NOT NULL,
  amount DECIMAL(8,2) NOT NULL,
  paymentstatus ENUM('pending', 'paid') NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (reservation_id) REFERENCES Reservation(id)
);
