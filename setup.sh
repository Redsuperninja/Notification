# Variables
mailhog_image="mailhog/mailhog:v1.0.1"
mailhog_container="mailhog"

docker_install_mailhog(){
    docker container rm $mailhog_container --force
    docker run --name $mailhog_container --detach --publish 1025:1025 --publish 8025:8025 $mailhog_image
}
clear
docker_install_mailhog
# solution_initilize
# generate_rsa_keys Notification
# update_dotnet_packages