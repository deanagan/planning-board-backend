# Docker image created with:
docker build --pull -t planningboard .

# Docker run
docker run -d -p 8090:80 --name planningboard planningboard

# Docker stop
docker stop planningboard

# Docker check container in use
docker ps -a

# Docker remove container
docker rm [CONTAINER ID]

# Docker commit
docker commit -m "Add comment here" -a "[full name]" planningboard [docker hub username]/planningboard:latest

# Docker login and push committed image
docker login
docker push [docker hub username]/planningboard:latest
