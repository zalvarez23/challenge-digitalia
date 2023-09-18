# Encuesta

Prueba tecnica de encuesta

## Requisitos

- Visual estudio
- Docker

## Tecnologias

- Net 6
- Sql Server - docker
- Entity Framework

## Instalación

1. Clona este repositorio: `git clone https://github.com/zalvarez23/challenge-digitalia.git`
2. Navega a la carpeta del proyecto: `cd challenge-backend`

## Uso

1. Ejecutar : `cd Example.Api/Docker`
2. Ejecutar : `docker-compose up -d`
3. Ejecutar : `ejecutar add migration ` en mi caso `dotnet ef migrations add initPermissionCreate --project /Users/kevinsalazar/Desktop/challenge/hallenge-digitalia/challenge-backend/Example.Repository/Example.Repository.csproj --startup-project Example.api`
4. Ejecutar : `Update Database` en mi caso `dotnet ef database update --project /Users/kevinsalazar/Desktop/challenge/challenge-digitalia/challenge-backend/Example.Repository/Example.Repository.csproj --startup-project  Example.api`
5. Ejecutar la solución.

## APIS:

1. Api para agregar encuesta : POST `http://localhost:7100/api/survey`
   El CURL :
   curl --location --request POST 'http://localhost:7100/api/survey' \
   --header 'Content-Type: application/json' \
   --data-raw '{
   "surveyTitle": "Encuesta de test",
   "surveyStatus": 1,
   "surveyDetails": [
   {
   "surveyQuestion": "¿Qué tan cómodo se siente programando en su lenguaje de programación principal?",
   "questionScore": 2,
   "dateSurveryDetail": "2023-09-17T14:27:28.682858"
   },
   {
   "surveyQuestion": "¿Qué tan familiarizado está con el desarrollo front-end?",
   "questionScore": 0,
   "dateSurveryDetail": "2023-09-17T14:27:28.682868"
   },
   {
   "surveyQuestion": "¿Qué tan familiarizado está con el desarrollo back-end?",
   "questionScore": 0,
   "dateSurveryDetail": "2023-09-17T14:27:28.682873"
   },
   {
   "surveyQuestion": "¿Qué tan cómodo se siente con el uso de frameworks o librerías?",
   "questionScore": 0,
   "dateSurveryDetail": "2023-09-17T14:27:28.682878"
   },
   {
   "surveyQuestion": "¿Qué tan confiado se siente en sus habilidades de resolución de problemas de programación?",
   "questionScore": 0,
   "dateSurveryDetail": "2023-09-17T14:27:28.682884"
   }
   ]
   }'
2. Api para listar encuestas:
   curl --location --request GET 'http://localhost:7100/api/survey'
3. Api para listar Preguntas de Encuesta :
   curl --location --request GET 'http://localhost:7100/api/surveydetail/10'
