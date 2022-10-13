# Lucene-Net-Example-with-Net-Core-Web-Api

1. Download Lucene Packages
Install-Package Lucene.Net -Version 4.8.0-beta00016


2. Insert Data 
Postman Curl
curl --location --request PUT 'https://localhost:44346/api/lucene' \
--header 'Content-Type: application/json' \
--data-raw '[{
  "firstname": "Farid",
  "lastname": "Maharramov",
  "country": "Azerbaijan",
  "age": 27,
  "gender": "Male"
}]'
