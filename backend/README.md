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