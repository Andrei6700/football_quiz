USE master;
GO

CREATE DATABASE MasiniQuizzDB;
GO

USE MasiniQuizzDB;
GO

CREATE TABLE intrebari_masini (
    id INT PRIMARY KEY IDENTITY(1,1),
    intrebare VARCHAR(255) NOT NULL,
    optiune1 VARCHAR(100) NOT NULL,
    optiune2 VARCHAR(100) NOT NULL,
    optiune3 VARCHAR(100) NOT NULL,
    optiune4 VARCHAR(100) NOT NULL,
    raspuns_corect VARCHAR(100) NOT NULL
);
GO

INSERT INTO intrebari_masini (intrebare, optiune1, optiune2, optiune3, optiune4, raspuns_corect) VALUES
('Cine este considerat inventatorul mașinii moderne cu motor pe benzină?', 'Karl Benz', 'Henry Ford', 'Ferdinand Porsche', 'Gottlieb Daimler', 'Karl Benz'),
('Care este cea mai rapidă mașină de serie produsă vreodată?', 'Bugatti Chiron Super Sport 300+', 'Koenigsegg Jesko Absolut', 'SSC Tuatara', 'Hennessey Venom F5', 'Bugatti Chiron Super Sport 300+'),
('Ce model de mașină este cel mai vândut din istorie?', 'Toyota Corolla', 'Volkswagen Beetle', 'Ford Model T', 'Honda Civic', 'Toyota Corolla'),
('Care a fost prima mașină electrică produsă în masă?', 'GM EV1', 'Nissan Leaf', 'Tesla Roadster', 'BMW i3', 'GM EV1'),
('Ce companie auto a introdus prima linie de asamblare în producție?', 'Ford', 'Chevrolet', 'Mercedes-Benz', 'Renault', 'Ford'),
('Care este singura mașină japoneză care a câștigat titlul de European Car of the Year?', 'Nissan Qashqai', 'Toyota Prius', 'Mazda MX-5', 'Honda NSX', 'Nissan Qashqai'),
('Ce model legendar de la Porsche are un motor boxer cu 6 cilindri?', '911', 'Cayenne', 'Panamera', 'Taycan', '911'),
('Cine a inventat volanul modern cu coloană de direcție retractabilă?', 'Béla Barényi', 'Henry Ford', 'Enzo Ferrari', 'Soichiro Honda', 'Béla Barényi'),
('Care echipă a câștigat cele mai multe titluri în Formula 1?', 'Ferrari', 'McLaren', 'Mercedes', 'Williams', 'Ferrari'),
('Ce mașină de lux este simbolul statutului în Dubai?', 'Rolls-Royce Phantom', 'Mercedes-Maybach S-Class', 'Bentley Continental GT', 'Lexus LS', 'Rolls-Royce Phantom'),
('Ce producător auto a dezvoltat prima transmisie automată modernă?', 'General Motors', 'Ford', 'Chrysler', 'BMW', 'General Motors'),
('Care este numele primului SUV hibrid din lume?', 'Toyota Prius', 'Lexus RX 400h', 'Ford Escape Hybrid', 'Tesla Model X', 'Lexus RX 400h'),
('Ce țară produce cele mai multe mașini anual?', 'China', 'Statele Unite', 'Japonia', 'Germania', 'China'),
('Ce mașină a inspirat primul film "The Fast and the Furious"?', 'Toyota Supra', 'Mitsubishi Eclipse', 'Honda Civic', 'Mazda RX-7', 'Mitsubishi Eclipse'),
('Care este singurul producător auto din lista Fortune 500 cu sediul în Michigan?', 'General Motors', 'Ford', 'Fiat Chrysler', 'Tesla', 'General Motors'),
('Ce companie a introdus prima airbag-uri ca dotare standard?', 'Mercedes-Benz', 'Volvo', 'Saab', 'BMW', 'Mercedes-Benz'),
('Ce mașină a fost numită "Auto anului" în 2023?', 'Kia EV6', 'Hyundai Ioniq 5', 'Tesla Model Y', 'BMW i4', 'Kia EV6'),
('Ce producător de supercaruri are un taur pe siglă?', 'Lamborghini', 'Ferrari', 'Pagani', 'Bugatti', 'Lamborghini'),
('Ce mașină electrică de serie are autonomia cea mai mare în 2023?', 'Tesla Model S Plaid', 'Lucid Air Grand Touring', 'Mercedes EQS', 'Rivian R1T', 'Lucid Air Grand Touring'),
('Ce echipă a câștigat primul Campionat Mondial de Raliu?', 'Lancia', 'Audi', 'Peugeot', 'Ford', 'Lancia');
GO

SELECT * FROM intrebari_masini;